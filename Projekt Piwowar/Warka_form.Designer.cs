namespace Projekt_Piwowar
{
    partial class Warka_form
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
            toolTip1 = new ToolTip(components);
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            button_uwarz2 = new RoundedButton();
            EtapNaGotowe = new RoundedButton();
            Gotowe = new TabPage();
            button2 = new RoundedButton();
            Archiwum_button = new RoundedButton();
            Fermentacja = new TabPage();
            Fermentacja_Wyjdz = new RoundedButton();
            groupBox1 = new GroupBox();
            OBJ_butel_textbox = new TextBox();
            label6 = new Label();
            FG_textbox = new TextBox();
            label5 = new Label();
            OG_textbox = new TextBox();
            label4 = new Label();
            Warzenie = new TabPage();
            button3 = new RoundedButton();
            button_Fermentacja = new RoundedButton();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            Planowanie = new TabPage();
            label14 = new Label();
            label13 = new Label();
            button1 = new RoundedButton();
            groupBox2 = new GroupBox();
            dateTimePicker_gotowe = new DateTimePicker();
            label9 = new Label();
            dateTimePicker_butelka = new DateTimePicker();
            dateTimePicker_lezakowanie = new DateTimePicker();
            label8 = new Label();
            checkBox_lagerowanie = new CheckBox();
            label7 = new Label();
            dateTimePicker_cicha = new DateTimePicker();
            label_Cicha = new Label();
            checkBox3 = new CheckBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button_uwarz = new RoundedButton();
            dataGridView1 = new DataGridView();
            Ikona = new DataGridViewImageColumn();
            Skladnik = new DataGridViewTextBoxColumn();
            Potrzebne = new DataGridViewTextBoxColumn();
            Zapas = new DataGridViewTextBoxColumn();
            checkBox1 = new CheckBox();
            textBox_nazwa = new TextBox();
            textBox_numer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            Gotowe.SuspendLayout();
            Fermentacja.SuspendLayout();
            groupBox1.SuspendLayout();
            Warzenie.SuspendLayout();
            Planowanie.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 200);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(282, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Jeżeli brak w magazynie,ustawić wage na minus?";
            toolTip1.SetToolTip(checkBox2, "Jezeli nie masz składnika w magazynie ustawi jego wage na np: -1kg. Może to pomóc jeżeli potem dodasz zakup 5 kg");
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(35, 314);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(188, 19);
            checkBox4.TabIndex = 17;
            checkBox4.Text = "Dodanie do Kalendarza Google";
            toolTip1.SetToolTip(checkBox4, "Aby dodać wydarzenia do Kalendarza Google zaznacz, \r\nnastępnie naciśnij przycisk Uwarz!\r\n");
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button_uwarz2
            // 
            button_uwarz2.BackColor = Color.LightGreen;
            button_uwarz2.BorderRadius = 15;
            button_uwarz2.FlatStyle = FlatStyle.Flat;
            button_uwarz2.Font = new Font("Segoe UI", 11F);
            button_uwarz2.ForeColor = Color.White;
            button_uwarz2.Location = new Point(876, 484);
            button_uwarz2.Name = "button_uwarz2";
            button_uwarz2.Size = new Size(90, 35);
            button_uwarz2.TabIndex = 13;
            button_uwarz2.Text = "🍺 Uwarz ";
            toolTip1.SetToolTip(button_uwarz2, "Zmienia status Warki na Warzenie");
            button_uwarz2.UseVisualStyleBackColor = true;
            button_uwarz2.Click += button_uwarz2_Click;
            // 
            // EtapNaGotowe
            // 
            EtapNaGotowe.BackColor = Color.LightGreen;
            EtapNaGotowe.BorderRadius = 15;
            EtapNaGotowe.FlatStyle = FlatStyle.Flat;
            EtapNaGotowe.ForeColor = Color.White;
            EtapNaGotowe.Location = new Point(866, 484);
            EtapNaGotowe.Name = "EtapNaGotowe";
            EtapNaGotowe.Size = new Size(100, 35);
            EtapNaGotowe.TabIndex = 14;
            EtapNaGotowe.Text = "✅ Gotowe";
            toolTip1.SetToolTip(EtapNaGotowe, "Zmienia status warki na Gotowe");
            EtapNaGotowe.UseVisualStyleBackColor = true;
            EtapNaGotowe.Click += EtapNaGotowe_Click;
            // 
            // Gotowe
            // 
            Gotowe.Controls.Add(button2);
            Gotowe.Controls.Add(Archiwum_button);
            Gotowe.Location = new Point(4, 24);
            Gotowe.Name = "Gotowe";
            Gotowe.Padding = new Padding(3);
            Gotowe.Size = new Size(975, 529);
            Gotowe.TabIndex = 3;
            Gotowe.Text = "Gotowe";
            Gotowe.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.BorderRadius = 15;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(8, 484);
            button2.Name = "button2";
            button2.Size = new Size(90, 35);
            button2.TabIndex = 15;
            button2.Text = "💾 Wyjdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Fermentacja_Wyjdz_Click;
            // 
            // Archiwum_button
            // 
            Archiwum_button.BackColor = Color.LightGreen;
            Archiwum_button.BorderRadius = 15;
            Archiwum_button.FlatStyle = FlatStyle.Flat;
            Archiwum_button.ForeColor = Color.White;
            Archiwum_button.Location = new Point(846, 484);
            Archiwum_button.Name = "Archiwum_button";
            Archiwum_button.Size = new Size(120, 35);
            Archiwum_button.TabIndex = 14;
            Archiwum_button.Text = "🗄️ Zarchiwizuj";
            Archiwum_button.UseVisualStyleBackColor = true;
            Archiwum_button.Click += Archiwum_button_Click;
            // 
            // Fermentacja
            // 
            Fermentacja.Controls.Add(EtapNaGotowe);
            Fermentacja.Controls.Add(Fermentacja_Wyjdz);
            Fermentacja.Controls.Add(groupBox1);
            Fermentacja.Location = new Point(4, 24);
            Fermentacja.Name = "Fermentacja";
            Fermentacja.Padding = new Padding(3);
            Fermentacja.Size = new Size(975, 529);
            Fermentacja.TabIndex = 2;
            Fermentacja.Text = "Fermentacja";
            Fermentacja.UseVisualStyleBackColor = true;
            // 
            // Fermentacja_Wyjdz
            // 
            Fermentacja_Wyjdz.BackColor = Color.LightGreen;
            Fermentacja_Wyjdz.BorderRadius = 15;
            Fermentacja_Wyjdz.FlatStyle = FlatStyle.Flat;
            Fermentacja_Wyjdz.ForeColor = Color.White;
            Fermentacja_Wyjdz.Location = new Point(8, 484);
            Fermentacja_Wyjdz.Name = "Fermentacja_Wyjdz";
            Fermentacja_Wyjdz.Size = new Size(90, 35);
            Fermentacja_Wyjdz.TabIndex = 13;
            Fermentacja_Wyjdz.Text = "💾 Wyjdź";
            Fermentacja_Wyjdz.UseVisualStyleBackColor = true;
            Fermentacja_Wyjdz.Click += Fermentacja_Wyjdz_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OBJ_butel_textbox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(FG_textbox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(OG_textbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(515, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zmierzone wartości";
            // 
            // OBJ_butel_textbox
            // 
            OBJ_butel_textbox.Location = new Point(6, 148);
            OBJ_butel_textbox.Name = "OBJ_butel_textbox";
            OBJ_butel_textbox.Size = new Size(100, 23);
            OBJ_butel_textbox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 119);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 4;
            label6.Text = "Butelkowana objętość";
            // 
            // FG_textbox
            // 
            FG_textbox.Location = new Point(237, 57);
            FG_textbox.Name = "FG_textbox";
            FG_textbox.Size = new Size(100, 23);
            FG_textbox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 34);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 2;
            label5.Text = "Gęstość końcowa";
            // 
            // OG_textbox
            // 
            OG_textbox.Location = new Point(6, 57);
            OG_textbox.Name = "OG_textbox";
            OG_textbox.Size = new Size(100, 23);
            OG_textbox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 0;
            label4.Text = "Gęstość początkowa";
            // 
            // Warzenie
            // 
            Warzenie.Controls.Add(button3);
            Warzenie.Controls.Add(button_Fermentacja);
            Warzenie.Controls.Add(label12);
            Warzenie.Controls.Add(label11);
            Warzenie.Controls.Add(label10);
            Warzenie.Location = new Point(4, 24);
            Warzenie.Name = "Warzenie";
            Warzenie.Padding = new Padding(3);
            Warzenie.Size = new Size(975, 529);
            Warzenie.TabIndex = 0;
            Warzenie.Text = "Warzenie";
            Warzenie.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.BorderRadius = 15;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(8, 484);
            button3.Name = "button3";
            button3.Size = new Size(90, 35);
            button3.TabIndex = 13;
            button3.Text = "❌ Anuluj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button_Fermentacja
            // 
            button_Fermentacja.BackColor = Color.LightGreen;
            button_Fermentacja.BorderRadius = 15;
            button_Fermentacja.FlatStyle = FlatStyle.Flat;
            button_Fermentacja.ForeColor = Color.White;
            button_Fermentacja.Location = new Point(841, 484);
            button_Fermentacja.Name = "button_Fermentacja";
            button_Fermentacja.Size = new Size(125, 35);
            button_Fermentacja.TabIndex = 3;
            button_Fermentacja.Text = "\U0001fae7 Fermentacja";
            button_Fermentacja.UseVisualStyleBackColor = true;
            button_Fermentacja.Click += button_Fermentacja_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(670, 129);
            label12.Name = "label12";
            label12.Size = new Size(215, 15);
            label12.TabIndex = 2;
            label12.Text = "Drukowanie listy składników i receptury";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 129);
            label11.Name = "label11";
            label11.Size = new Size(311, 15);
            label11.TabIndex = 1;
            label11.Text = "Jakiś licznik czasu, który wysyła powiadomienia na telefon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(161, 77);
            label10.Name = "label10";
            label10.Size = new Size(115, 15);
            label10.TabIndex = 0;
            label10.Text = "Tu kiedyś coś będzie";
            // 
            // Planowanie
            // 
            Planowanie.Controls.Add(label14);
            Planowanie.Controls.Add(label13);
            Planowanie.Controls.Add(button_uwarz2);
            Planowanie.Controls.Add(button1);
            Planowanie.Controls.Add(groupBox2);
            Planowanie.Controls.Add(button_uwarz);
            Planowanie.Controls.Add(checkBox2);
            Planowanie.Controls.Add(dataGridView1);
            Planowanie.Controls.Add(checkBox1);
            Planowanie.Controls.Add(textBox_nazwa);
            Planowanie.Controls.Add(textBox_numer);
            Planowanie.Controls.Add(label1);
            Planowanie.Controls.Add(label2);
            Planowanie.Location = new Point(4, 24);
            Planowanie.Name = "Planowanie";
            Planowanie.Padding = new Padding(3);
            Planowanie.Size = new Size(975, 529);
            Planowanie.TabIndex = 1;
            Planowanie.Text = "Planowanie";
            Planowanie.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(515, 51);
            label14.Name = "label14";
            label14.Size = new Size(160, 20);
            label14.TabIndex = 15;
            label14.Text = "Zaplanuj w Kalendarzu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(17, 153);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 14;
            label13.Text = "Opcje magazynu";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.BorderRadius = 15;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 484);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 12;
            button1.Text = "❌ Anuluj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(dateTimePicker_gotowe);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateTimePicker_butelka);
            groupBox2.Controls.Add(dateTimePicker_lezakowanie);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox_lagerowanie);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dateTimePicker_cicha);
            groupBox2.Controls.Add(label_Cicha);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(515, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 353);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // dateTimePicker_gotowe
            // 
            dateTimePicker_gotowe.Location = new Point(155, 252);
            dateTimePicker_gotowe.Name = "dateTimePicker_gotowe";
            dateTimePicker_gotowe.Size = new Size(200, 23);
            dateTimePicker_gotowe.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 258);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 15;
            label9.Text = "Kiedy gotowe do picia";
            // 
            // dateTimePicker_butelka
            // 
            dateTimePicker_butelka.Location = new Point(155, 202);
            dateTimePicker_butelka.Name = "dateTimePicker_butelka";
            dateTimePicker_butelka.Size = new Size(200, 23);
            dateTimePicker_butelka.TabIndex = 14;
            // 
            // dateTimePicker_lezakowanie
            // 
            dateTimePicker_lezakowanie.Location = new Point(155, 151);
            dateTimePicker_lezakowanie.Name = "dateTimePicker_lezakowanie";
            dateTimePicker_lezakowanie.Size = new Size(200, 23);
            dateTimePicker_lezakowanie.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 157);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 12;
            label8.Text = "Data Przelania";
            // 
            // checkBox_lagerowanie
            // 
            checkBox_lagerowanie.AutoSize = true;
            checkBox_lagerowanie.Location = new Point(25, 126);
            checkBox_lagerowanie.Name = "checkBox_lagerowanie";
            checkBox_lagerowanie.Size = new Size(173, 19);
            checkBox_lagerowanie.TabIndex = 11;
            checkBox_lagerowanie.Text = "Przelewasz na Lezakowanie?";
            checkBox_lagerowanie.UseVisualStyleBackColor = true;
            checkBox_lagerowanie.CheckedChanged += checkBox_lagerowanie_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 210);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 10;
            label7.Text = "Data butelkowania";
            // 
            // dateTimePicker_cicha
            // 
            dateTimePicker_cicha.Location = new Point(155, 88);
            dateTimePicker_cicha.Name = "dateTimePicker_cicha";
            dateTimePicker_cicha.Size = new Size(200, 23);
            dateTimePicker_cicha.TabIndex = 9;
            // 
            // label_Cicha
            // 
            label_Cicha.AutoSize = true;
            label_Cicha.Location = new Point(25, 94);
            label_Cicha.Name = "label_Cicha";
            label_Cicha.Size = new Size(81, 15);
            label_Cicha.TabIndex = 8;
            label_Cicha.Text = "Data Przelania";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(25, 59);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(136, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Przelewasz na Cichą?";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 25);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Data Warzenia";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(155, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button_uwarz
            // 
            button_uwarz.BackColor = Color.LightGreen;
            button_uwarz.BorderRadius = 15;
            button_uwarz.FlatStyle = FlatStyle.Flat;
            button_uwarz.Font = new Font("Segoe UI", 11F);
            button_uwarz.ForeColor = Color.White;
            button_uwarz.Location = new Point(768, 484);
            button_uwarz.Name = "button_uwarz";
            button_uwarz.Size = new Size(102, 35);
            button_uwarz.TabIndex = 10;
            button_uwarz.Text = "📅 Zaplanuj";
            button_uwarz.UseVisualStyleBackColor = true;
            button_uwarz.Click += button_uwarz_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ikona, Skladnik, Potrzebne, Zapas });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(17, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 15;
            dataGridView1.Size = new Size(344, 174);
            dataGridView1.TabIndex = 8;
            // 
            // Ikona
            // 
            Ikona.FillWeight = 30F;
            Ikona.HeaderText = "";
            Ikona.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ikona.Name = "Ikona";
            Ikona.ReadOnly = true;
            // 
            // Skladnik
            // 
            Skladnik.FillWeight = 81.9832458F;
            Skladnik.HeaderText = "Składnik";
            Skladnik.Name = "Skladnik";
            Skladnik.ReadOnly = true;
            // 
            // Potrzebne
            // 
            Potrzebne.FillWeight = 81.9832458F;
            Potrzebne.HeaderText = "Potrzebne";
            Potrzebne.Name = "Potrzebne";
            Potrzebne.ReadOnly = true;
            // 
            // Zapas
            // 
            Zapas.FillWeight = 81.9832458F;
            Zapas.HeaderText = "Zapas";
            Zapas.Name = "Zapas";
            Zapas.ReadOnly = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackgroundImageLayout = ImageLayout.None;
            checkBox1.Location = new Point(17, 175);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Czy Pobrac Materiały z magazynu?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_nazwa
            // 
            textBox_nazwa.Location = new Point(111, 33);
            textBox_nazwa.Name = "textBox_nazwa";
            textBox_nazwa.Size = new Size(100, 23);
            textBox_nazwa.TabIndex = 2;
            // 
            // textBox_numer
            // 
            textBox_numer.Location = new Point(111, 66);
            textBox_numer.Name = "textBox_numer";
            textBox_numer.Size = new Size(100, 23);
            textBox_numer.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Nazwa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Warka nr";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Planowanie);
            tabControl1.Controls.Add(Warzenie);
            tabControl1.Controls.Add(Fermentacja);
            tabControl1.Controls.Add(Gotowe);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 557);
            tabControl1.TabIndex = 11;
            // 
            // Warka_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 556);
            Controls.Add(tabControl1);
            Name = "Warka_form";
            Text = "Warka_form";
            FormClosed += Warka_form_FormClosed;
            Gotowe.ResumeLayout(false);
            Fermentacja.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Warzenie.ResumeLayout(false);
            Warzenie.PerformLayout();
            Planowanie.ResumeLayout(false);
            Planowanie.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TabPage Gotowe;
        private TabPage Fermentacja;
        private RoundedButton Fermentacja_Wyjdz;
        private GroupBox groupBox1;
        private TextBox OBJ_butel_textbox;
        private Label label6;
        private TextBox FG_textbox;
        private Label label5;
        private TextBox OG_textbox;
        private Label label4;
        private TabPage Warzenie;
        private RoundedButton button_Fermentacja;
        private Label label12;
        private Label label11;
        private Label label10;
        private TabPage Planowanie;
        private RoundedButton button1;
        private GroupBox groupBox2;
        private CheckBox checkBox4;
        private DateTimePicker dateTimePicker_gotowe;
        private Label label9;
        private DateTimePicker dateTimePicker_butelka;
        private DateTimePicker dateTimePicker_lezakowanie;
        private Label label8;
        private CheckBox checkBox_lagerowanie;
        private Label label7;
        private DateTimePicker dateTimePicker_cicha;
        private Label label_Cicha;
        private CheckBox checkBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private RoundedButton button_uwarz;
        private CheckBox checkBox2;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private TextBox textBox_nazwa;
        private TextBox textBox_numer;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private RoundedButton button3;
        private RoundedButton button_uwarz2;
        private RoundedButton EtapNaGotowe;
        private RoundedButton Archiwum_button;
        private RoundedButton button2;
        private Label label13;
        private DataGridViewImageColumn Ikona;
        private DataGridViewTextBoxColumn Skladnik;
        private DataGridViewTextBoxColumn Potrzebne;
        private DataGridViewTextBoxColumn Zapas;
        private Label label14;
    }
}