namespace Projekt_Piwowar
{
    partial class Form_Dodawanie_Chmielu
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
            comboBox1 = new ComboBox();
            button_dodaj = new RoundedButton();
            textBox_Waga = new TextBox();
            textBox_Czas = new TextBox();
            button_anuluj = new RoundedButton();
            comboBox_rodzajchmielenia = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Nazwa Chmielu";
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // button_dodaj
            // 
            button_dodaj.BackColor = Color.LightGreen;
            button_dodaj.BorderRadius = 15;
            button_dodaj.FlatStyle = FlatStyle.Flat;
            button_dodaj.ForeColor = Color.White;
            button_dodaj.Location = new Point(201, 261);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(87, 33);
            button_dodaj.TabIndex = 4;
            button_dodaj.Text = "➕ Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            button_dodaj.KeyDown += button_dodaj_KeyDown;
            // 
            // textBox_Waga
            // 
            textBox_Waga.Location = new Point(94, 122);
            textBox_Waga.Name = "textBox_Waga";
            textBox_Waga.Size = new Size(100, 23);
            textBox_Waga.TabIndex = 2;
            textBox_Waga.TextChanged += textBox_Waga_TextChanged;
            textBox_Waga.KeyDown += textBox_Waga_KeyDown;
            // 
            // textBox_Czas
            // 
            textBox_Czas.Location = new Point(94, 175);
            textBox_Czas.Name = "textBox_Czas";
            textBox_Czas.Size = new Size(100, 23);
            textBox_Czas.TabIndex = 3;
            textBox_Czas.TextChanged += textBox_Czas_TextChanged;
            textBox_Czas.KeyDown += textBox_Czas_KeyDown;
            // 
            // button_anuluj
            // 
            button_anuluj.BackColor = Color.LightGreen;
            button_anuluj.BorderRadius = 15;
            button_anuluj.FlatStyle = FlatStyle.Flat;
            button_anuluj.ForeColor = Color.White;
            button_anuluj.Location = new Point(12, 261);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(86, 33);
            button_anuluj.TabIndex = 5;
            button_anuluj.Text = "❌ Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // comboBox_rodzajchmielenia
            // 
            comboBox_rodzajchmielenia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_rodzajchmielenia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_rodzajchmielenia.FormattingEnabled = true;
            comboBox_rodzajchmielenia.Items.AddRange(new object[] { "Gotowanie", "ChmielNaZimno", "HopStand" });
            comboBox_rodzajchmielenia.Location = new Point(85, 80);
            comboBox_rodzajchmielenia.Name = "comboBox_rodzajchmielenia";
            comboBox_rodzajchmielenia.Size = new Size(121, 23);
            comboBox_rodzajchmielenia.TabIndex = 1;
            comboBox_rodzajchmielenia.Text = "Rodzaj Chmielenia";
            comboBox_rodzajchmielenia.Enter += comboBox_rodzajchmielenia_Enter;
            comboBox_rodzajchmielenia.KeyDown += comboBox1_KeyDown;
            // 
            // Form_Dodawanie_Chmielu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 306);
            Controls.Add(comboBox_rodzajchmielenia);
            Controls.Add(button_anuluj);
            Controls.Add(textBox_Czas);
            Controls.Add(textBox_Waga);
            Controls.Add(button_dodaj);
            Controls.Add(comboBox1);
            Name = "Form_Dodawanie_Chmielu";
            Text = "Dodawanie Chmielu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private RoundedButton button_dodaj;
        private TextBox textBox_Waga;
        private TextBox textBox_Czas;
        private RoundedButton button_anuluj;
        private ComboBox comboBox_rodzajchmielenia;
    }
}