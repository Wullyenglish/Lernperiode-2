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
            MessageBox.Show(
                $"Name: {textBoxName.Text}\nFach: {textBoxFach.Text}\nDatum: {textBoxDatum.Text}",
                "Termin");
        }
    }
}
