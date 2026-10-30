namespace Schulplaner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitel = new Label();
            labelName = new Label();
            labelFach = new Label();
            labelDatum = new Label();
            labelArt = new Label();
            labelTagesTermine = new Label();
            textBoxName = new TextBox();
            textBoxFach = new TextBox();
            dateTimePickerDatum = new DateTimePicker();
            comboBoxArt = new ComboBox();
            buttonHinzufügen = new Button();
            buttonLöschen = new Button();
            buttonBearbeiten = new Button();
            buttonErinnerungen = new Button();
            dataGridViewTermine = new DataGridView();
            spalteName = new DataGridViewTextBoxColumn();
            spalteFach = new DataGridViewTextBoxColumn();
            spalteDatum = new DataGridViewTextBoxColumn();
            spalteArt = new DataGridViewTextBoxColumn();
            monthCalendarTermine = new MonthCalendar();
            listBoxTagesTermine = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTermine).BeginInit();
            SuspendLayout();
            labelTitel.AutoSize = true;
            labelTitel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitel.Location = new Point(30, 25);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(195, 45);
            labelTitel.TabIndex = 0;
            labelTitel.Text = "Schulplaner";
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 100);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            labelFach.AutoSize = true;
            labelFach.Location = new Point(30, 160);
            labelFach.Name = "labelFach";
            labelFach.Size = new Size(47, 25);
            labelFach.TabIndex = 3;
            labelFach.Text = "Fach";
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(30, 220);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(66, 25);
            labelDatum.TabIndex = 5;
            labelDatum.Text = "Datum";
            labelArt.AutoSize = true;
            labelArt.Location = new Point(30, 280);
            labelArt.Name = "labelArt";
            labelArt.Size = new Size(96, 25);
            labelArt.TabIndex = 7;
            labelArt.Text = "Terminart";
            labelTagesTermine.AutoSize = true;
            labelTagesTermine.Location = new Point(790, 345);
            labelTagesTermine.Name = "labelTagesTermine";
            labelTagesTermine.Size = new Size(239, 25);
            labelTagesTermine.TabIndex = 14;
            labelTagesTermine.Text = "Termine am ausgewählten Tag";
            textBoxName.Location = new Point(130, 97);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 31);
            textBoxName.TabIndex = 2;
            textBoxFach.Location = new Point(130, 157);
            textBoxFach.Name = "textBoxFach";
            textBoxFach.Size = new Size(300, 31);
            textBoxFach.TabIndex = 4;
            dateTimePickerDatum.Format = DateTimePickerFormat.Short;
            dateTimePickerDatum.Location = new Point(130, 217);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(300, 31);
            dateTimePickerDatum.TabIndex = 6;
            comboBoxArt.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArt.FormattingEnabled = true;
            comboBoxArt.Items.AddRange(new object[] { "Prüfung", "Hausaufgabe", "Anderer Termin" });
            comboBoxArt.Location = new Point(130, 277);
            comboBoxArt.Name = "comboBoxArt";
            comboBoxArt.Size = new Size(300, 33);
            comboBoxArt.TabIndex = 8;
            comboBoxArt.SelectedIndex = 2;
            buttonHinzufügen.Location = new Point(130, 335);
            buttonHinzufügen.Name = "buttonHinzufügen";
            buttonHinzufügen.Size = new Size(150, 36);
            buttonHinzufügen.TabIndex = 9;
            buttonHinzufügen.Text = "Hinzufügen";
            buttonHinzufügen.UseVisualStyleBackColor = true;
            buttonHinzufügen.Click += buttonHinzufügen_Click;
            buttonLöschen.Location = new Point(290, 335);
            buttonLöschen.Name = "buttonLöschen";
            buttonLöschen.Size = new Size(150, 36);
            buttonLöschen.TabIndex = 10;
            buttonLöschen.Text = "Löschen";
            buttonLöschen.UseVisualStyleBackColor = true;
            buttonLöschen.Click += buttonLöschen_Click;
            buttonBearbeiten.Location = new Point(450, 335);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(150, 36);
            buttonBearbeiten.TabIndex = 11;
            buttonBearbeiten.Text = "Ändern";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            buttonBearbeiten.Click += buttonBearbeiten_Click;
            buttonErinnerungen.Location = new Point(610, 335);
            buttonErinnerungen.Name = "buttonErinnerungen";
            buttonErinnerungen.Size = new Size(150, 36);
            buttonErinnerungen.TabIndex = 12;
            buttonErinnerungen.Text = "Erinnerungen";
            buttonErinnerungen.UseVisualStyleBackColor = true;
            buttonErinnerungen.Click += buttonErinnerungen_Click;
            dataGridViewTermine.AllowUserToAddRows = false;
            dataGridViewTermine.AllowUserToDeleteRows = false;
            dataGridViewTermine.AllowUserToResizeColumns = false;
            dataGridViewTermine.AllowUserToResizeRows = false;
            dataGridViewTermine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTermine.Columns.AddRange(new DataGridViewColumn[] { spalteName, spalteFach, spalteDatum, spalteArt });
            dataGridViewTermine.Location = new Point(30, 390);
            dataGridViewTermine.MultiSelect = false;
            dataGridViewTermine.Name = "dataGridViewTermine";
            dataGridViewTermine.RowHeadersWidth = 50;
            dataGridViewTermine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTermine.Size = new Size(740, 255);
            dataGridViewTermine.TabIndex = 13;
            spalteName.HeaderText = "Name";
            spalteName.Name = "spalteName";
            spalteName.ReadOnly = true;
            spalteName.Width = 170;
            spalteFach.HeaderText = "Fach";
            spalteFach.Name = "spalteFach";
            spalteFach.ReadOnly = true;
            spalteFach.Width = 170;
            spalteDatum.HeaderText = "Datum";
            spalteDatum.Name = "spalteDatum";
            spalteDatum.ReadOnly = true;
            spalteDatum.Width = 150;
            spalteArt.HeaderText = "Terminart";
            spalteArt.Name = "spalteArt";
            spalteArt.ReadOnly = true;
            spalteArt.Width = 170;
            monthCalendarTermine.Location = new Point(790, 100);
            monthCalendarTermine.MaxSelectionCount = 1;
            monthCalendarTermine.Name = "monthCalendarTermine";
            monthCalendarTermine.TabIndex = 15;
            listBoxTagesTermine.FormattingEnabled = true;
            listBoxTagesTermine.HorizontalScrollbar = true;
            listBoxTagesTermine.IntegralHeight = false;
            listBoxTagesTermine.Location = new Point(790, 380);
            listBoxTagesTermine.Name = "listBoxTagesTermine";
            listBoxTagesTermine.Size = new Size(285, 265);
            listBoxTagesTermine.TabIndex = 16;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(listBoxTagesTermine);
            Controls.Add(monthCalendarTermine);
            Controls.Add(dataGridViewTermine);
            Controls.Add(buttonErinnerungen);
            Controls.Add(buttonBearbeiten);
            Controls.Add(buttonLöschen);
            Controls.Add(buttonHinzufügen);
            Controls.Add(comboBoxArt);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(textBoxFach);
            Controls.Add(textBoxName);
            Controls.Add(labelTagesTermine);
            Controls.Add(labelArt);
            Controls.Add(labelDatum);
            Controls.Add(labelFach);
            Controls.Add(labelName);
            Controls.Add(labelTitel);
            Name = "Form1";
            Text = "Schulplaner";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTermine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitel;
        private Label labelName;
        private Label labelFach;
        private Label labelDatum;
        private Label labelArt;
        private Label labelTagesTermine;
        private TextBox textBoxName;
        private TextBox textBoxFach;
        private DateTimePicker dateTimePickerDatum;
        private ComboBox comboBoxArt;
        private Button buttonHinzufügen;
        private Button buttonLöschen;
        private Button buttonBearbeiten;
        private Button buttonErinnerungen;
        private DataGridView dataGridViewTermine;
        private DataGridViewTextBoxColumn spalteName;
        private DataGridViewTextBoxColumn spalteFach;
        private DataGridViewTextBoxColumn spalteDatum;
        private DataGridViewTextBoxColumn spalteArt;
        private MonthCalendar monthCalendarTermine;
        private ListBox listBoxTagesTermine;
    }
}
