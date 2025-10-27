using System.Windows.Forms;

namespace Projekt_Piwowar
{
    public partial class Form_Magazyn : Form
    {

        public Form_Magazyn()
        {


            InitializeComponent();
            Dodaj_slody_do_tabeli();
            Dodaj_chmiele_do_tabeli();
            Dodaj_drozdze_do_tabeli();
            Warka.Aktualizacja_Etapu();



            ApplyLightTheme();

        }

        private void ApplyLightTheme()
        {
            // Formularz
            JasnyMotyw.StyleForm(this);

            // Menu
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;

            // Gridy
            JasnyMotyw.StyleGridLight(Tabela_Slodu);
            JasnyMotyw.StyleGridLight(tabela_chmielu);
            JasnyMotyw.StyleGridLight(Tabela_drozdzy);

            // Pola
            StyleInputLight(comboBox_Nazwa_slodu);
            StyleInputLight(comboBox_Produkt);
            StyleInputLight(textBox_Waga);
            StyleInputLight(textBox_Cena);



            // Zielony przycisk Dodaj
            StyleGreenButton(button_Dodaj, "➕ Dodaj");

            // Szary przycisk Zapisz
            StyleBlueButton(button_Zapisz, "💾 Zapisz");

            JasnyMotyw.Watermark(textBox_Cena, "Cena (za całość)");
            JasnyMotyw.Watermark(textBox_Waga, "Waga");
        }


        private void StyleInputLight(Control ctrl)
        {
            ctrl.BackColor = Color.White;
            ctrl.ForeColor = Color.Black;
            if (ctrl is ComboBox cb)
                cb.FlatStyle = FlatStyle.Flat;
        }

        private void StyleGreenButton(RoundedButton btn, string text)
        {
            btn.Text = text;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            // Hover efekt
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(0, 200, 83);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.LightGreen;
        }

        private void StyleBlueButton(Button btn, string text)
        {
            btn.Text = text;
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            btn.MouseEnter += (s, e) => btn.BackColor = Color.DeepSkyBlue;
            btn.MouseLeave += (s, e) => btn.BackColor = Color.LightBlue;
        }










        private void Dodaj_slody_do_tabeli()
        {
            Tabela_Slodu.Rows.Clear();
            for (int i = 0; i < Slod_uzytkownika.ListaSlodowUzytkownika.Count; i++)
            {
                Tabela_Slodu.Rows.Add(Properties.Resources.slodikona, Slod_uzytkownika.ListaSlodowUzytkownika[i].Slod.Nazwa, Slod_uzytkownika.ListaSlodowUzytkownika[i].Waga, Slod_uzytkownika.ListaSlodowUzytkownika[i].Cena);
            }
        }
        private void Dodaj_chmiele_do_tabeli()
        {
            tabela_chmielu.Rows.Clear();
            for (int i = 0; i < Chmiel_uzytkownika.ListaChmieluUzytkownika.Count; i++)
            {
                tabela_chmielu.Rows.Add(Properties.Resources.chmielikona, Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Chmiel.Nazwa, Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Waga, Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Cena);
            }

        }
        private void Dodaj_drozdze_do_tabeli()
        {
            Tabela_drozdzy.Rows.Clear();
            for (int i = 0; i < Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Count; i++)
            {
                Tabela_drozdzy.Rows.Add(Properties.Resources.drodzeikonka, Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Drozdze.Nazwa, Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Waga, Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Cena);
            }

        }



        private void Aktywacja_Guzika()
        {
            if (textBox_Waga.Text.Length > 0 && textBox_Cena.Text.Length > 0)
            {
                button_Dodaj.Enabled = true;
            }
            else
            {
                button_Dodaj.Enabled = false;
            }
        }


        private void textBox_Waga_TextChanged(object sender, EventArgs e)
        {
            Aktywacja_Guzika();

            JasnyMotyw.Watermark(textBox_Waga, "Waga");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Produkt.SelectedIndex == 0) // Jezeli slod dodaje nazwy slodu do kolejnego combobox
            {
                comboBox_Nazwa_slodu.Enabled = true;
                comboBox_Nazwa_slodu.Items.Clear();
                comboBox_Nazwa_slodu.Enabled = true;
                foreach (Slod slod in Slod.ListaSlodow)
                {
                    comboBox_Nazwa_slodu.Items.Add(slod.Nazwa);
                }

            }
            else if (comboBox_Produkt.SelectedIndex == 1) // Jezeli chmiel dodaje nazwy chmieli do kolejnego combobox
            {

                comboBox_Nazwa_slodu.Enabled = true;
                comboBox_Nazwa_slodu.Items.Clear();
                comboBox_Nazwa_slodu.Enabled = true;
                foreach (Chmiel chmiel in Chmiel.ListaChmieli)
                {
                    comboBox_Nazwa_slodu.Items.Add(chmiel.Nazwa);
                }
            }
            else if (comboBox_Produkt.SelectedIndex == 2) // Jezeli drozdze dodaje nazwy drozdzy do kolejnego combobox
            {

                comboBox_Nazwa_slodu.Enabled = true;
                comboBox_Nazwa_slodu.Items.Clear();
                comboBox_Nazwa_slodu.Enabled = true;
                foreach (Drozdze drozdze in Drozdze.ListaDrozdzy)
                {
                    comboBox_Nazwa_slodu.Items.Add(drozdze.Nazwa);
                }
            }
            Aktywacja_Guzika();
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            double Waga;
            if (double.TryParse(textBox_Waga.Text, out double result))
            {
                Waga = result;
            }
            else
            {
                textBox_Waga.Text = textBox_Waga.Text.Replace(".", ",");
                if (double.TryParse(textBox_Waga.Text, out double rezult))
                {
                    Waga = rezult;
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu wagi");
                    return;
                }
            }
            double Cena;
            if (double.TryParse(textBox_Cena.Text, out double result1))
            {
                Cena = result1;
            }
            else
            {
                textBox_Cena.Text = textBox_Cena.Text.Replace(".", ",");
                if (double.TryParse(textBox_Cena.Text, out double rezult1))
                {
                    Cena = rezult1;
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu Ceny");
                    return;
                }
            }


            bool Czy_nowy = true;

            //Dodawanie danych z pól do bazy danych

            if (comboBox_Produkt.SelectedIndex == 0) // Jezeli slod to:
            {


                foreach (Slod_uzytkownika element in Slod_uzytkownika.ListaSlodowUzytkownika)
                {
                    if (element.Slod.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                    {
                        element.Waga = element.Waga + Waga;
                        element.Cena = (element.Cena * element.Waga + Waga * Cena) / (element.Waga + Waga);
                        Czy_nowy = false;
                        break;
                    }
                }
                if (Czy_nowy)
                {
                    foreach (Slod element in Slod.ListaSlodow)
                    {
                        if (element.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                        {
                            Slod_uzytkownika slod = new(Waga, Cena / Waga, element);
                            Slod_uzytkownika.ListaSlodowUzytkownika.Add(slod);

                        }
                    }


                }
                Dodaj_slody_do_tabeli();
            }
            else if (comboBox_Produkt.SelectedIndex == 1) // Jezeli chmiel to:
            {
                foreach (Chmiel_uzytkownika element in Chmiel_uzytkownika.ListaChmieluUzytkownika)
                {
                    if (element.Chmiel.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                    {
                        element.Waga = element.Waga + Waga;
                        element.Cena = (element.Cena * element.Waga + Waga * Cena) / (element.Waga + Waga);
                        Czy_nowy = false;
                        break;
                    }
                }
                if (Czy_nowy)
                {
                    foreach (Chmiel element in Chmiel.ListaChmieli)
                    {
                        if (element.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                        {
                            Chmiel_uzytkownika chmiel_Uzytkownika = new(Waga, Cena / Waga, element);
                            Chmiel_uzytkownika.ListaChmieluUzytkownika.Add(chmiel_Uzytkownika);

                        }
                    }


                }
                Dodaj_chmiele_do_tabeli();
            }
            else if (comboBox_Produkt.SelectedIndex == 2) // Jezeli chmiel to:
            {
                foreach (Drozdze_uzytkownika element in Drozdze_uzytkownika.ListaDrozdzyUzytkownika)
                {
                    if (element.Drozdze.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                    {
                        element.Waga = element.Waga + Waga;
                        element.Cena = (element.Cena * element.Waga + Waga * Cena) / (element.Waga + Waga);
                        Czy_nowy = false;
                        break;
                    }
                }
                if (Czy_nowy)
                {
                    foreach (Drozdze element in Drozdze.ListaDrozdzy)
                    {
                        if (element.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                        {
                            Drozdze_uzytkownika Drozdze = new(Waga, Cena / Waga, element);
                            Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Add(Drozdze);

                        }
                    }


                }
                Dodaj_drozdze_do_tabeli();
            }



            //Usuwanie danych z pól tekstowych
            comboBox_Nazwa_slodu.Enabled = false;
            comboBox_Nazwa_slodu.Items.Clear();
            textBox_Cena.Clear();
            textBox_Waga.Clear();


        }

        private void textBox_Cena_TextChanged(object sender, EventArgs e)
        {
            Aktywacja_Guzika();
            JasnyMotyw.Watermark(textBox_Cena, "Cena (za całość)");
        }

        private void button_Zapisz_Click(object sender, EventArgs e)
        {
            Slod_uzytkownika.Zmien_wartosci_w_pliku();
            Chmiel_uzytkownika.Zmien_wartosci_w_pliku();
            Drozdze_uzytkownika.Zmien_wartosci_w_pliku();
        }

        private void dodajReceptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dodaj_Recepture form_Dodaj_Recepture = new(this);
            form_Dodaj_Recepture.Show();
            this.Hide();

        }

        private void twojeRecepturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Moje_Receptury moje_Receptury = new Moje_Receptury(this);
            moje_Receptury.Show();
            this.Hide();
        }


        //Funkcje wywoływane przy podwójnym kliknięciu tabeli, służą do edycji zawartości magazynu


        private void Tabela_Slodu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //Był problem z przekazaniem przez referencje nazwy,wagi i ceny( ale obszedłem go na około) listami

            List<string> ListaStringDoprzekazania = new();
            List<double> ListaDoubleDoprzekazania = new();
            ListaDoubleDoprzekazania.Add(Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex].Waga);
            ListaDoubleDoprzekazania.Add(Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex].Cena);
            ListaStringDoprzekazania.Add(Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex].Slod.Nazwa);
            Edycja_Magazyn edycja_Slodu = new Edycja_Magazyn(ListaStringDoprzekazania, ListaDoubleDoprzekazania, "Slod");




            edycja_Slodu.ShowDialog();
            if (edycja_Slodu.DialogResult == DialogResult.OK)
            {
                Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex].Waga = ListaDoubleDoprzekazania[0];
                Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex].Cena = ListaDoubleDoprzekazania[1];
            }
            else if (edycja_Slodu.DialogResult == DialogResult.No)
            {
                Slod_uzytkownika.ListaSlodowUzytkownika.Remove(Slod_uzytkownika.ListaSlodowUzytkownika[e.RowIndex]);
            }
            Dodaj_slody_do_tabeli();



        }

        private void tabela_chmielu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            List<string> ListaStringDoprzekazania = new();
            List<double> ListaDoubleDoprzekazania = new();
            ListaDoubleDoprzekazania.Add(Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex].Waga);
            ListaDoubleDoprzekazania.Add(Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex].Cena);
            ListaStringDoprzekazania.Add(Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex].Chmiel.Nazwa);
            Edycja_Magazyn edycja_Slodu = new Edycja_Magazyn(ListaStringDoprzekazania, ListaDoubleDoprzekazania, "Chmiel");




            edycja_Slodu.ShowDialog();
            if (edycja_Slodu.DialogResult == DialogResult.OK)
            {
                Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex].Waga = ListaDoubleDoprzekazania[0];
                Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex].Cena = ListaDoubleDoprzekazania[1];
            }
            else if (edycja_Slodu.DialogResult == DialogResult.No)
            {
                Chmiel_uzytkownika.ListaChmieluUzytkownika.Remove(Chmiel_uzytkownika.ListaChmieluUzytkownika[e.RowIndex]);
            }
            Dodaj_chmiele_do_tabeli();
        }

        private void Tabela_drozdzy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            List<string> ListaStringDoprzekazania = new();
            List<double> ListaDoubleDoprzekazania = new();
            ListaDoubleDoprzekazania.Add(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex].Waga);
            ListaDoubleDoprzekazania.Add(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex].Cena);
            ListaStringDoprzekazania.Add(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex].Drozdze.Nazwa);
            Edycja_Magazyn edycja_Slodu = new Edycja_Magazyn(ListaStringDoprzekazania, ListaDoubleDoprzekazania, "Drozdze");




            edycja_Slodu.ShowDialog();
            if (edycja_Slodu.DialogResult == DialogResult.OK)
            {
                Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex].Waga = ListaDoubleDoprzekazania[0];
                Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex].Cena = ListaDoubleDoprzekazania[1];
            }
            else if (edycja_Slodu.DialogResult == DialogResult.No)
            {
                Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Remove(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[e.RowIndex]);
            }
            Dodaj_drozdze_do_tabeli();

        }

        private void twojeWarkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MojeWarki mojeWarki = new MojeWarki(this);
            mojeWarki.Show();
        }

        private void comboBox_Produkt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }

        }

        private void button_Dodaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Dodaj.PerformClick();
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }
        }

        private void button_Zapisz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Zapisz.PerformClick();
            }
        }


        private void comboBox_Nazwa_slodu_Enter(object sender, EventArgs e)
        {
            comboBox_Nazwa_slodu.DroppedDown = true;
        }


        private void textBox_Waga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }
            else
            {

                JasnyMotyw.PrzyciskZmieniajacyWatermark(textBox_Waga, "Waga", e);


            }
        }

        private void textBox_Cena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }
            else
            {
                JasnyMotyw.PrzyciskZmieniajacyWatermark(textBox_Cena, "Cena (za całość)", e);

            }
        }

        private void konfiguaracjaStratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            KonfiguracjaStrat konfiguracja = new(this);
            konfiguracja.Show();
            this.Hide();
        }
    }
}
