namespace Projekt_Piwowar
{
    partial class Form_Magazyn
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
            Tabela_Slodu = new DataGridView();
            Ikona = new DataGridViewImageColumn();
            Nazwa = new DataGridViewTextBoxColumn();
            Waga = new DataGridViewTextBoxColumn();
            Cena = new DataGridViewTextBoxColumn();
            comboBox_Nazwa_slodu = new ComboBox();
            textBox_Waga = new TextBox();
            textBox_Cena = new TextBox();
            comboBox_Produkt = new ComboBox();
            button_Dodaj = new RoundedButton();
            button_Zapisz = new RoundedButton();
            menuStrip1 = new MenuStrip();
            recepturyToolStripMenuItem = new ToolStripMenuItem();
            twojeRecepturyToolStripMenuItem = new ToolStripMenuItem();
            dodajReceptureToolStripMenuItem = new ToolStripMenuItem();
            twojeWarkiToolStripMenuItem = new ToolStripMenuItem();
            magazynToolStripMenuItem = new ToolStripMenuItem();
            konfiguaracjaStratToolStripMenuItem = new ToolStripMenuItem();
            tabela_chmielu = new DataGridView();
            Ikona_chmiel = new DataGridViewImageColumn();
            Nazwa1 = new DataGridViewTextBoxColumn();
            Waga1 = new DataGridViewTextBoxColumn();
            Cena1 = new DataGridViewTextBoxColumn();
            Tabela_drozdzy = new DataGridView();
            Ikona_drozdze = new DataGridViewImageColumn();
            Nazwa2 = new DataGridViewTextBoxColumn();
            Waga2 = new DataGridViewTextBoxColumn();
            Cena2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Tabela_Slodu).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabela_chmielu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tabela_drozdzy).BeginInit();
            SuspendLayout();
            // 
            // Tabela_Slodu
            // 
            Tabela_Slodu.AllowUserToAddRows = false;
            Tabela_Slodu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabela_Slodu.BackgroundColor = Color.FromArgb(255, 255, 192);
            Tabela_Slodu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela_Slodu.Columns.AddRange(new DataGridViewColumn[] { Ikona, Nazwa, Waga, Cena });
            Tabela_Slodu.GridColor = Color.Black;
            Tabela_Slodu.Location = new Point(280, 30);
            Tabela_Slodu.Name = "Tabela_Slodu";
            Tabela_Slodu.RowHeadersVisible = false;
            Tabela_Slodu.Size = new Size(342, 151);
            Tabela_Slodu.TabIndex = 6;
            Tabela_Slodu.CellDoubleClick += Tabela_Slodu_CellDoubleClick;
            // 
            // Ikona
            // 
            Ikona.FillWeight = 50F;
            Ikona.HeaderText = "";
            Ikona.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona.Name = "Ikona";
            // 
            // Nazwa
            // 
            Nazwa.HeaderText = "Nazwa";
            Nazwa.Name = "Nazwa";
            // 
            // Waga
            // 
            Waga.HeaderText = "Waga";
            Waga.Name = "Waga";
            // 
            // Cena
            // 
            Cena.HeaderText = "Cena";
            Cena.Name = "Cena";
            // 
            // comboBox_Nazwa_slodu
            // 
            comboBox_Nazwa_slodu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Nazwa_slodu.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Nazwa_slodu.Enabled = false;
            comboBox_Nazwa_slodu.FormattingEnabled = true;
            comboBox_Nazwa_slodu.Location = new Point(56, 116);
            comboBox_Nazwa_slodu.Name = "comboBox_Nazwa_slodu";
            comboBox_Nazwa_slodu.Size = new Size(121, 23);
            comboBox_Nazwa_slodu.TabIndex = 1;
            comboBox_Nazwa_slodu.Enter += comboBox_Nazwa_slodu_Enter;
            comboBox_Nazwa_slodu.KeyDown += comboBox_Produkt_KeyDown;
            // 
            // textBox_Waga
            // 
            textBox_Waga.Location = new Point(56, 158);
            textBox_Waga.Name = "textBox_Waga";
            textBox_Waga.Size = new Size(121, 23);
            textBox_Waga.TabIndex = 2;
            textBox_Waga.TextChanged += textBox_Waga_TextChanged;
            textBox_Waga.KeyDown += textBox_Waga_KeyDown;
            // 
            // textBox_Cena
            // 
            textBox_Cena.Location = new Point(56, 201);
            textBox_Cena.Name = "textBox_Cena";
            textBox_Cena.Size = new Size(121, 23);
            textBox_Cena.TabIndex = 3;
            textBox_Cena.TextChanged += textBox_Cena_TextChanged;
            textBox_Cena.KeyDown += textBox_Cena_KeyDown;
            // 
            // comboBox_Produkt
            // 
            comboBox_Produkt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Produkt.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Produkt.FormattingEnabled = true;
            comboBox_Produkt.Items.AddRange(new object[] { "Surowce Fermentujące", "Chmiele", "Drożdże", "Dodatki" });
            comboBox_Produkt.Location = new Point(56, 68);
            comboBox_Produkt.Name = "comboBox_Produkt";
            comboBox_Produkt.Size = new Size(121, 23);
            comboBox_Produkt.TabIndex = 0;
            comboBox_Produkt.Text = "Produkt";
            comboBox_Produkt.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox_Produkt.KeyDown += comboBox_Produkt_KeyDown;
            // 
            // button_Dodaj
            // 
            button_Dodaj.BackColor = Color.LightGreen;
            button_Dodaj.BorderRadius = 15;
            button_Dodaj.Enabled = false;
            button_Dodaj.FlatStyle = FlatStyle.Flat;
            button_Dodaj.ForeColor = Color.White;
            button_Dodaj.Location = new Point(68, 267);
            button_Dodaj.Name = "button_Dodaj";
            button_Dodaj.Size = new Size(90, 35);
            button_Dodaj.TabIndex = 4;
            button_Dodaj.Text = "Dodaj";
            button_Dodaj.UseVisualStyleBackColor = true;
            button_Dodaj.Click += button_Dodaj_Click;
            button_Dodaj.KeyDown += button_Dodaj_KeyDown;
            // 
            // button_Zapisz
            // 
            button_Zapisz.BackColor = Color.LightGreen;
            button_Zapisz.BorderRadius = 15;
            button_Zapisz.FlatStyle = FlatStyle.Flat;
            button_Zapisz.ForeColor = Color.White;
            button_Zapisz.Location = new Point(68, 308);
            button_Zapisz.Name = "button_Zapisz";
            button_Zapisz.Size = new Size(90, 35);
            button_Zapisz.TabIndex = 5;
            button_Zapisz.Text = "Zapisz";
            button_Zapisz.UseVisualStyleBackColor = true;
            button_Zapisz.Click += button_Zapisz_Click;
            button_Zapisz.KeyDown += button_Zapisz_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { recepturyToolStripMenuItem, magazynToolStripMenuItem, konfiguaracjaStratToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // recepturyToolStripMenuItem
            // 
            recepturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { twojeRecepturyToolStripMenuItem, dodajReceptureToolStripMenuItem, twojeWarkiToolStripMenuItem });
            recepturyToolStripMenuItem.Name = "recepturyToolStripMenuItem";
            recepturyToolStripMenuItem.Size = new Size(72, 20);
            recepturyToolStripMenuItem.Text = "Receptury";
            // 
            // twojeRecepturyToolStripMenuItem
            // 
            twojeRecepturyToolStripMenuItem.Name = "twojeRecepturyToolStripMenuItem";
            twojeRecepturyToolStripMenuItem.Size = new Size(161, 22);
            twojeRecepturyToolStripMenuItem.Text = "Twoje Receptury";
            twojeRecepturyToolStripMenuItem.Click += twojeRecepturyToolStripMenuItem_Click;
            // 
            // dodajReceptureToolStripMenuItem
            // 
            dodajReceptureToolStripMenuItem.Name = "dodajReceptureToolStripMenuItem";
            dodajReceptureToolStripMenuItem.Size = new Size(161, 22);
            dodajReceptureToolStripMenuItem.Text = "Dodaj Recepture";
            dodajReceptureToolStripMenuItem.Click += dodajReceptureToolStripMenuItem_Click;
            // 
            // twojeWarkiToolStripMenuItem
            // 
            twojeWarkiToolStripMenuItem.Name = "twojeWarkiToolStripMenuItem";
            twojeWarkiToolStripMenuItem.Size = new Size(161, 22);
            twojeWarkiToolStripMenuItem.Text = "Twoje Warki";
            twojeWarkiToolStripMenuItem.Click += twojeWarkiToolStripMenuItem_Click;
            // 
            // magazynToolStripMenuItem
            // 
            magazynToolStripMenuItem.Name = "magazynToolStripMenuItem";
            magazynToolStripMenuItem.Size = new Size(67, 20);
            magazynToolStripMenuItem.Text = "Magazyn";
            // 
            // konfiguaracjaStratToolStripMenuItem
            // 
            konfiguaracjaStratToolStripMenuItem.Name = "konfiguaracjaStratToolStripMenuItem";
            konfiguaracjaStratToolStripMenuItem.Size = new Size(118, 20);
            konfiguaracjaStratToolStripMenuItem.Text = "Konfiguaracja strat";
            konfiguaracjaStratToolStripMenuItem.Click += konfiguaracjaStratToolStripMenuItem_Click;
            // 
            // tabela_chmielu
            // 
            tabela_chmielu.AllowUserToAddRows = false;
            tabela_chmielu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela_chmielu.BackgroundColor = Color.FromArgb(192, 255, 192);
            tabela_chmielu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_chmielu.Columns.AddRange(new DataGridViewColumn[] { Ikona_chmiel, Nazwa1, Waga1, Cena1 });
            tabela_chmielu.Location = new Point(280, 218);
            tabela_chmielu.Name = "tabela_chmielu";
            tabela_chmielu.RowHeadersVisible = false;
            tabela_chmielu.Size = new Size(342, 164);
            tabela_chmielu.TabIndex = 7;
            tabela_chmielu.CellDoubleClick += tabela_chmielu_CellDoubleClick;
            // 
            // Ikona_chmiel
            // 
            Ikona_chmiel.FillWeight = 50F;
            Ikona_chmiel.HeaderText = "";
            Ikona_chmiel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona_chmiel.Name = "Ikona_chmiel";
            Ikona_chmiel.Resizable = DataGridViewTriState.True;
            Ikona_chmiel.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nazwa1
            // 
            Nazwa1.FillWeight = 88.24027F;
            Nazwa1.HeaderText = "Nazwa";
            Nazwa1.Name = "Nazwa1";
            // 
            // Waga1
            // 
            Waga1.FillWeight = 88.24027F;
            Waga1.HeaderText = "Waga";
            Waga1.Name = "Waga1";
            // 
            // Cena1
            // 
            Cena1.FillWeight = 88.24027F;
            Cena1.HeaderText = "Cena";
            Cena1.Name = "Cena1";
            // 
            // Tabela_drozdzy
            // 
            Tabela_drozdzy.AllowUserToAddRows = false;
            Tabela_drozdzy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabela_drozdzy.BackgroundColor = Color.FromArgb(255, 192, 192);
            Tabela_drozdzy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela_drozdzy.Columns.AddRange(new DataGridViewColumn[] { Ikona_drozdze, Nazwa2, Waga2, Cena2 });
            Tabela_drozdzy.Location = new Point(280, 399);
            Tabela_drozdzy.Name = "Tabela_drozdzy";
            Tabela_drozdzy.RowHeadersVisible = false;
            Tabela_drozdzy.Size = new Size(342, 96);
            Tabela_drozdzy.TabIndex = 8;
            Tabela_drozdzy.CellDoubleClick += Tabela_drozdzy_CellDoubleClick;
            // 
            // Ikona_drozdze
            // 
            Ikona_drozdze.FillWeight = 50F;
            Ikona_drozdze.HeaderText = "";
            Ikona_drozdze.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona_drozdze.Name = "Ikona_drozdze";
            // 
            // Nazwa2
            // 
            Nazwa2.HeaderText = "Nazwa";
            Nazwa2.Name = "Nazwa2";
            // 
            // Waga2
            // 
            Waga2.HeaderText = "Waga";
            Waga2.Name = "Waga2";
            // 
            // Cena2
            // 
            Cena2.HeaderText = "Cena";
            Cena2.Name = "Cena2";
            // 
            // Form_Magazyn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 507);
            Controls.Add(Tabela_drozdzy);
            Controls.Add(tabela_chmielu);
            Controls.Add(button_Zapisz);
            Controls.Add(button_Dodaj);
            Controls.Add(comboBox_Produkt);
            Controls.Add(textBox_Cena);
            Controls.Add(textBox_Waga);
            Controls.Add(comboBox_Nazwa_slodu);
            Controls.Add(Tabela_Slodu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Magazyn";
            Text = "Magazyn";
            ((System.ComponentModel.ISupportInitialize)Tabela_Slodu).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabela_chmielu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tabela_drozdzy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabela_Slodu;
        private ComboBox comboBox_Nazwa_slodu;
        private TextBox textBox_Waga;
        private TextBox textBox_Cena;
        private ComboBox comboBox_Produkt;
        private RoundedButton button_Dodaj;
        private RoundedButton button_Zapisz;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recepturyToolStripMenuItem;
        private ToolStripMenuItem twojeRecepturyToolStripMenuItem;
        private ToolStripMenuItem dodajReceptureToolStripMenuItem;
        private ToolStripMenuItem magazynToolStripMenuItem;
        private DataGridView tabela_chmielu;
        private DataGridView Tabela_drozdzy;
        private ToolStripMenuItem twojeWarkiToolStripMenuItem;
        private DataGridViewImageColumn Ikona;
        private DataGridViewTextBoxColumn Nazwa;
        private DataGridViewTextBoxColumn Waga;
        private DataGridViewTextBoxColumn Cena;
        private DataGridViewImageColumn Ikona_chmiel;
        private DataGridViewTextBoxColumn Nazwa1;
        private DataGridViewTextBoxColumn Waga1;
        private DataGridViewTextBoxColumn Cena1;
        private DataGridViewImageColumn Ikona_drozdze;
        private DataGridViewTextBoxColumn Nazwa2;
        private DataGridViewTextBoxColumn Waga2;
        private DataGridViewTextBoxColumn Cena2;
        private ToolStripMenuItem konfiguaracjaStratToolStripMenuItem;
    }
}
