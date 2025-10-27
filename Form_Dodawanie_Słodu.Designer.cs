namespace Projekt_Piwowar
{
    partial class Form_Dodawanie_Słodu
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
            textBox_Waga = new TextBox();
            label2 = new Label();
            button_dodaj = new RoundedButton();
            comboBox_Nazwa_slodu = new ComboBox();
            button_anuluj = new RoundedButton();
            SuspendLayout();
            // 
            // textBox_Waga
            // 
            textBox_Waga.Location = new Point(76, 102);
            textBox_Waga.Name = "textBox_Waga";
            textBox_Waga.Size = new Size(100, 23);
            textBox_Waga.TabIndex = 1;
            textBox_Waga.TextChanged += textBox_Waga_TextChanged;
            textBox_Waga.KeyDown += textBox_Waga_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 23);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwa";
            // 
            // button_dodaj
            // 
            button_dodaj.BackColor = Color.LightGreen;
            button_dodaj.BorderRadius = 15;
            button_dodaj.FlatStyle = FlatStyle.Flat;
            button_dodaj.ForeColor = Color.White;
            button_dodaj.Location = new Point(150, 189);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(89, 32);
            button_dodaj.TabIndex = 2;
            button_dodaj.Text = "➕ Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click_1;
            button_dodaj.KeyDown += button_dodaj_KeyDown;
            // 
            // comboBox_Nazwa_slodu
            // 
            comboBox_Nazwa_slodu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Nazwa_slodu.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Nazwa_slodu.FormattingEnabled = true;
            comboBox_Nazwa_slodu.Location = new Point(76, 56);
            comboBox_Nazwa_slodu.Name = "comboBox_Nazwa_slodu";
            comboBox_Nazwa_slodu.Size = new Size(100, 23);
            comboBox_Nazwa_slodu.TabIndex = 0;
            comboBox_Nazwa_slodu.Enter += comboBox_Nazwa_slodu_Enter;
            comboBox_Nazwa_slodu.KeyDown += comboBox_Nazwa_slodu_KeyDown;
            // 
            // button_anuluj
            // 
            button_anuluj.BackColor = Color.LightGreen;
            button_anuluj.BorderRadius = 15;
            button_anuluj.FlatStyle = FlatStyle.Flat;
            button_anuluj.ForeColor = Color.White;
            button_anuluj.Location = new Point(12, 189);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(86, 32);
            button_anuluj.TabIndex = 3;
            button_anuluj.Text = "❌ Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            button_anuluj.KeyDown += button_anuluj_KeyDown;
            // 
            // Form_Dodawanie_Słodu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 233);
            Controls.Add(button_anuluj);
            Controls.Add(comboBox_Nazwa_slodu);
            Controls.Add(button_dodaj);
            Controls.Add(label2);
            Controls.Add(textBox_Waga);
            Name = "Form_Dodawanie_Słodu";
            Text = "Dodawanie Słodu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Waga;
        private Label label2;
        private RoundedButton button_dodaj;
        private ComboBox comboBox_Nazwa_slodu;
        private RoundedButton button_anuluj;
    }
}