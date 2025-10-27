namespace Projekt_Piwowar
{
    partial class KonfiguracjaStrat
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
            button_anuluj = new RoundedButton();
            button_Zapisz = new RoundedButton();
            label2 = new Label();
            textBox_stratychlodzenia = new TextBox();
            label3 = new Label();
            textBox_stratyfermentator = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_anuluj
            // 
            button_anuluj.BackColor = Color.LightGreen;
            button_anuluj.BorderRadius = 15;
            button_anuluj.FlatStyle = FlatStyle.Flat;
            button_anuluj.Font = new Font("Segoe UI", 11F);
            button_anuluj.ForeColor = Color.White;
            button_anuluj.Location = new Point(12, 407);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(90, 35);
            button_anuluj.TabIndex = 13;
            button_anuluj.Text = "❌ Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // button_Zapisz
            // 
            button_Zapisz.BackColor = Color.LightGreen;
            button_Zapisz.BorderRadius = 15;
            button_Zapisz.FlatStyle = FlatStyle.Flat;
            button_Zapisz.ForeColor = Color.White;
            button_Zapisz.Location = new Point(454, 407);
            button_Zapisz.Name = "button_Zapisz";
            button_Zapisz.Size = new Size(90, 35);
            button_Zapisz.TabIndex = 14;
            button_Zapisz.Text = "💾 Zapisz";
            button_Zapisz.UseVisualStyleBackColor = true;
            button_Zapisz.Click += button_Zapisz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 269);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 17;
            label2.Text = "Straty z chłodzenia";
            // 
            // textBox_stratychlodzenia
            // 
            textBox_stratychlodzenia.Location = new Point(225, 269);
            textBox_stratychlodzenia.Name = "textBox_stratychlodzenia";
            textBox_stratychlodzenia.Size = new Size(89, 23);
            textBox_stratychlodzenia.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 309);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 19;
            label3.Text = "Straty w fermentatorze";
            // 
            // textBox_stratyfermentator
            // 
            textBox_stratyfermentator.Location = new Point(225, 306);
            textBox_stratyfermentator.Name = "textBox_stratyfermentator";
            textBox_stratyfermentator.Size = new Size(89, 23);
            textBox_stratyfermentator.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.Location = new Point(25, 202);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 21;
            label1.Text = "Straty po gotowaniu";
            // 
            // KonfiguracjaStrat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 454);
            Controls.Add(label1);
            Controls.Add(textBox_stratyfermentator);
            Controls.Add(label3);
            Controls.Add(textBox_stratychlodzenia);
            Controls.Add(label2);
            Controls.Add(button_Zapisz);
            Controls.Add(button_anuluj);
            Name = "KonfiguracjaStrat";
            Text = "KonfiguracjaStrat";
            FormClosed += KonfiguracjaStrat_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton button_anuluj;
        private RoundedButton button_Zapisz;
        private Label label2;
        private TextBox textBox_stratychlodzenia;
        private Label label3;
        private TextBox textBox_stratyfermentator;
        private Label label1;
    }
}