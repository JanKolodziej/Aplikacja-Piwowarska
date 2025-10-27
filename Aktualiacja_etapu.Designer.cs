namespace Projekt_Piwowar
{
    partial class Aktualiacja_etapu
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
            button_Tak = new RoundedButton();
            button_Nie = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 115);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Tak
            // 
            button_Tak.Location = new Point(295, 321);
            button_Tak.Name = "button_Tak";
            button_Tak.Size = new Size(82, 37);
            button_Tak.TabIndex = 1;
            button_Tak.Text = "Tak";
            button_Tak.UseVisualStyleBackColor = true;
            button_Tak.Click += button1_Click;
            // 
            // button_Nie
            // 
            button_Nie.Location = new Point(12, 321);
            button_Nie.Name = "button_Nie";
            button_Nie.Size = new Size(82, 37);
            button_Nie.TabIndex = 2;
            button_Nie.Text = "Nie";
            button_Nie.UseVisualStyleBackColor = true;
            button_Nie.Click += button_Nie_Click;
            // 
            // Aktualiacja_etapu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 370);
            Controls.Add(button_Nie);
            Controls.Add(button_Tak);
            Controls.Add(label1);
            Name = "Aktualiacja_etapu";
            Text = "Aktualiacja_etapu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedButton button_Tak;
        private RoundedButton button_Nie;
    }
}