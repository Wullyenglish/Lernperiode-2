using System.ComponentModel;
using System.Globalization;
using System.Text.Json;

namespace Schulplaner
{
    public partial class Form1 : Form
    {
        private const string StatusOffen = "Offen";
        private const string StatusErledigt = "Erledigt";
        private readonly string dateiPfad;
        private bool ladenFehlgeschlagen;

        public Form1() : this(Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Schulplaner",
            "termine.json"))
        {
        }

        internal Form1(string dateiPfad)
        {
            this.dateiPfad = dateiPfad;
            InitializeComponent();
            comboBoxFilter.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            GestalteOberfläche();
            LadeTermine();
            SortiereTermine();
            AktualisiereZeilenfarben();
            AktualisiereFilter();
            AktualisiereKalender();
            AktualisiereZähler();
            dataGridViewTermine.SelectionChanged += dataGridViewTermine_SelectionChanged;

            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            comboBoxStatus.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            monthCalendarTermine.DateSelected += monthCalendarTermine_DateSelected;
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            if (!EingabenGültig())
            {
                return;
            }

            dataGridViewTermine.Rows.Add(
                textBoxName.Text.Trim(),
                textBoxFach.Text.Trim(),
                dateTimePickerDatum.Value.Date,
                comboBoxArt.SelectedItem?.ToString() ?? "Anderer Termin",
                StatusOffen,
                textBoxNotiz.Text.Trim());

            AktualisiereAnsicht();
            LeereEingaben();
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {
            LöscheAusgewähltenTermin(BestätigeLöschen);
        }

        private DialogResult BestätigeLöschen(string terminname)
        {
            return MessageBox.Show(
                this,
                $"Möchten Sie den Termin «{terminname}» wirklich löschen?",
                "Termin löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }


        private void LöscheAusgewähltenTermin(Func<string, DialogResult> bestätige)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Termin aus.");
                return;
            }

            DataGridViewRow zeile = dataGridViewTermine.SelectedRows[0];
            string terminname = zeile.Cells["spalteName"].Value?.ToString() ?? "";
            if (bestätige(terminname) != DialogResult.Yes)
            {
                return;
            }

            dataGridViewTermine.Rows.Remove(zeile);
            AktualisiereAnsicht();
            LeereEingaben();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Termin aus.");
                return;
            }

            if (!EingabenGültig())
            {
                return;
            }

            DataGridViewRow zeile = dataGridViewTermine.SelectedRows[0];
            zeile.Cells["spalteName"].Value = textBoxName.Text.Trim();
            zeile.Cells["spalteFach"].Value = textBoxFach.Text.Trim();
            zeile.Cells["spalteDatum"].Value = dateTimePickerDatum.Value.Date;
            zeile.Cells["spalteArt"].Value = comboBoxArt.SelectedItem?.ToString() ?? "Anderer Termin";
            zeile.Cells["spalteNotiz"].Value = textBoxNotiz.Text.Trim();

            AktualisiereAnsicht();
            LeereEingaben();
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Termin aus.");
                return;
            }

            DataGridViewRow zeile = dataGridViewTermine.SelectedRows[0];
            string status = zeile.Cells["spalteStatus"].Value?.ToString() ?? StatusOffen;
            zeile.Cells["spalteStatus"].Value = status == StatusErledigt ? StatusOffen : StatusErledigt;
            AktualisiereZeilenfarben();
            AktualisiereFilter();
            AktualisiereTagesliste();
            AktualisiereZähler();
        }

        private void dataGridViewTermine_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow zeile = dataGridViewTermine.SelectedRows[0];
            textBoxName.Text = zeile.Cells["spalteName"].Value?.ToString() ?? "";
            textBoxFach.Text = zeile.Cells["spalteFach"].Value?.ToString() ?? "";
            comboBoxArt.SelectedItem = zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin";
            textBoxNotiz.Text = zeile.Cells["spalteNotiz"].Value?.ToString() ?? "";

            if (VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum))
            {
                dateTimePickerDatum.Value = datum;
            }
        }


        private void comboBoxFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AktualisiereFilter();
        }

        private void monthCalendarTermine_DateSelected(object? sender, DateRangeEventArgs e)
        {
            AktualisiereTagesliste();
        }

        private void buttonErinnerungen_Click(object sender, EventArgs e)
        {
            ZeigeErinnerungen(true);
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            ZeigeErinnerungen(false);
        }

        private bool EingabenGültig()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Bitte geben Sie einen Namen ein.", "Fehlende Angabe");
                textBoxName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxFach.Text))
            {
                MessageBox.Show("Bitte geben Sie ein Fach ein.", "Fehlende Angabe");
                textBoxFach.Focus();
                return false;
            }

            return true;
        }

        private void LeereEingaben()
        {
            textBoxName.Clear();
            textBoxFach.Clear();
            dateTimePickerDatum.Value = DateTime.Today;
            comboBoxArt.SelectedItem = "Anderer Termin";
            textBoxName.Focus();
            textBoxNotiz.Clear();
        }

        private void AktualisiereAnsicht()
        {
            SortiereTermine();
            AktualisiereZeilenfarben();
            AktualisiereFilter();
            AktualisiereKalender();
            AktualisiereZähler();
        }

        private void AktualisiereZähler()
        {
            int offen = 0;
            int erledigt = 0;
            int überfällig = 0;

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (zeile.Cells["spalteStatus"].Value?.ToString() == StatusErledigt)
                {
                    erledigt++;
                    continue;
                }

                offen++;
                if (VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum)
                    && datum.Date < DateTime.Today)
                {
                    überfällig++;
                }
            }

            labelOffen.Text = $"Offen: {offen}";
            labelErledigt.Text = $"Erledigt: {erledigt}";
            labelÜberfällig.Text = $"Überfällig: {überfällig}";
        }

        private void SortiereTermine()
        {
            if (dataGridViewTermine.Rows.Count > 1)
            {
                dataGridViewTermine.Sort(spalteDatum, ListSortDirection.Ascending);
            }

            spalteDatum.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            dataGridViewTermine.ClearSelection();
        }

        private void AktualisiereFilter()
        {
            string artFilter = comboBoxFilter.SelectedItem?.ToString() ?? "Alle";
            string statusFilter = comboBoxStatus.SelectedItem?.ToString() ?? "Alle";
            dataGridViewTermine.CurrentCell = null;
            dataGridViewTermine.ClearSelection();

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                string art = zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin";
                string status = zeile.Cells["spalteStatus"].Value?.ToString() ?? StatusOffen;
                zeile.Visible = (artFilter == "Alle" || art == artFilter)
                    && (statusFilter == "Alle" || status == statusFilter);
            }
        }

        private void AktualisiereZeilenfarben()
        {
            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                bool erledigt = zeile.Cells["spalteStatus"].Value?.ToString() == StatusErledigt;
                bool hatDatum = VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum);
                bool überfällig = !erledigt && hatDatum && datum.Date < DateTime.Today;
                if (erledigt)
                {
                    zeile.DefaultCellStyle.BackColor = Color.FromArgb(229, 241, 232);
                }
                else if (überfällig)
                {
                    zeile.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                }
                else
                {
                    zeile.DefaultCellStyle.BackColor = zeile.Index % 2 == 0
                        ? Color.White
                        : Color.FromArgb(247, 250, 252);
                }
                zeile.DefaultCellStyle.ForeColor = erledigt
                    ? Color.FromArgb(72, 107, 82)
                    : Color.FromArgb(36, 51, 70);
            }
        }

        private List<string[]> SammleTermine()
        {
            List<string[]> termine = new();

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (zeile.IsNewRow)
                {
                    continue;
                }

                if (!VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum))
                {
                    throw new JsonException("Ein Termin hat kein gültiges Datum.");
                }

                termine.Add(new[]
                {
                    zeile.Cells["spalteName"].Value?.ToString() ?? "",
                    zeile.Cells["spalteFach"].Value?.ToString() ?? "",
                    datum.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin",
                    zeile.Cells["spalteStatus"].Value?.ToString() ?? StatusOffen,
                    zeile.Cells["spalteNotiz"].Value?.ToString() ?? ""
                });
            }

            return termine;
        }

        private void LadeTermine()
        {
            try
            {
                foreach (string[] termin in LiesTermineAusDatei(dateiPfad))
                {
                    VersucheDatum(termin[2], out DateTime datum);
                    dataGridViewTermine.Rows.Add(
                        termin[0],
                        termin[1],
                        datum.Date,
                        termin.Length >= 4 ? termin[3] : "Anderer Termin",
                        termin.Length >= 5 && termin[4] == StatusErledigt ? StatusErledigt : StatusOffen,
                        termin.Length >= 6 ? termin[5] : "");
                }

                dataGridViewTermine.ClearSelection();
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException)
            {
                ladenFehlgeschlagen = true;
                MessageBox.Show(
                    $"Die gespeicherten Termine konnten nicht geladen werden. Die Datei bleibt unverändert; neue Termine aus dieser Sitzung werden nicht gespeichert.\n{ex.Message}",
                    "Fehler beim Laden");
            }
        }

        private static List<string[]> LiesTermineAusDatei(string pfad)
        {
            if (!File.Exists(pfad))
            {
                return new List<string[]>();
            }

            string json = File.ReadAllText(pfad);
            List<string[]> termine = JsonSerializer.Deserialize<List<string[]>>(json)
                ?? throw new JsonException("Die Datei enthält keine Terminliste.");

            foreach (string[] termin in termine)
            {
                if (termin == null || (termin.Length != 3 && termin.Length != 4 && termin.Length != 5 && termin.Length != 6)
                    || !VersucheDatum(termin[2], out _))
                {
                    throw new JsonException("Ein gespeicherter Termin ist unvollständig.");
                }
            }

            return termine;
        }

        private static bool VersucheDatum(object? wert, out DateTime datum)
        {
            if (wert is DateTime direktesDatum)
            {
                datum = direktesDatum;
                return true;
            }

            string? text = wert?.ToString();
            return DateTime.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum)
                || DateTime.TryParse(text, CultureInfo.CurrentCulture, DateTimeStyles.None, out datum)
                || DateTime.TryParse(text, CultureInfo.GetCultureInfo("de-CH"), DateTimeStyles.None, out datum);
        }

        private void AktualisiereKalender()
        {
            HashSet<DateTime> daten = new();

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum))
                {
                    daten.Add(datum.Date);
                }
            }

            monthCalendarTermine.BoldedDates = new List<DateTime>(daten).ToArray();
            monthCalendarTermine.UpdateBoldedDates();
            AktualisiereTagesliste();
        }

        private void AktualisiereTagesliste()
        {
            listBoxTagesTermine.Items.Clear();
            DateTime ausgewählterTag = monthCalendarTermine.SelectionStart.Date;

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum)
                    && datum.Date == ausgewählterTag)
                {
                    string art = zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin";
                    string name = zeile.Cells["spalteName"].Value?.ToString() ?? "";
                    string fach = zeile.Cells["spalteFach"].Value?.ToString() ?? "";
                    string status = zeile.Cells["spalteStatus"].Value?.ToString() ?? StatusOffen;
                    listBoxTagesTermine.Items.Add($"{art}: {name} ({fach}) – {status}");
                }
            }
        }

        private void ZeigeErinnerungen(bool auchWennLeer)
        {
            List<string> erinnerungen = new();
            DateTime heute = DateTime.Today;
            DateTime letzterTag = heute.AddDays(7);

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (!VersucheDatum(zeile.Cells["spalteDatum"].Value, out DateTime datum)
                    || datum.Date < heute || datum.Date > letzterTag
                    || zeile.Cells["spalteStatus"].Value?.ToString() == StatusErledigt)
                {
                    continue;
                }

                string art = zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin";
                string name = zeile.Cells["spalteName"].Value?.ToString() ?? "";
                string fach = zeile.Cells["spalteFach"].Value?.ToString() ?? "";
                erinnerungen.Add($"{datum:dd.MM.yyyy}: {art} – {name} ({fach})");
            }

            if (erinnerungen.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erinnerungen), "Termine in den nächsten 7 Tagen");
            }
            else if (auchWennLeer)
            {
                MessageBox.Show("In den nächsten 7 Tagen stehen keine offenen Termine an.", "Erinnerungen");
            }
        }

        private void GestalteOberfläche()
        {
            Color dunkelblau = Color.FromArgb(35, 56, 78);
            BackColor = Color.FromArgb(244, 248, 251);
            ForeColor = dunkelblau;
            MinimumSize = new Size(1120, 720);
            StartPosition = FormStartPosition.CenterScreen;
            labelTitel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitel.ForeColor = dunkelblau;

            foreach (Label zähler in new[] { labelOffen, labelErledigt, labelÜberfällig })
            {
                zähler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            labelOffen.ForeColor = dunkelblau;
            labelErledigt.ForeColor = Color.FromArgb(72, 107, 82);
            labelÜberfällig.ForeColor = Color.FromArgb(177, 73, 78);

            foreach (Label beschriftung in new[] { labelName, labelFach, labelDatum, labelArt, labelFilter, labelKalender, labelTagesTermine })
            {
                beschriftung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                beschriftung.ForeColor = dunkelblau;
            }

            foreach (Button knopf in new[] { buttonHinzufügen, buttonLöschen, buttonBearbeiten, buttonStatus, buttonErinnerungen })
            {
                knopf.FlatStyle = FlatStyle.Flat;
                knopf.FlatAppearance.BorderSize = 0;
                knopf.ForeColor = Color.White;
                knopf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                knopf.Cursor = Cursors.Hand;
                knopf.UseVisualStyleBackColor = false;
            }

            buttonHinzufügen.BackColor = Color.FromArgb(28, 128, 122);
            buttonBearbeiten.BackColor = Color.FromArgb(54, 108, 165);
            buttonLöschen.BackColor = Color.FromArgb(177, 73, 78);
            buttonStatus.BackColor = Color.FromArgb(75, 133, 88);
            buttonErinnerungen.BackColor = Color.FromArgb(166, 108, 49);

            dataGridViewTermine.BackgroundColor = Color.White;
            dataGridViewTermine.BorderStyle = BorderStyle.None;
            dataGridViewTermine.GridColor = Color.FromArgb(219, 229, 236);
            dataGridViewTermine.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTermine.EnableHeadersVisualStyles = false;
            dataGridViewTermine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTermine.ColumnHeadersHeight = 38;
            dataGridViewTermine.ColumnHeadersDefaultCellStyle.BackColor = dunkelblau;
            dataGridViewTermine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTermine.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewTermine.DefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 226, 239);
            dataGridViewTermine.DefaultCellStyle.SelectionForeColor = dunkelblau;
            dataGridViewTermine.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dataGridViewTermine.RowTemplate.Height = 34;
            listBoxTagesTermine.BackColor = Color.White;
            listBoxTagesTermine.Font = new Font("Segoe UI", 9.5F);
            monthCalendarTermine.TitleBackColor = dunkelblau;
            monthCalendarTermine.TitleForeColor = Color.White;
        }

        private static void SchreibeTermineInDatei(string pfad, List<string[]> termine)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(pfad)!);
            string json = JsonSerializer.Serialize(
                termine,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(pfad, json);
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (ladenFehlgeschlagen)
            {
                return;
            }

            try
            {
                SchreibeTermineInDatei(dateiPfad, SammleTermine());
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException)
            {
                MessageBox.Show($"Die Termine konnten nicht gespeichert werden.\n{ex.Message}", "Fehler beim Speichern");
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
