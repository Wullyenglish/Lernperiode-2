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
            textBoxDatum = new TextBox();
            SuspendLayout();
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitel.Location = new Point(30, 25);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(192, 45);
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
            textBoxName.Size = new Size(240, 31);
            textBoxName.TabIndex = 2;
            // 
            // textBoxFach
            // 
            textBoxFach.Location = new Point(130, 157);
            textBoxFach.Name = "textBoxFach";
            textBoxFach.Size = new Size(240, 31);
            textBoxFach.TabIndex = 4;
            // 
            // textBoxDatum
            // 
            textBoxDatum.Location = new Point(130, 217);
            textBoxDatum.Name = "textBoxDatum";
            textBoxDatum.PlaceholderText = "TT.MM.JJJJ";
            textBoxDatum.Size = new Size(240, 31);
            textBoxDatum.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDatum);
            Controls.Add(textBoxFach);
            Controls.Add(textBoxName);
            Controls.Add(labelDatum);
            Controls.Add(labelFach);
            Controls.Add(labelName);
            Controls.Add(labelTitel);
            Name = "Form1";
            Text = "Schulplaner";
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
        private TextBox textBoxDatum;
    }
}
