namespace Projekt_Piwowar
{
    partial class Edycja_Magazyn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Anuluj_przycisk = new RoundedButton();
            Zapisz_przycisk = new RoundedButton();
            label_nazwa = new Label();
            textBox_waga = new TextBox();
            textBox_cena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_usun = new RoundedButton();
            SuspendLayout();
            // 
            // Anuluj_przycisk
            // 
            Anuluj_przycisk.BackColor = Color.LightGreen;
            Anuluj_przycisk.BorderRadius = 15;
            Anuluj_przycisk.FlatStyle = FlatStyle.Flat;
            Anuluj_przycisk.ForeColor = Color.White;
            Anuluj_przycisk.Location = new Point(12, 415);
            Anuluj_przycisk.Name = "Anuluj_przycisk";
            Anuluj_przycisk.Size = new Size(87, 32);
            Anuluj_przycisk.TabIndex = 0;
            Anuluj_przycisk.Text = "⮌ Anuluj";
            Anuluj_przycisk.UseVisualStyleBackColor = true;
            Anuluj_przycisk.Click += Anuluj_przycisk_Click;
            // 
            // Zapisz_przycisk
            // 
            Zapisz_przycisk.BackColor = Color.LightGreen;
            Zapisz_przycisk.BorderRadius = 15;
            Zapisz_przycisk.FlatStyle = FlatStyle.Flat;
            Zapisz_przycisk.ForeColor = Color.White;
            Zapisz_przycisk.Location = new Point(366, 415);
            Zapisz_przycisk.Name = "Zapisz_przycisk";
            Zapisz_przycisk.Size = new Size(89, 32);
            Zapisz_przycisk.TabIndex = 1;
            Zapisz_przycisk.Text = "💾 Zapisz";
            Zapisz_przycisk.UseVisualStyleBackColor = true;
            Zapisz_przycisk.Click += Zapisz_przycisk_Click;
            // 
            // label_nazwa
            // 
            label_nazwa.AutoSize = true;
            label_nazwa.Location = new Point(160, 105);
            label_nazwa.Name = "label_nazwa";
            label_nazwa.Size = new Size(150, 15);
            label_nazwa.TabIndex = 2;
            label_nazwa.Text = "Nazwa Edytowanego Slodu";
            // 
            // textBox_waga
            // 
            textBox_waga.Location = new Point(194, 177);
            textBox_waga.Name = "textBox_waga";
            textBox_waga.Size = new Size(100, 23);
            textBox_waga.TabIndex = 3;
            // 
            // textBox_cena
            // 
            textBox_cena.Location = new Point(194, 239);
            textBox_cena.Name = "textBox_cena";
            textBox_cena.Size = new Size(100, 23);
            textBox_cena.TabIndex = 4;
            textBox_cena.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 185);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Waga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 247);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Cena za 1kg/1g";
            // 
            // button_usun
            // 
            button_usun.BackColor = Color.LightGreen;
            button_usun.BorderRadius = 15;
            button_usun.FlatStyle = FlatStyle.Flat;
            button_usun.ForeColor = Color.White;
            button_usun.Location = new Point(277, 415);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(83, 32);
            button_usun.TabIndex = 7;
            button_usun.Text = "❌ Usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // Edycja_Magazyn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 459);
            Controls.Add(button_usun);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_cena);
            Controls.Add(textBox_waga);
            Controls.Add(label_nazwa);
            Controls.Add(Zapisz_przycisk);
            Controls.Add(Anuluj_przycisk);
            Name = "Edycja_Magazyn";
            Text = "Edycja Slodu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton Anuluj_przycisk;
        private RoundedButton Zapisz_przycisk;
        private Label label_nazwa;
        private TextBox textBox_waga;
        private TextBox textBox_cena;
        private Label label1;
        private Label label2;
        private RoundedButton button_usun;
    }
}