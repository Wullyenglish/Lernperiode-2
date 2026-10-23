namespace Schulplaner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitel = new Label();
            labelName = new Label();
            labelFach = new Label();
            labelDatum = new Label();
            textBoxName = new TextBox();
            textBoxFach = new TextBox();
            buttonHinzufuegen = new Button();
            dateTimePickerDatum = new DateTimePicker();
            dataGridViewTermine = new DataGridView();
            spalteName = new DataGridViewTextBoxColumn();
            spalteFach = new DataGridViewTextBoxColumn();
            spalteDatum = new DataGridViewTextBoxColumn();
            buttonLoeschen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTermine).BeginInit();
            SuspendLayout();
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitel.Location = new Point(30, 25);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(195, 45);
            labelTitel.TabIndex = 0;
            labelTitel.Text = "Schulplaner";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 100);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelFach
            // 
            labelFach.AutoSize = true;
            labelFach.Location = new Point(30, 160);
            labelFach.Name = "labelFach";
            labelFach.Size = new Size(47, 25);
            labelFach.TabIndex = 3;
            labelFach.Text = "Fach";
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(30, 220);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(66, 25);
            labelDatum.TabIndex = 5;
            labelDatum.Text = "Datum";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(130, 97);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 31);
            textBoxName.TabIndex = 2;
            // 
            // textBoxFach
            // 
            textBoxFach.Location = new Point(130, 157);
            textBoxFach.Name = "textBoxFach";
            textBoxFach.Size = new Size(300, 31);
            textBoxFach.TabIndex = 4;
            // 
            // buttonHinzufuegen
            // 
            buttonHinzufuegen.Location = new Point(130, 280);
            buttonHinzufuegen.Name = "buttonHinzufuegen";
            buttonHinzufuegen.Size = new Size(150, 36);
            buttonHinzufuegen.TabIndex = 7;
            buttonHinzufuegen.Text = "Hinzufügen";
            buttonHinzufuegen.UseVisualStyleBackColor = true;
            buttonHinzufuegen.Click += buttonHinzufuegen_Click;
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Format = DateTimePickerFormat.Short;
            dateTimePickerDatum.Location = new Point(130, 224);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(300, 31);
            dateTimePickerDatum.TabIndex = 6;
            // 
            // dataGridViewTermine
            // 
            dataGridViewTermine.AllowUserToAddRows = false;
            dataGridViewTermine.AllowUserToDeleteRows = false;
            dataGridViewTermine.AllowUserToResizeColumns = false;
            dataGridViewTermine.AllowUserToResizeRows = false;
            dataGridViewTermine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTermine.Columns.AddRange(new DataGridViewColumn[] { spalteName, spalteFach, spalteDatum });
            dataGridViewTermine.Location = new Point(30, 337);
            dataGridViewTermine.MultiSelect = false;
            dataGridViewTermine.Name = "dataGridViewTermine";
            dataGridViewTermine.RowHeadersWidth = 62;
            dataGridViewTermine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTermine.Size = new Size(740, 225);
            dataGridViewTermine.TabIndex = 9;
            // 
            // spalteName
            // 
            spalteName.HeaderText = "Name";
            spalteName.MinimumWidth = 8;
            spalteName.Name = "spalteName";
            spalteName.ReadOnly = true;
            spalteName.Width = 150;
            // 
            // spalteFach
            // 
            spalteFach.HeaderText = "Fach";
            spalteFach.MinimumWidth = 8;
            spalteFach.Name = "spalteFach";
            spalteFach.ReadOnly = true;
            spalteFach.Width = 150;
            // 
            // spalteDatum
            // 
            spalteDatum.HeaderText = "Datum";
            spalteDatum.MinimumWidth = 8;
            spalteDatum.Name = "spalteDatum";
            spalteDatum.ReadOnly = true;
            spalteDatum.Width = 150;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(280, 280);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(150, 36);
            buttonLoeschen.TabIndex = 8;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 648);
            Controls.Add(buttonLoeschen);
            Controls.Add(dataGridViewTermine);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(buttonHinzufuegen);
            Controls.Add(textBoxFach);
            Controls.Add(textBoxName);
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
        private TextBox textBoxName;
        private TextBox textBoxFach;
        private Button buttonHinzufuegen;
        private DateTimePicker dateTimePickerDatum;
        private DataGridView dataGridViewTermine;
        private DataGridViewTextBoxColumn spalteName;
        private DataGridViewTextBoxColumn spalteFach;
        private DataGridViewTextBoxColumn spalteDatum;
        private Button buttonLoeschen;
    }
}
