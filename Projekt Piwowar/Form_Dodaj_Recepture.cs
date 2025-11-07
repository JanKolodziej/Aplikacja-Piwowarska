using Biblioteka_Klas_Piwowar;
using Projekt_Piwowar.Properties;

namespace Projekt_Piwowar
{

    public partial class Form_Dodaj_Recepture : Form
    {
        public List<Slod_uzytkownika> listaSlodowReceptura = new();
        public List<Chmiel_uzytkownika> ListaChmieliReceptura = new();
        public double masa_slodu;
        public string nazwa = "";
        public string styl = "";
        public double OBJ = 20;
        public double Wyd = 70;
        public double str = 3;
        public double BLG = 0;
        public double ebc = 0;
        public double Final_BLG = 0.0;
        public double alkohol = 0.0;

        private bool Czy_edytowany = false;

        public List<Drozdze_uzytkownika> ListaD = new();

        public double ibu;
        Form_Magazyn Magazyn;
        Receptura receptura1 = null;
        public Form_Dodaj_Recepture(Form_Magazyn magazyn, Receptura receptura = null)
        {
            Magazyn = magazyn;
            receptura1 = receptura;

            InitializeComponent();

            JasnyMotyw.StyleGridLight(dataGridView1);
            JasnyMotyw.StyleGridLight(dataGridView2);
            JasnyMotyw.StyleButton(button_zapisz, Color.LightBlue, Color.DeepSkyBlue);
            JasnyMotyw.StyleButton(button1, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_Uwarz, Color.LightGreen, Color.FromArgb(0, 200, 83));

            foreach (Styl styl in Styl.ListaStylow)
            {
                comboBox_styl.Items.Add(styl.Nazwa);
            }

            foreach (Drozdze drozdze in Drozdze.ListaDrozdzy)
            {
                comboBox_Drozdze.Items.Add(drozdze.Nazwa);

            }
            if (receptura != null) //Jeżeli wywołany formularz z recepturą w parametrach wypełniamy formularz danymi z receptury
            {
                ListaChmieliReceptura = receptura.ListaChmieluReceptura;
                listaSlodowReceptura = receptura.ListaSlodowReceptura;
                ListaD.Add(receptura.Drozdze_Receptura);
                textBox_Nazwa_Receptury.Text = receptura.Nazwa;
                comboBox_Drozdze.Text = receptura.Drozdze_Receptura.Drozdze.Nazwa;
                numericUpDown1.Value = Convert.ToDecimal(receptura.Drozdze_Receptura.Waga);
                textBox_Obj.Text = receptura.Objetosc.ToString();
                nazwa = receptura.Nazwa;
                styl = receptura.Styl;
                comboBox_styl.Text = receptura.Styl;
                str = receptura.Straty;
                Czy_edytowany = true;
                button_Uwarz.Visible = true;
            }
            Przelicz_Wszystko();


        }

        private void textBox_Nazwa_Receptury_TextChanged(object sender, EventArgs e)
        {
            nazwa = textBox_Nazwa_Receptury.Text;
            Przelicz_Wszystko();
        }

        private void button_Dodaj_Slod_Click(object sender, EventArgs e) //Przycisk wywołując nowe okno do dodania słodu
        {
            Form_Dodawanie_Słodu form_Dodawanie_Słodu = new Form_Dodawanie_Słodu(listaSlodowReceptura);
            form_Dodawanie_Słodu.ShowDialog();


            Przelicz_Wszystko();

        }

        public void Dodaj_slody_do_tabeli()// Funkcja dodające słody do grindView
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listaSlodowReceptura.Count; i++)
            {
                dataGridView1.Rows.Add(Properties.Resources.slodikona, listaSlodowReceptura[i].Slod.Nazwa, listaSlodowReceptura[i].Waga, Math.Round(100 * listaSlodowReceptura[i].Waga / masa_slodu), 1);
            }
        }

        public void Przelicz_Wszystko() // Funkcja wywoływana przy każdym przycisku przelicza BLG,EBC, alkohol, dodaje rzeczy do tabeli
        {
            masa_slodu = 0;
            ibu = 0;
            BLG = Math.Round(Policz_BLG(), 1);
            ebc = Math.Round(Policz_EBC(), 1);
            label_BLG.Text = Convert.ToString(BLG);
            label_EBC.Text = Convert.ToString(ebc);
            pictureBox1.BackColor = EBCtoRGB.GetNearestColor(ebc);

            foreach (Slod_uzytkownika slod in listaSlodowReceptura)
            {
                masa_slodu = masa_slodu + slod.Waga;
            }

            Dodaj_Chmiel_do_tabeli();
            Dodaj_slody_do_tabeli();
            for (int i = 0; i < ListaChmieliReceptura.Count(); i++)
            {
                ibu += Policz_IBU_1_chmielu(ListaChmieliReceptura[i]);
            }
            ibu = Math.Round(ibu, 1);
            label_IBU.Text = Convert.ToString(ibu);
            if (ListaD.Count > 0)
            {
                Final_BLG = Policz_BLG() * (1 - ListaD.Last().Drozdze.Odfermentowanie / 100.0);
            }
            else
            {
                Final_BLG = Policz_BLG() * (1 - 75 / 100.0);
            }


            label_FG.Text = Convert.ToString(Math.Round(Final_BLG, 1));
            alkohol = Math.Round((Receptura.BlgToGravity(Policz_BLG()) - Receptura.BlgToGravity(Final_BLG)) * 131.25, 1);
            label_ABV.Text = Convert.ToString(alkohol);
            Final_BLG = Math.Round(Final_BLG, 1);

            pasekStylu_ABV.BeerValue = alkohol;
            pasekStylu_BLG.BeerValue = BLG;
            pasekStylu_FG.BeerValue = Final_BLG;
            pasekStylu_IBU.BeerValue = ibu;
            pasekStylu_EBC.BeerValue = ebc;
            pasekStylu_EBC.Refresh();
            pasekStylu_ABV.Refresh();
            pasekStylu_FG.Refresh();
            pasekStylu_IBU.Refresh();
            pasekStylu_BLG.Refresh();

        }

        public void Dodaj_Chmiel_do_tabeli() // Funkcja dodające chmiele do grindView
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < ListaChmieliReceptura.Count; i++)
            {
                if (ListaChmieliReceptura[i].Chmielenie == RodzajChmielenia.ChmielNaZimno)
                {
                    dataGridView2.Rows.Add(Properties.Resources.chmielikona, ListaChmieliReceptura[i].Chmiel.Nazwa, ListaChmieliReceptura[i].Waga, ListaChmieliReceptura[i].Dni + " Dni", Math.Round(Policz_IBU_1_chmielu(ListaChmieliReceptura[i]), 1), ListaChmieliReceptura[i].Chmielenie);
                }
                else
                {
                    dataGridView2.Rows.Add(Properties.Resources.chmielikona, ListaChmieliReceptura[i].Chmiel.Nazwa, ListaChmieliReceptura[i].Waga, ListaChmieliReceptura[i].Czas, Math.Round(Policz_IBU_1_chmielu(ListaChmieliReceptura[i]), 1), ListaChmieliReceptura[i].Chmielenie);

                }
            }
        }

        private void button_Dodaj_chmiel_Click(object sender, EventArgs e) //Przycisk wywołując nowe okno do dodania chmielu
        {
            Form_Dodawanie_Chmielu form_Dodawanie_Chmielu = new(ListaChmieliReceptura);
            form_Dodawanie_Chmielu.ShowDialog();

            Przelicz_Wszystko();
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            if (Czy_edytowany)//Jezeli receptura jest edytowana, zmieniamy wartości jej pól
            {
                receptura1.Nazwa = nazwa;
                receptura1.Styl = styl;
                receptura1.ListaChmieluReceptura = ListaChmieliReceptura;
                receptura1.ListaSlodowReceptura = listaSlodowReceptura;
                receptura1.Objetosc = OBJ;
                receptura1.Wydajnosc = Wyd;
                receptura1.Straty = str;
                receptura1.BLG = BLG;
                receptura1.IBU = ibu;
                receptura1.EBC = ebc;
                receptura1.Drozdze_Receptura = ListaD.Last();
                receptura1.Alkohol = alkohol;
                receptura1.Final_BLG = Final_BLG;
                receptura1.Zapisz_Recepture();

            }
            else //Jezeli jest nowa, tworzymy nowy obiekt
            {
                Receptura receptura = new(nazwa, styl, ListaChmieliReceptura, listaSlodowReceptura, OBJ, Wyd, str, BLG, ibu, ebc, ListaD.Last(), alkohol, Final_BLG);
                Receptura.ListaReceptur.Add(receptura);
                receptura.Zapisz_Recepture();

            }

            this.Close();
        }

        private void textBox_Obj_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_Obj.Text, out double result1))
            {
                OBJ = result1;
            }
            else
            {
                textBox_Obj.Text = textBox_Obj.Text.Replace(".", ",");
                if (double.TryParse(textBox_Obj.Text, out double rezult1))
                {
                    OBJ = rezult1;
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu Objetości");
                    return;
                }
            }
            
            Przelicz_Wszystko();
        }



        public double Policz_BLG()
        {
            double wynik = 0.0D;
            foreach (Slod_uzytkownika element in listaSlodowReceptura)
            {
                wynik = wynik + element.Slod.Wydajnosc * element.Waga / 100;
            }
            return wynik * Wyd * 100 / (100 * (OBJ + str));
        }


        public double Policz_EBC()
        {

            double MCU = 0.0;
            double SRM = 0.0;
            foreach (Slod_uzytkownika element in listaSlodowReceptura)
            {
                MCU = MCU + element.Waga * element.Slod.EBC / 1.97;
            }
            MCU = MCU * 8.3454 / (OBJ + str);
            SRM = 1.4922 * Math.Pow(MCU, 0.6859);

            return SRM * 1.97;

        }
        //public double Policz_Final_BLG()  // Logika nakazuje myśleć że Final Gravity = Cukry niefermentowalne + Cukry_Fermentowalne * Odfermentowanie drozdzy .
        //{                                 // Niestety nie wiadomo czemu tak nie jest, nigdzie w internecie nikt nie podaje wzoru jak użyć fermentowalność słodów, piszą tylko że coś takiego istnieje i tyle
        //    double wynik=0.0;             //Wyniki wyrzucane przez tą funkcje były mocno zawyżone.
        //    double cukry_fermentowalne = 0.0;
        //    foreach (Slod_uzytkownika element in listaSlodowReceptura)
        //    {
        //        wynik = wynik + (element.Slod.Wydajnosc/100) * element.Waga*(1-element.Slod.Fermentowalnosc / 100);//Liczymy ile jest cukrow niefermentowalnych
        //        cukry_fermentowalne = cukry_fermentowalne + element.Waga * (element.Slod.Wydajnosc/100) *element.Slod.Fermentowalnosc /100;
        //    }

        //    if (ListaD.Count > 0)
        //    {
        //        wynik = wynik + cukry_fermentowalne * (1 - (double)ListaD.Last().Drozdze.Odfermentowanie / 100.0);
        //    }
        //    else
        //    {
        //        wynik = wynik + cukry_fermentowalne * (1 - 70.0 / 100.0);
        //    }
        //    return wynik * Wyd * 100.0 / (100.0 * (OBJ + str));


        //}

        public double Policz_IBU_1_chmielu(Chmiel_uzytkownika chmiel)
        {
            double wynik = 0.0;
            if (chmiel.Chmielenie == RodzajChmielenia.Gotowanie)
            {
                double ekstraktywnosc = 1.65 * Math.Pow(0.000125, Receptura.BlgToGravity(BLG) - 1) * (1 - Math.Exp(-0.04 * chmiel.Czas)) / 4.15;
                wynik = chmiel.Waga * ekstraktywnosc * chmiel.Chmiel.AlfaKwasy * (10 / OBJ);
            }

            return wynik;
        }

        private void comboBox_Drozdze_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Drozdze drozdze in Drozdze.ListaDrozdzy)
            {
                if (drozdze.Nazwa == comboBox_Drozdze.Items[comboBox_Drozdze.SelectedIndex].ToString())
                {
                    Drozdze_uzytkownika Drozdze_uz = new(Convert.ToDouble(numericUpDown1.Value), 0, drozdze);
                    ListaD.Add(Drozdze_uz);

                }
            }
            Przelicz_Wszystko();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (ListaD.Count > 0)
            {
                ListaD.Last().Waga = Convert.ToDouble(numericUpDown1.Value);
            }
        }

        private void Form_Dodaj_Recepture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Magazyn.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            List<string> ListaStringDoprzekazania = new();
            List<double> ListaDoubleDoprzekazania = new();
            ListaDoubleDoprzekazania.Add(listaSlodowReceptura[e.RowIndex].Waga);
            ListaDoubleDoprzekazania.Add(listaSlodowReceptura[e.RowIndex].Cena);
            ListaStringDoprzekazania.Add(listaSlodowReceptura[e.RowIndex].Slod.Nazwa);
            Edycja_Magazyn edycja_Slodu = new Edycja_Magazyn(ListaStringDoprzekazania, ListaDoubleDoprzekazania, "Slod", true);




            edycja_Slodu.ShowDialog();
            if (edycja_Slodu.DialogResult == DialogResult.OK)
            {
                listaSlodowReceptura[e.RowIndex].Waga = ListaDoubleDoprzekazania[0];
                listaSlodowReceptura[e.RowIndex].Cena = ListaDoubleDoprzekazania[1];
            }
            else if (edycja_Slodu.DialogResult == DialogResult.No)
            {
                listaSlodowReceptura.Remove(listaSlodowReceptura[e.RowIndex]);
            }
            Przelicz_Wszystko();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            List<string> ListaStringDoprzekazania = new();
            List<double> ListaDoubleDoprzekazania = new();
            ListaDoubleDoprzekazania.Add(ListaChmieliReceptura[e.RowIndex].Waga);
            ListaStringDoprzekazania.Add(ListaChmieliReceptura[e.RowIndex].Chmiel.Nazwa);
            Edycja_Magazyn edycja_Slodu = new Edycja_Magazyn(ListaStringDoprzekazania, ListaDoubleDoprzekazania, "Chmiel", true);




            edycja_Slodu.ShowDialog();
            if (edycja_Slodu.DialogResult == DialogResult.OK)
            {
                ListaChmieliReceptura[e.RowIndex].Waga = ListaDoubleDoprzekazania[0];
            }
            else if (edycja_Slodu.DialogResult == DialogResult.No)
            {
                ListaChmieliReceptura.Remove(ListaChmieliReceptura[e.RowIndex]);
            }
            Przelicz_Wszystko();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button_Uwarz_Click(object sender, EventArgs e)
        {
            receptura1.Nazwa = nazwa;
            receptura1.Styl = styl;
            receptura1.ListaChmieluReceptura = ListaChmieliReceptura;
            receptura1.ListaSlodowReceptura = listaSlodowReceptura;
            receptura1.Objetosc = OBJ;
            receptura1.Wydajnosc = Wyd;
            receptura1.Straty = str;
            receptura1.BLG = BLG;
            receptura1.IBU = ibu;
            receptura1.EBC = ebc;
            receptura1.Drozdze_Receptura = ListaD.Last();
            receptura1.Alkohol = alkohol;
            receptura1.Final_BLG = Final_BLG;
            receptura1.Zapisz_Recepture();


            this.Hide();
            Warka_form warka_Form = new Warka_form(receptura1, Magazyn);
            warka_Form.Show();
        }

        private void comboBox_styl_SelectedIndexChanged(object sender, EventArgs e)
        {
            styl=comboBox_styl.Text;
            WczytajStyl(styl);
            Przelicz_Wszystko();
        }
        private void WczytajStyl(string nazwa)
        {
            foreach(Styl styl in Styl.ListaStylow)
            {
                if(styl.Nazwa == nazwa)
                {
                    pasekStylu_ABV.StyleMin = styl.ABV_min;
                    pasekStylu_ABV.StyleMax = styl.ABV_max;
                    pasekStylu_BLG.StyleMax = styl.BLG_max;
                    pasekStylu_BLG.StyleMin = styl.BLG_min;
                    pasekStylu_EBC.StyleMin = styl.EBC_min;
                    pasekStylu_EBC.StyleMax = styl.EBC_max;
                    pasekStylu_FG.StyleMax=styl.FG_max;
                    pasekStylu_FG.StyleMin=styl.FG_min;
                    pasekStylu_IBU.StyleMin=styl.IBU_min;
                    pasekStylu_IBU.StyleMax=styl.IBU_max;
                    break;
                }
            }
        }
    }

}
