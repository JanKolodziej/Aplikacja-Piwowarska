namespace Projekt_Piwowar
{
    partial class Potwierdzenie_Usuniecia
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
            label1 = new Label();
            button_usun = new RoundedButton();
            button_anuluj = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 96);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 0;
            label1.Text = "Czy na pewno chcesz to usunąć?";
            // 
            // button_usun
            // 
            button_usun.Location = new Point(213, 207);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(83, 31);
            button_usun.TabIndex = 1;
            button_usun.Text = "Usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(12, 207);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(83, 31);
            button_anuluj.TabIndex = 2;
            button_anuluj.Text = "Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // Potwierdzenie_Usuniecia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 250);
            Controls.Add(button_anuluj);
            Controls.Add(button_usun);
            Controls.Add(label1);
            Name = "Potwierdzenie_Usuniecia";
            Text = "Potwierdzenie_Usuniecia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedButton button_usun;
        private RoundedButton button_anuluj;
    }
}