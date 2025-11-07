namespace Projekt_Piwowar
{
    partial class Form_Dodaj_Recepture
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
            textBox_Nazwa_Receptury = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Ikona_slod = new DataGridViewImageColumn();
            Nazwa_slod = new DataGridViewTextBoxColumn();
            Waga = new DataGridViewTextBoxColumn();
            Procent = new DataGridViewTextBoxColumn();
            button_Dodaj_Slod = new Button();
            label_3 = new Label();
            label_BLG = new Label();
            label3 = new Label();
            label_EBC = new Label();
            button_zapisz = new RoundedButton();
            label4 = new Label();
            button_Dodaj_chmiel = new Button();
            dataGridView2 = new DataGridView();
            Ikona_chmiel = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Czas = new DataGridViewTextBoxColumn();
            Ibu_ = new DataGridViewTextBoxColumn();
            Etap = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label_IBU = new Label();
            textBox_Obj = new TextBox();
            label7 = new Label();
            comboBox_Drozdze = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label_ABV = new Label();
            button1 = new RoundedButton();
            label10 = new Label();
            label_FG = new Label();
            button_Uwarz = new RoundedButton();
            comboBox_styl = new ComboBox();
            groupBox1 = new GroupBox();
            label15 = new Label();
            pasekStylu_FG = new PasekStylu();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            pasekStylu_IBU = new PasekStylu();
            pasekStylu_EBC = new PasekStylu();
            pasekStylu_BLG = new PasekStylu();
            pasekStylu_ABV = new PasekStylu();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa";
            // 
            // textBox_Nazwa_Receptury
            // 
            textBox_Nazwa_Receptury.Location = new Point(39, 65);
            textBox_Nazwa_Receptury.Name = "textBox_Nazwa_Receptury";
            textBox_Nazwa_Receptury.Size = new Size(106, 23);
            textBox_Nazwa_Receptury.TabIndex = 1;
            textBox_Nazwa_Receptury.TextChanged += textBox_Nazwa_Receptury_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 134);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Surowce Fermentujące";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(645, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ikona_slod, Nazwa_slod, Waga, Procent });
            dataGridView1.Location = new Point(12, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(340, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Ikona_slod
            // 
            Ikona_slod.FillWeight = 60.9137039F;
            Ikona_slod.HeaderText = "";
            Ikona_slod.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona_slod.Name = "Ikona_slod";
            // 
            // Nazwa_slod
            // 
            Nazwa_slod.FillWeight = 113.028755F;
            Nazwa_slod.HeaderText = "Nazwa";
            Nazwa_slod.Name = "Nazwa_slod";
            // 
            // Waga
            // 
            Waga.FillWeight = 113.028755F;
            Waga.HeaderText = "Waga";
            Waga.Name = "Waga";
            // 
            // Procent
            // 
            Procent.FillWeight = 113.028755F;
            Procent.HeaderText = "%";
            Procent.Name = "Procent";
            // 
            // button_Dodaj_Slod
            // 
            button_Dodaj_Slod.Location = new Point(181, 130);
            button_Dodaj_Slod.Name = "button_Dodaj_Slod";
            button_Dodaj_Slod.Size = new Size(75, 23);
            button_Dodaj_Slod.TabIndex = 5;
            button_Dodaj_Slod.Text = "Dodaj";
            button_Dodaj_Slod.UseVisualStyleBackColor = true;
            button_Dodaj_Slod.Click += button_Dodaj_Slod_Click;
            // 
            // label_3
            // 
            label_3.AutoSize = true;
            label_3.Location = new Point(342, 31);
            label_3.Name = "label_3";
            label_3.Size = new Size(28, 15);
            label_3.TabIndex = 6;
            label_3.Text = "BLG";
            // 
            // label_BLG
            // 
            label_BLG.AutoSize = true;
            label_BLG.Location = new Point(415, 32);
            label_BLG.Name = "label_BLG";
            label_BLG.Size = new Size(13, 15);
            label_BLG.TabIndex = 7;
            label_BLG.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 73);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "EBC";
            // 
            // label_EBC
            // 
            label_EBC.AutoSize = true;
            label_EBC.Location = new Point(415, 73);
            label_EBC.Name = "label_EBC";
            label_EBC.Size = new Size(13, 15);
            label_EBC.TabIndex = 9;
            label_EBC.Text = "0";
            // 
            // button_zapisz
            // 
            button_zapisz.BackColor = Color.LightGreen;
            button_zapisz.BorderRadius = 15;
            button_zapisz.FlatStyle = FlatStyle.Flat;
            button_zapisz.ForeColor = Color.White;
            button_zapisz.Location = new Point(798, 645);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(97, 39);
            button_zapisz.TabIndex = 10;
            button_zapisz.Text = "💾 Zapisz";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 134);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Chmiele";
            // 
            // button_Dodaj_chmiel
            // 
            button_Dodaj_chmiel.Location = new Point(559, 130);
            button_Dodaj_chmiel.Name = "button_Dodaj_chmiel";
            button_Dodaj_chmiel.Size = new Size(75, 23);
            button_Dodaj_chmiel.TabIndex = 12;
            button_Dodaj_chmiel.Text = "Dodaj";
            button_Dodaj_chmiel.UseVisualStyleBackColor = true;
            button_Dodaj_chmiel.Click += button_Dodaj_chmiel_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Ikona_chmiel, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Czas, Ibu_, Etap });
            dataGridView2.Location = new Point(477, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(368, 150);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // Ikona_chmiel
            // 
            Ikona_chmiel.FillWeight = 91.37056F;
            Ikona_chmiel.HeaderText = "";
            Ikona_chmiel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona_chmiel.Name = "Ikona_chmiel";
            Ikona_chmiel.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 101.725891F;
            dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 101.725891F;
            dataGridViewTextBoxColumn2.HeaderText = "Waga";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Czas
            // 
            Czas.FillWeight = 101.725891F;
            Czas.HeaderText = "Czas";
            Czas.Name = "Czas";
            // 
            // Ibu_
            // 
            Ibu_.FillWeight = 101.725891F;
            Ibu_.HeaderText = "IBU";
            Ibu_.Name = "Ibu_";
            // 
            // Etap
            // 
            Etap.FillWeight = 101.725891F;
            Etap.HeaderText = "Etap";
            Etap.Name = "Etap";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 112);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 14;
            label5.Text = "IBU";
            // 
            // label_IBU
            // 
            label_IBU.AutoSize = true;
            label_IBU.Location = new Point(413, 115);
            label_IBU.Name = "label_IBU";
            label_IBU.Size = new Size(13, 15);
            label_IBU.TabIndex = 15;
            label_IBU.Text = "0";
            // 
            // textBox_Obj
            // 
            textBox_Obj.Location = new Point(216, 32);
            textBox_Obj.Name = "textBox_Obj";
            textBox_Obj.Size = new Size(100, 23);
            textBox_Obj.TabIndex = 17;
            textBox_Obj.Text = "23";
            textBox_Obj.TextChanged += textBox_Obj_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 14);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 18;
            label7.Text = "Objętość ";
            // 
            // comboBox_Drozdze
            // 
            comboBox_Drozdze.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Drozdze.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Drozdze.FormattingEnabled = true;
            comboBox_Drozdze.Location = new Point(121, 365);
            comboBox_Drozdze.Name = "comboBox_Drozdze";
            comboBox_Drozdze.Size = new Size(121, 23);
            comboBox_Drozdze.TabIndex = 19;
            comboBox_Drozdze.SelectedIndexChanged += comboBox_Drozdze_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numericUpDown1.Location = new Point(306, 365);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 373);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 21;
            label6.Text = "Drozdze";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 366);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 22;
            label8.Text = "opk";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 31);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 23;
            label9.Text = "ABV";
            // 
            // label_ABV
            // 
            label_ABV.AutoSize = true;
            label_ABV.Location = new Point(559, 31);
            label_ABV.Name = "label_ABV";
            label_ABV.Size = new Size(13, 15);
            label_ABV.TabIndex = 24;
            label_ABV.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.BorderRadius = 15;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 645);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 25;
            button1.Text = "❌ Anuluj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(500, 68);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 26;
            label10.Text = "FG";
            // 
            // label_FG
            // 
            label_FG.AutoSize = true;
            label_FG.Location = new Point(553, 63);
            label_FG.Name = "label_FG";
            label_FG.Size = new Size(13, 15);
            label_FG.TabIndex = 27;
            label_FG.Text = "0";
            // 
            // button_Uwarz
            // 
            button_Uwarz.BackColor = Color.LightGreen;
            button_Uwarz.BorderRadius = 15;
            button_Uwarz.FlatStyle = FlatStyle.Flat;
            button_Uwarz.ForeColor = Color.White;
            button_Uwarz.Location = new Point(375, 645);
            button_Uwarz.Name = "button_Uwarz";
            button_Uwarz.Size = new Size(97, 39);
            button_Uwarz.TabIndex = 28;
            button_Uwarz.Text = "🍺 Uwarz ";
            button_Uwarz.UseVisualStyleBackColor = true;
            button_Uwarz.Visible = false;
            button_Uwarz.Click += button_Uwarz_Click;
            // 
            // comboBox_styl
            // 
            comboBox_styl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_styl.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_styl.FormattingEnabled = true;
            comboBox_styl.Location = new Point(39, 104);
            comboBox_styl.Name = "comboBox_styl";
            comboBox_styl.Size = new Size(106, 23);
            comboBox_styl.TabIndex = 29;
            comboBox_styl.SelectedIndexChanged += comboBox_styl_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(pasekStylu_FG);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pasekStylu_IBU);
            groupBox1.Controls.Add(pasekStylu_EBC);
            groupBox1.Controls.Add(pasekStylu_BLG);
            groupBox1.Controls.Add(pasekStylu_ABV);
            groupBox1.Location = new Point(11, 412);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 217);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zgodność ze stylem";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 171);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 9;
            label15.Text = "FG";
            // 
            // pasekStylu_FG
            // 
            pasekStylu_FG.BeerValue = 50D;
            pasekStylu_FG.Location = new Point(45, 153);
            pasekStylu_FG.MaxValue = 84D;
            pasekStylu_FG.MinValue = 24D;
            pasekStylu_FG.Name = "pasekStylu_FG";
            pasekStylu_FG.Size = new Size(300, 50);
            pasekStylu_FG.StyleMax = 70D;
            pasekStylu_FG.StyleMin = 30D;
            pasekStylu_FG.TabIndex = 8;
            pasekStylu_FG.Text = "pasekStylu1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(458, 120);
            label14.Name = "label14";
            label14.Size = new Size(25, 15);
            label14.TabIndex = 7;
            label14.Text = "IBU";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(456, 64);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 6;
            label13.Text = "EBC";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 102);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 5;
            label12.Text = "BLG";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 45);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 4;
            label11.Text = "ABV";
            // 
            // pasekStylu_IBU
            // 
            pasekStylu_IBU.BeerValue = 50D;
            pasekStylu_IBU.Location = new Point(495, 101);
            pasekStylu_IBU.MaxValue = 84D;
            pasekStylu_IBU.MinValue = 24D;
            pasekStylu_IBU.Name = "pasekStylu_IBU";
            pasekStylu_IBU.Size = new Size(300, 50);
            pasekStylu_IBU.StyleMax = 70D;
            pasekStylu_IBU.StyleMin = 30D;
            pasekStylu_IBU.TabIndex = 3;
            pasekStylu_IBU.Text = "pasekStylu4";
            // 
            // pasekStylu_EBC
            // 
            pasekStylu_EBC.BeerValue = 50D;
            pasekStylu_EBC.Location = new Point(495, 45);
            pasekStylu_EBC.MaxValue = 84D;
            pasekStylu_EBC.MinValue = 24D;
            pasekStylu_EBC.Name = "pasekStylu_EBC";
            pasekStylu_EBC.Size = new Size(300, 50);
            pasekStylu_EBC.StyleMax = 70D;
            pasekStylu_EBC.StyleMin = 30D;
            pasekStylu_EBC.TabIndex = 2;
            pasekStylu_EBC.Text = "pasekStylu3";
            // 
            // pasekStylu_BLG
            // 
            pasekStylu_BLG.BeerValue = 50D;
            pasekStylu_BLG.Location = new Point(45, 85);
            pasekStylu_BLG.MaxValue = 84D;
            pasekStylu_BLG.MinValue = 24D;
            pasekStylu_BLG.Name = "pasekStylu_BLG";
            pasekStylu_BLG.Size = new Size(300, 50);
            pasekStylu_BLG.StyleMax = 70D;
            pasekStylu_BLG.StyleMin = 30D;
            pasekStylu_BLG.TabIndex = 1;
            pasekStylu_BLG.Text = "pasekStylu2";
            // 
            // pasekStylu_ABV
            // 
            pasekStylu_ABV.BeerValue = 50D;
            pasekStylu_ABV.Location = new Point(45, 29);
            pasekStylu_ABV.MaxValue = 84D;
            pasekStylu_ABV.MinValue = 24D;
            pasekStylu_ABV.Name = "pasekStylu_ABV";
            pasekStylu_ABV.Size = new Size(300, 50);
            pasekStylu_ABV.StyleMax = 70D;
            pasekStylu_ABV.StyleMin = 30D;
            pasekStylu_ABV.TabIndex = 0;
            pasekStylu_ABV.Text = "pasekStylu1";
            // 
            // Form_Dodaj_Recepture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 696);
            Controls.Add(groupBox1);
            Controls.Add(comboBox_styl);
            Controls.Add(button_Uwarz);
            Controls.Add(label_FG);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label_ABV);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox_Drozdze);
            Controls.Add(label7);
            Controls.Add(textBox_Obj);
            Controls.Add(label_IBU);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(button_Dodaj_chmiel);
            Controls.Add(label4);
            Controls.Add(button_zapisz);
            Controls.Add(label_EBC);
            Controls.Add(label3);
            Controls.Add(label_BLG);
            Controls.Add(label_3);
            Controls.Add(button_Dodaj_Slod);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox_Nazwa_Receptury);
            Controls.Add(label1);
            Name = "Form_Dodaj_Recepture";
            Text = "Form2";
            FormClosed += Form_Dodaj_Recepture_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Nazwa_Receptury;
        private Label label2;
        public PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button_Dodaj_Slod;
        private Label label_3;
        private Label label_BLG;
        private Label label3;
        private Label label_EBC;
        private RoundedButton button_zapisz;
        private Label label4;
        private Button button_Dodaj_chmiel;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label_IBU;
        private TextBox textBox_Obj;
        private Label label7;
        private ComboBox comboBox_Drozdze;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label_ABV;
        private RoundedButton button1;
        private Label label10;
        private Label label_FG;
        private RoundedButton button_Uwarz;
        private DataGridViewImageColumn Ikona_slod;
        private DataGridViewTextBoxColumn Nazwa_slod;
        private DataGridViewTextBoxColumn Waga;
        private DataGridViewTextBoxColumn Procent;
        private DataGridViewImageColumn Ikona_chmiel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Czas;
        private DataGridViewTextBoxColumn Ibu_;
        private DataGridViewTextBoxColumn Etap;
        private ComboBox comboBox_styl;
        private GroupBox groupBox1;
        private PasekStylu pasekStylu_IBU;
        private PasekStylu pasekStylu_EBC;
        private PasekStylu pasekStylu_BLG;
        private PasekStylu pasekStylu_ABV;
        private PasekStylu pasekStylu_FG;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label15;
    }
}