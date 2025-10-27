namespace Projekt_Piwowar
{
    partial class Moje_Receptury
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
            dataGridView1 = new DataGridView();
            Kolor = new DataGridViewImageColumn();
            Nazwa = new DataGridViewTextBoxColumn();
            Styl = new DataGridViewTextBoxColumn();
            ABV = new DataGridViewTextBoxColumn();
            BLG = new DataGridViewTextBoxColumn();
            button_anuluj = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kolor, Nazwa, Styl, ABV, BLG });
            dataGridView1.Location = new Point(120, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(515, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Kolor
            // 
            Kolor.HeaderText = "Kolor";
            Kolor.Name = "Kolor";
            Kolor.Resizable = DataGridViewTriState.True;
            Kolor.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nazwa
            // 
            Nazwa.HeaderText = "Nazwa";
            Nazwa.Name = "Nazwa";
            // 
            // Styl
            // 
            Styl.HeaderText = "Styl";
            Styl.Name = "Styl";
            // 
            // ABV
            // 
            ABV.HeaderText = "ABV";
            ABV.Name = "ABV";
            // 
            // BLG
            // 
            BLG.HeaderText = "BLG";
            BLG.Name = "BLG";
            // 
            // button_anuluj
            // 
            button_anuluj.BackColor = Color.LightGreen;
            button_anuluj.BorderRadius = 15;
            button_anuluj.FlatStyle = FlatStyle.Flat;
            button_anuluj.Font = new Font("Segoe UI", 11F);
            button_anuluj.ForeColor = Color.White;
            button_anuluj.Location = new Point(12, 473);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(90, 35);
            button_anuluj.TabIndex = 13;
            button_anuluj.Text = "❌ Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button1_Click;
            // 
            // Moje_Receptury
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 520);
            Controls.Add(button_anuluj);
            Controls.Add(dataGridView1);
            Name = "Moje_Receptury";
            Text = "Moje_Receptury";
            FormClosed += Moje_Receptury_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewImageColumn Kolor;
        private DataGridViewTextBoxColumn Nazwa;
        private DataGridViewTextBoxColumn Styl;
        private DataGridViewTextBoxColumn ABV;
        private DataGridViewTextBoxColumn BLG;
        private RoundedButton button_anuluj;
    }
}