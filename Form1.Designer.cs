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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelTitel = new Label();
            labelName = new Label();
            labelFach = new Label();
            labelDatum = new Label();
            labelArt = new Label();
            labelFilter = new Label();
            labelKalender = new Label();
            labelTagesTermine = new Label();
            textBoxName = new TextBox();
            textBoxFach = new TextBox();
            dateTimePickerDatum = new DateTimePicker();
            comboBoxArt = new ComboBox();
            comboBoxFilter = new ComboBox();
            buttonHinzufügen = new Button();
            buttonBearbeiten = new Button();
            buttonLöschen = new Button();
            buttonStatus = new Button();
            buttonErinnerungen = new Button();
            dataGridViewTermine = new DataGridView();
            spalteName = new DataGridViewTextBoxColumn();
            spalteFach = new DataGridViewTextBoxColumn();
            spalteDatum = new DataGridViewTextBoxColumn();
            spalteArt = new DataGridViewTextBoxColumn();
            spalteStatus = new DataGridViewTextBoxColumn();
            spalteNotiz = new DataGridViewTextBoxColumn();
            monthCalendarTermine = new MonthCalendar();
            listBoxTagesTermine = new ListBox();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            labelNotiz = new Label();
            textBoxNotiz = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTermine).BeginInit();
            SuspendLayout();
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Location = new Point(30, 20);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(103, 25);
            labelTitel.TabIndex = 0;
            labelTitel.Text = "Schulplaner";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 98);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelFach
            // 
            labelFach.AutoSize = true;
            labelFach.Location = new Point(30, 148);
            labelFach.Name = "labelFach";
            labelFach.Size = new Size(47, 25);
            labelFach.TabIndex = 3;
            labelFach.Text = "Fach";
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(30, 198);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(66, 25);
            labelDatum.TabIndex = 5;
            labelDatum.Text = "Datum";
            // 
            // labelArt
            // 
            labelArt.AutoSize = true;
            labelArt.Location = new Point(30, 248);
            labelArt.Name = "labelArt";
            labelArt.Size = new Size(85, 25);
            labelArt.TabIndex = 7;
            labelArt.Text = "Terminart";
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(30, 303);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(50, 25);
            labelFilter.TabIndex = 9;
            labelFilter.Text = "Filter";
            // 
            // labelKalender
            // 
            labelKalender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelKalender.AutoSize = true;
            labelKalender.Location = new Point(820, 55);
            labelKalender.Name = "labelKalender";
            labelKalender.Size = new Size(80, 25);
            labelKalender.TabIndex = 18;
            labelKalender.Text = "Kalender";
            // 
            // labelTagesTermine
            // 
            labelTagesTermine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTagesTermine.AutoSize = true;
            labelTagesTermine.Location = new Point(820, 365);
            labelTagesTermine.Name = "labelTagesTermine";
            labelTagesTermine.Size = new Size(248, 25);
            labelTagesTermine.TabIndex = 19;
            labelTagesTermine.Text = "Termine am ausgewählten Tag";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 95);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(290, 31);
            textBoxName.TabIndex = 2;
            // 
            // textBoxFach
            // 
            textBoxFach.Location = new Point(140, 145);
            textBoxFach.Name = "textBoxFach";
            textBoxFach.Size = new Size(290, 31);
            textBoxFach.TabIndex = 4;
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Format = DateTimePickerFormat.Short;
            dateTimePickerDatum.Location = new Point(140, 195);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(290, 31);
            dateTimePickerDatum.TabIndex = 6;
            // 
            // comboBoxArt
            // 
            comboBoxArt.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArt.FormattingEnabled = true;
            comboBoxArt.Items.AddRange(new object[] { "Prüfung", "Hausaufgabe", "Anderer Termin" });
            comboBoxArt.Location = new Point(140, 245);
            comboBoxArt.Name = "comboBoxArt";
            comboBoxArt.Size = new Size(290, 33);
            comboBoxArt.TabIndex = 8;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Alle", "Prüfung", "Hausaufgabe", "Anderer Termin" });
            comboBoxFilter.Location = new Point(140, 298);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(290, 33);
            comboBoxFilter.TabIndex = 10;
            // 
            // buttonHinzufügen
            // 
            buttonHinzufügen.Location = new Point(140, 350);
            buttonHinzufügen.Name = "buttonHinzufügen";
            buttonHinzufügen.Size = new Size(120, 38);
            buttonHinzufügen.TabIndex = 11;
            buttonHinzufügen.Text = "Hinzufügen";
            buttonHinzufügen.Click += buttonHinzufügen_Click;
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(270, 350);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(120, 38);
            buttonBearbeiten.TabIndex = 12;
            buttonBearbeiten.Text = "Ändern";
            buttonBearbeiten.Click += buttonBearbeiten_Click;
            // 
            // buttonLöschen
            // 
            buttonLöschen.Location = new Point(400, 350);
            buttonLöschen.Name = "buttonLöschen";
            buttonLöschen.Size = new Size(120, 38);
            buttonLöschen.TabIndex = 13;
            buttonLöschen.Text = "Löschen";
            buttonLöschen.Click += buttonLöschen_Click;
            // 
            // buttonStatus
            // 
            buttonStatus.Location = new Point(530, 350);
            buttonStatus.Name = "buttonStatus";
            buttonStatus.Size = new Size(120, 38);
            buttonStatus.TabIndex = 14;
            buttonStatus.Text = "Status ändern";
            buttonStatus.Click += buttonStatus_Click;
            // 
            // buttonErinnerungen
            // 
            buttonErinnerungen.Location = new Point(660, 350);
            buttonErinnerungen.Name = "buttonErinnerungen";
            buttonErinnerungen.Size = new Size(130, 38);
            buttonErinnerungen.TabIndex = 15;
            buttonErinnerungen.Text = "Erinnerungen";
            buttonErinnerungen.Click += buttonErinnerungen_Click;
            // 
            // dataGridViewTermine
            // 
            dataGridViewTermine.AllowUserToAddRows = false;
            dataGridViewTermine.AllowUserToDeleteRows = false;
            dataGridViewTermine.AllowUserToResizeColumns = false;
            dataGridViewTermine.AllowUserToResizeRows = false;
            dataGridViewTermine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTermine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTermine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTermine.Columns.AddRange(new DataGridViewColumn[] { spalteName, spalteFach, spalteDatum, spalteArt, spalteStatus, spalteNotiz });
            dataGridViewTermine.Location = new Point(30, 405);
            dataGridViewTermine.MultiSelect = false;
            dataGridViewTermine.Name = "dataGridViewTermine";
            dataGridViewTermine.ReadOnly = true;
            dataGridViewTermine.RowHeadersVisible = false;
            dataGridViewTermine.RowHeadersWidth = 62;
            dataGridViewTermine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTermine.Size = new Size(760, 240);
            dataGridViewTermine.TabIndex = 16;
            // 
            // spalteName
            // 
            spalteName.FillWeight = 24F;
            spalteName.HeaderText = "Name";
            spalteName.MinimumWidth = 8;
            spalteName.Name = "spalteName";
            spalteName.ReadOnly = true;
            spalteName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // spalteFach
            // 
            spalteFach.FillWeight = 18F;
            spalteFach.HeaderText = "Fach";
            spalteFach.MinimumWidth = 8;
            spalteFach.Name = "spalteFach";
            spalteFach.ReadOnly = true;
            spalteFach.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // spalteDatum
            // 
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            spalteDatum.DefaultCellStyle = dataGridViewCellStyle1;
            spalteDatum.FillWeight = 16F;
            spalteDatum.HeaderText = "Datum";
            spalteDatum.MinimumWidth = 8;
            spalteDatum.Name = "spalteDatum";
            spalteDatum.ReadOnly = true;
            spalteDatum.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // spalteArt
            // 
            spalteArt.FillWeight = 22F;
            spalteArt.HeaderText = "Terminart";
            spalteArt.MinimumWidth = 8;
            spalteArt.Name = "spalteArt";
            spalteArt.ReadOnly = true;
            spalteArt.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // spalteStatus
            // 
            spalteStatus.FillWeight = 20F;
            spalteStatus.HeaderText = "Status";
            spalteStatus.MinimumWidth = 8;
            spalteStatus.Name = "spalteStatus";
            spalteStatus.ReadOnly = true;
            spalteStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            spalteNotiz.FillWeight = 25F;
            spalteNotiz.HeaderText = "Notiz";
            spalteNotiz.MinimumWidth = 8;
            spalteNotiz.Name = "spalteNotiz";
            spalteNotiz.ReadOnly = true;
            spalteNotiz.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // monthCalendarTermine
            // 
            monthCalendarTermine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendarTermine.Location = new Point(820, 95);
            monthCalendarTermine.MaxSelectionCount = 1;
            monthCalendarTermine.Name = "monthCalendarTermine";
            monthCalendarTermine.TabIndex = 17;
            // 
            // listBoxTagesTermine
            // 
            listBoxTagesTermine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxTagesTermine.FormattingEnabled = true;
            listBoxTagesTermine.HorizontalScrollbar = true;
            listBoxTagesTermine.IntegralHeight = false;
            listBoxTagesTermine.ItemHeight = 25;
            listBoxTagesTermine.Location = new Point(820, 405);
            listBoxTagesTermine.Name = "listBoxTagesTermine";
            listBoxTagesTermine.Size = new Size(270, 240);
            listBoxTagesTermine.TabIndex = 20;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Alle", "Offen", "Erledigt" });
            comboBoxStatus.Location = new Point(530, 298);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(258, 33);
            comboBoxStatus.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 301);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 22;
            label1.Text = "Status";
            label1.Click += label1_Click;
            labelNotiz.AutoSize = true;
            labelNotiz.Location = new Point(450, 65);
            labelNotiz.Name = "labelNotiz";
            labelNotiz.Size = new Size(52, 25);
            labelNotiz.TabIndex = 23;
            labelNotiz.Text = "Notiz";
            textBoxNotiz.Location = new Point(450, 95);
            textBoxNotiz.Multiline = true;
            textBoxNotiz.Name = "textBoxNotiz";
            textBoxNotiz.ScrollBars = ScrollBars.Vertical;
            textBoxNotiz.Size = new Size(340, 180);
            textBoxNotiz.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(textBoxNotiz);
            Controls.Add(labelNotiz);
            Controls.Add(label1);
            Controls.Add(comboBoxStatus);
            Controls.Add(listBoxTagesTermine);
            Controls.Add(monthCalendarTermine);
            Controls.Add(dataGridViewTermine);
            Controls.Add(buttonErinnerungen);
            Controls.Add(buttonStatus);
            Controls.Add(buttonLöschen);
            Controls.Add(buttonBearbeiten);
            Controls.Add(buttonHinzufügen);
            Controls.Add(comboBoxFilter);
            Controls.Add(comboBoxArt);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(textBoxFach);
            Controls.Add(textBoxName);
            Controls.Add(labelTagesTermine);
            Controls.Add(labelKalender);
            Controls.Add(labelFilter);
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
        private Label labelFilter;
        private Label labelKalender;
        private Label labelTagesTermine;
        private TextBox textBoxName;
        private TextBox textBoxFach;
        private DateTimePicker dateTimePickerDatum;
        private ComboBox comboBoxArt;
        private ComboBox comboBoxFilter;
        private Button buttonHinzufügen;
        private Button buttonBearbeiten;
        private Button buttonLöschen;
        private Button buttonStatus;
        private Button buttonErinnerungen;
        private DataGridView dataGridViewTermine;
        private DataGridViewTextBoxColumn spalteName;
        private DataGridViewTextBoxColumn spalteFach;
        private DataGridViewTextBoxColumn spalteDatum;
        private DataGridViewTextBoxColumn spalteArt;
        private DataGridViewTextBoxColumn spalteStatus;
        private DataGridViewTextBoxColumn spalteNotiz;
        private MonthCalendar monthCalendarTermine;
        private ListBox listBoxTagesTermine;
        private ComboBox comboBoxStatus;
        private Label label1;
        private Label labelNotiz;
        private TextBox textBoxNotiz;
    }
}
