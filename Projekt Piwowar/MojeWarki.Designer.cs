namespace Projekt_Piwowar
{
    partial class MojeWarki
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            numer = new DataGridViewTextBoxColumn();
            Kolor = new DataGridViewImageColumn();
            Nazwa = new DataGridViewTextBoxColumn();
            Styl = new DataGridViewTextBoxColumn();
            ABV = new DataGridViewTextBoxColumn();
            BLG = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            button1 = new RoundedButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usunPozycjeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numer, Kolor, Nazwa, Styl, ABV, BLG, Dni });
            dataGridView1.Location = new Point(206, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(481, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseClick;
            // 
            // numer
            // 
            numer.HeaderText = "Numer";
            numer.Name = "numer";
            numer.ReadOnly = true;
            // 
            // Kolor
            // 
            Kolor.HeaderText = "Kolor";
            Kolor.Name = "Kolor";
            Kolor.ReadOnly = true;
            // 
            // Nazwa
            // 
            Nazwa.HeaderText = "Nazwa";
            Nazwa.Name = "Nazwa";
            Nazwa.ReadOnly = true;
            // 
            // Styl
            // 
            Styl.HeaderText = "Styl";
            Styl.Name = "Styl";
            Styl.ReadOnly = true;
            // 
            // ABV
            // 
            ABV.HeaderText = "ABV";
            ABV.Name = "ABV";
            ABV.ReadOnly = true;
            // 
            // BLG
            // 
            BLG.HeaderText = "BLG";
            BLG.Name = "BLG";
            BLG.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.BorderRadius = 15;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 467);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 1;
            button1.Text = "⮌ Wróć";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { usunPozycjeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 26);
            // 
            // usunPozycjeToolStripMenuItem
            // 
            usunPozycjeToolStripMenuItem.Name = "usunPozycjeToolStripMenuItem";
            usunPozycjeToolStripMenuItem.Size = new Size(144, 22);
            usunPozycjeToolStripMenuItem.Text = "Usun pozycje";
            usunPozycjeToolStripMenuItem.Click += usunPozycjeToolStripMenuItem_Click;
            // 
            // MojeWarki
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 514);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "MojeWarki";
            Text = "MojeWarki";
            FormClosed += MojeWarki_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numer;
        private DataGridViewImageColumn Kolor;
        private DataGridViewTextBoxColumn Nazwa;
        private DataGridViewTextBoxColumn Styl;
        private DataGridViewTextBoxColumn ABV;
        private DataGridViewTextBoxColumn BLG;
        private RoundedButton button1;
        private DataGridViewTextBoxColumn Dni;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usunPozycjeToolStripMenuItem;
    }
}