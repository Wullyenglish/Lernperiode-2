namespace Schulplaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Bitte geben Sie einen Namen ein.", "Fehlende Angabe");
                textBoxName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFach.Text))
            {
                MessageBox.Show("Bitte geben Sie ein Fach ein.", "Fehlende Angabe");
                textBoxFach.Focus();
                return;
            }

            dataGridViewTermine.Rows.Add(
                textBoxName.Text.Trim(),
                textBoxFach.Text.Trim(),
                dateTimePickerDatum.Value.ToShortDateString());
            dataGridViewTermine.ClearSelection();

            textBoxName.Clear();
            textBoxFach.Clear();
            dateTimePickerDatum.Value = DateTime.Today;
            textBoxName.Focus();
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
                    zeile.Cells["spalteDatum"].Value?.ToString() ?? ""
                });
            }

            return termine;
        }
    }
}
