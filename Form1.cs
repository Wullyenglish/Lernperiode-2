using System.Globalization;
using System.Text.Json;

namespace Schulplaner
{
    public partial class Form1 : Form
    {
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
            LadeTermine();
            AktualisiereKalender();
            dataGridViewTermine.SelectionChanged += dataGridViewTermine_SelectionChanged;
            monthCalendarTermine.DateSelected += monthCalendarTermine_DateSelected;
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (!EingabenGueltig())
            {
                return;
            }

            dataGridViewTermine.Rows.Add(
                textBoxName.Text.Trim(),
                textBoxFach.Text.Trim(),
                dateTimePickerDatum.Value.ToShortDateString(),
                comboBoxArt.SelectedItem?.ToString() ?? "Anderer Termin");

            dataGridViewTermine.ClearSelection();
            LeereEingaben();
            AktualisiereKalender();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Termin aus.");
                return;
            }

            dataGridViewTermine.Rows.Remove(dataGridViewTermine.SelectedRows[0]);
            dataGridViewTermine.ClearSelection();
            LeereEingaben();
            AktualisiereKalender();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            if (dataGridViewTermine.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Termin aus.");
                return;
            }

            if (!EingabenGueltig())
            {
                return;
            }

            DataGridViewRow zeile = dataGridViewTermine.SelectedRows[0];
            zeile.Cells["spalteName"].Value = textBoxName.Text.Trim();
            zeile.Cells["spalteFach"].Value = textBoxFach.Text.Trim();
            zeile.Cells["spalteDatum"].Value = dateTimePickerDatum.Value.ToShortDateString();
            zeile.Cells["spalteArt"].Value = comboBoxArt.SelectedItem?.ToString() ?? "Anderer Termin";

            dataGridViewTermine.ClearSelection();
            LeereEingaben();
            AktualisiereKalender();
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

            if (VersucheDatum(zeile.Cells["spalteDatum"].Value?.ToString(), out DateTime datum))
            {
                dateTimePickerDatum.Value = datum;
            }
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

        private bool EingabenGueltig()
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

                termine.Add(new[]
                {
                    zeile.Cells["spalteName"].Value?.ToString() ?? "",
                    zeile.Cells["spalteFach"].Value?.ToString() ?? "",
                    zeile.Cells["spalteDatum"].Value?.ToString() ?? "",
                    zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin"
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
                        datum.ToShortDateString(),
                        termin.Length == 4 ? termin[3] : "Anderer Termin");
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
                if (termin == null || (termin.Length != 3 && termin.Length != 4)
                    || !VersucheDatum(termin[2], out _))
                {
                    throw new JsonException("Ein gespeicherter Termin ist unvollständig.");
                }
            }

            return termine;
        }
        private static bool VersucheDatum(string? text, out DateTime datum)
        {
            return DateTime.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum)
                || DateTime.TryParse(text, CultureInfo.CurrentCulture, DateTimeStyles.None, out datum)
                || DateTime.TryParse(text, CultureInfo.GetCultureInfo("de-CH"), DateTimeStyles.None, out datum);
        }

        private void AktualisiereKalender()
        {
            HashSet<DateTime> daten = new();

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (VersucheDatum(zeile.Cells["spalteDatum"].Value?.ToString(), out DateTime datum))
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
            DateTime ausgewaehlterTag = monthCalendarTermine.SelectionStart.Date;

            foreach (DataGridViewRow zeile in dataGridViewTermine.Rows)
            {
                if (VersucheDatum(zeile.Cells["spalteDatum"].Value?.ToString(), out DateTime datum)
                    && datum.Date == ausgewaehlterTag)
                {
                    string art = zeile.Cells["spalteArt"].Value?.ToString() ?? "Anderer Termin";
                    string name = zeile.Cells["spalteName"].Value?.ToString() ?? "";
                    string fach = zeile.Cells["spalteFach"].Value?.ToString() ?? "";
                    listBoxTagesTermine.Items.Add($"{art}: {name} ({fach})");
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
                if (!VersucheDatum(zeile.Cells["spalteDatum"].Value?.ToString(), out DateTime datum)
                    || datum.Date < heute || datum.Date > letzterTag)
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
                MessageBox.Show("In den nächsten 7 Tagen stehen keine Termine an.", "Erinnerungen");
            }
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
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                MessageBox.Show($"Die Termine konnten nicht gespeichert werden.\n{ex.Message}", "Fehler beim Speichern");
                e.Cancel = true;
            }
        }
    }
}
