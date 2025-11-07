using Biblioteka_Klas_Piwowar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projekt_Piwowar
{
    public partial class Warka_form : Form
    {

        bool CzyNaMinus = false;
        bool Czyedytowane = false;

        Warka? warka_ = null;
        Form_Magazyn Magazyn1;

        Receptura Receptura_wzorcowa { get; set; }
        public Warka_form(Receptura receptura, Form_Magazyn magazyn, Warka? warka = null)
        {
            Receptura_wzorcowa = receptura;
            Magazyn1 = magazyn;
            InitializeComponent();
            DodajDoTabeli();

            if (warka != null)
            {
                warka_ = warka;
                Czyedytowane = true;
                button_uwarz.Enabled = false;
                textBox_nazwa.Text = warka.Nazwa;
                textBox_numer.Text = warka.NumerWarki.ToString();
                button_uwarz2.Enabled = true;
                if (warka_.Czy_Na_minus == true)
                {
                    checkBox2.Checked = true;
                }
                if (warka_.Czy_Pobrano_Materialy)
                {
                    checkBox1.Checked = true;
                }
                UaktualnijWidok();

                if (warka.DataCichej == DateOnly.MinValue)
                {
                    checkBox3.Checked = false;
                    label_Cicha.Visible = false;
                    dateTimePicker_cicha.Visible = false;
                }
                else
                {
                    checkBox3.Checked = true;
                    label_Cicha.Enabled = true;
                    dateTimePicker_cicha.Enabled = true;
                    dateTimePicker_cicha.Value = warka.DataCichej.ToDateTime(TimeOnly.MinValue);

                }
                if (warka.DataLezakowania == DateOnly.MinValue)
                {
                    checkBox_lagerowanie.Checked = false;
                    label8.Visible = false;
                    dateTimePicker_lezakowanie.Visible = false;
                }
                else
                {
                    checkBox_lagerowanie.Checked = true;
                    label8.Enabled = true;
                    dateTimePicker_lezakowanie.Enabled = true;
                    dateTimePicker_lezakowanie.Value = warka.DataLezakowania.ToDateTime(TimeOnly.MinValue);
                }

                // Ustawienie dataPicker na daty z warki
                dateTimePicker1.Value = warka.DataWarzenia.ToDateTime(TimeOnly.MinValue);
                dateTimePicker_butelka.Value = warka.DataButelkowania.ToDateTime(TimeOnly.MinValue);
                dateTimePicker_gotowe.Value = warka.DataGotowe.ToDateTime(TimeOnly.MinValue);

            }
            else
            {
                textBox_nazwa.Text = receptura.Nazwa;
                textBox_numer.Text = (Warka.ListaWarek.Count() + 1).ToString();
                label_Cicha.Enabled = false;
                dateTimePicker_cicha.Enabled = false;
                dateTimePicker_lezakowanie.Enabled = false;
                button_uwarz2.Enabled = false;
                label8.Enabled = false;
                // Ustawienie dataPicker na domyślne daty tydzien burzliwej-tydzien cichej-butelkowanie-dwa tygodnie refermenctacji- gotowe
                dateTimePicker_cicha.Value = DateTime.Now.AddDays(7);
                dateTimePicker_lezakowanie.Value = DateTime.Now.AddDays(14);
                dateTimePicker_butelka.Value = DateTime.Now.AddDays(14);
                dateTimePicker_gotowe.Value = DateTime.Now.AddDays(28);
                //tabPage Fermentacja
                OG_textbox.Text = receptura.BLG.ToString();
                FG_textbox.Text = receptura.Final_BLG.ToString();
                OBJ_butel_textbox.Text = receptura.Objetosc.ToString();

            }



            //Zmiana kolorów przycisków


            JasnyMotyw.StyleGridLight(dataGridView1);
            JasnyMotyw.StyleButton(button_uwarz, Color.LightBlue, Color.DeepSkyBlue);
            JasnyMotyw.StyleButton(button1, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_uwarz2, Color.LightGreen, Color.FromArgb(0, 200, 83));
            JasnyMotyw.StyleForm(this);

            JasnyMotyw.StyleButton(button_Fermentacja, Color.LightGreen, Color.FromArgb(0, 200, 83));
            JasnyMotyw.StyleButton(button3, Color.RosyBrown, Color.IndianRed);

            JasnyMotyw.StyleButton(EtapNaGotowe, Color.LightGreen, Color.FromArgb(0, 200, 83));
            JasnyMotyw.StyleButton(Fermentacja_Wyjdz, Color.RosyBrown, Color.IndianRed);

            JasnyMotyw.StyleButton(Archiwum_button, Color.LightGreen, Color.FromArgb(0, 200, 83));
            JasnyMotyw.StyleButton(button2, Color.RosyBrown, Color.IndianRed);
        }




        private void UaktualnijWidok()
        {
            Planowanie.Enabled = (warka_.Etap == EtapWarki.Planowanie);
            Warzenie.Enabled = (warka_.Etap == EtapWarki.Warzenie);
            Fermentacja.Enabled = (warka_.Etap == EtapWarki.Fermentacja);
            Gotowe.Enabled = (warka_.Etap == EtapWarki.Gotowe);

            switch (warka_.Etap)
            {
                case EtapWarki.Planowanie:
                    tabControl1.SelectedTab = Planowanie;
                    break;
                case EtapWarki.Warzenie:
                    tabControl1.SelectedTab = Warzenie;
                    break;
                case EtapWarki.Fermentacja:
                    tabControl1.SelectedTab = Fermentacja;
                    break;
                case EtapWarki.Gotowe:
                    tabControl1.SelectedTab = Gotowe;
                    break;
            }
        }

        public void DodajDoTabeli()
        {
            dataGridView1.Rows.Clear();
            foreach (Slod_uzytkownika slod in Receptura_wzorcowa.ListaSlodowReceptura)
            {
                bool Czy_istnieje2 = Slod_uzytkownika.ListaSlodowUzytkownika.Exists(p => p.Slod == slod.Slod); //Sprawdzamy czy Dany slod jest w magazynie
                if (Czy_istnieje2)
                {
                    foreach (Slod_uzytkownika slod_uz in Slod_uzytkownika.ListaSlodowUzytkownika)
                    {

                        if (slod.Slod.Nazwa == slod_uz.Slod.Nazwa)
                        {
                            dataGridView1.Rows.Add(Properties.Resources.slodikona, slod.Slod.Nazwa, slod.Waga, slod_uz.Waga);

                        }

                    }
                }
                else
                {
                    dataGridView1.Rows.Add(Properties.Resources.slodikona, slod.Slod.Nazwa, slod.Waga, 0.0);
                }

            }
            foreach (Chmiel_uzytkownika chmiel in Receptura_wzorcowa.ListaChmieluReceptura)
            {
                bool Czy_istnieje1 = Chmiel_uzytkownika.ListaChmieluUzytkownika.Exists(p => p.Chmiel == chmiel.Chmiel); //Sprawdzamy czy Dany chmiel jest w magazynie
                if (Czy_istnieje1)
                {
                    foreach (Chmiel_uzytkownika chmiel_uz in Chmiel_uzytkownika.ListaChmieluUzytkownika)
                    {

                        if (chmiel.Chmiel.Nazwa == chmiel_uz.Chmiel.Nazwa)
                        {
                            dataGridView1.Rows.Add(Properties.Resources.chmielikona, chmiel.Chmiel.Nazwa, chmiel.Waga, chmiel_uz.Waga);

                        }

                    }
                }
                else
                {
                    dataGridView1.Rows.Add(Properties.Resources.chmielikona, chmiel.Chmiel.Nazwa, chmiel.Waga, 0.0);
                }



            }
            bool Czy_istnieje = Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Exists(p => p.Drozdze == Receptura_wzorcowa.Drozdze_Receptura.Drozdze);
            if (Czy_istnieje)
            {
                foreach (Drozdze_uzytkownika drozdze in Drozdze_uzytkownika.ListaDrozdzyUzytkownika)
                {
                    if (drozdze.Drozdze == Receptura_wzorcowa.Drozdze_Receptura.Drozdze)
                    {
                        dataGridView1.Rows.Add(Properties.Resources.drodzeikonka, Receptura_wzorcowa.Drozdze_Receptura.Drozdze.Nazwa, Receptura_wzorcowa.Drozdze_Receptura.Waga, drozdze.Waga);
                    }
                }
            }
            else
            {
                dataGridView1.Rows.Add(Properties.Resources.drodzeikonka, Receptura_wzorcowa.Drozdze_Receptura.Drozdze.Nazwa, Receptura_wzorcowa.Drozdze_Receptura.Waga, 0.0);
            }
        }
        public void ZabierzZMagazynu()
        {
            if (checkBox2.Checked)
            {
                CzyNaMinus = true;
            }
            foreach (Slod_uzytkownika slod in Receptura_wzorcowa.ListaSlodowReceptura)
            {
                bool Czy_istnieje = Slod_uzytkownika.ListaSlodowUzytkownika.Exists(p => p.Slod == slod.Slod); //Sprawdzamy czy Dany slod jest w magazynie
                if (Czy_istnieje)
                {
                    for (int i = 0; i < Slod_uzytkownika.ListaSlodowUzytkownika.Count; i++)
                    {

                        if (slod.Slod.Nazwa == Slod_uzytkownika.ListaSlodowUzytkownika[i].Slod.Nazwa)
                        {

                            double nowa_waga;
                            nowa_waga = Math.Round(Slod_uzytkownika.ListaSlodowUzytkownika[i].Waga - slod.Waga, 3);
                            if (nowa_waga > 0 || nowa_waga < 0 && CzyNaMinus)
                            {
                                Slod_uzytkownika.ListaSlodowUzytkownika[i].Waga = nowa_waga;
                            }
                            else if (nowa_waga == 0 || (nowa_waga < 0 && !CzyNaMinus))
                            {
                                Slod_uzytkownika.ListaSlodowUzytkownika.Remove(Slod_uzytkownika.ListaSlodowUzytkownika[i]);
                                i--;
                            }

                        }

                    }
                }
                else if (CzyNaMinus)
                {
                    Slod_uzytkownika slod_ = new(-slod.Waga, 0, slod.Slod);
                    Slod_uzytkownika.ListaSlodowUzytkownika.Add(slod_);
                }

                foreach (Chmiel_uzytkownika Chmiel in Receptura_wzorcowa.ListaChmieluReceptura)
                {
                    bool Czy_istnieje1 = Receptura_wzorcowa.ListaChmieluReceptura.Exists(p => p.Chmiel == Chmiel.Chmiel); //Sprawdzamy czy Dany slod jest w magazynie
                    if (Czy_istnieje1)
                    {
                        for (int i = 0; i < Chmiel_uzytkownika.ListaChmieluUzytkownika.Count; i++)
                        {

                            if (Chmiel.Chmiel.Nazwa == Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Chmiel.Nazwa)
                            {

                                double nowa_waga;
                                nowa_waga = Math.Round(Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Waga - Chmiel.Waga, 3);
                                if (nowa_waga > 0 || nowa_waga < 0 && CzyNaMinus)
                                {
                                    Chmiel_uzytkownika.ListaChmieluUzytkownika[i].Waga = nowa_waga;
                                }
                                else if (nowa_waga == 0 || (nowa_waga < 0 && !CzyNaMinus))
                                {
                                    Chmiel_uzytkownika.ListaChmieluUzytkownika.Remove(Chmiel_uzytkownika.ListaChmieluUzytkownika[i]);
                                    i--;
                                }

                            }

                        }
                    }
                    else if (CzyNaMinus)
                    {
                        Chmiel_uzytkownika chmiel_ = new(-Chmiel.Waga, 0, Chmiel.Chmiel);
                        Chmiel_uzytkownika.ListaChmieluUzytkownika.Add(chmiel_);
                    }
                    Slod_uzytkownika.Zmien_wartosci_w_pliku();
                    Chmiel_uzytkownika.Zmien_wartosci_w_pliku();
                    Drozdze_uzytkownika.Zmien_wartosci_w_pliku();

                }

                bool Czy_istnieje2 = Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Exists(p => p.Drozdze == Receptura_wzorcowa.Drozdze_Receptura.Drozdze);
                if (Czy_istnieje2)
                {
                    for (int i = 0; i < Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Count; i++)
                    {
                        if (Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Drozdze == Receptura_wzorcowa.Drozdze_Receptura.Drozdze)
                        {
                            double nowa_waga;
                            nowa_waga = Math.Round(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Waga - Receptura_wzorcowa.Drozdze_Receptura.Waga, 3);
                            if (nowa_waga > 0 || nowa_waga < 0 && CzyNaMinus)
                            {
                                Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i].Waga = nowa_waga;
                            }
                            else if (nowa_waga == 0 || (nowa_waga < 0 && !CzyNaMinus))
                            {
                                Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Remove(Drozdze_uzytkownika.ListaDrozdzyUzytkownika[i]);
                                i--;
                            }
                        }
                    }
                }
                else if (CzyNaMinus)
                {
                    Drozdze_uzytkownika drozdze_ = new(Receptura_wzorcowa.Drozdze_Receptura.Waga, 0, Receptura_wzorcowa.Drozdze_Receptura.Drozdze);
                    Drozdze_uzytkownika.ListaDrozdzyUzytkownika.Add(drozdze_);
                }

            }
        }


        //Przycisk Zaplanuj
        private void button_uwarz_Click(object sender, EventArgs e)
        {
            if (Czyedytowane)
            {
                warka_.Nazwa = textBox_nazwa.Text;
                warka_.NumerWarki = Convert.ToInt32(textBox_numer.Text);
                warka_.DataWarzenia = DateOnly.FromDateTime(dateTimePicker1.Value);
                warka_.DataButelkowania = DateOnly.FromDateTime(dateTimePicker_butelka.Value);
                if (checkBox3.Checked)
                {
                    warka_.DataCichej = DateOnly.FromDateTime(dateTimePicker_cicha.Value);
                }
                if (checkBox_lagerowanie.Checked)
                {
                    warka_.DataLezakowania = DateOnly.FromDateTime(dateTimePicker_lezakowanie.Value);

                }


            }
            else
            {
                DateOnly datalezakowania = DateOnly.FromDateTime(dateTimePicker_lezakowanie.Value);
                DateOnly datacichej = DateOnly.FromDateTime(dateTimePicker_cicha.Value);

                if (!checkBox_lagerowanie.Checked)
                {
                    datalezakowania = DateOnly.MinValue;
                }
                if (!checkBox3.Checked)
                {
                    datacichej = DateOnly.MinValue;
                }

                Warka warka = new(Receptura_wzorcowa, textBox_nazwa.Text, Convert.ToInt32(textBox_numer.Text), DateOnly.FromDateTime(dateTimePicker1.Value), DateOnly.FromDateTime(dateTimePicker_butelka.Value),
                    DateOnly.FromDateTime(dateTimePicker_gotowe.Value), datacichej, datalezakowania);

                warka_ = warka;
                Warka.ListaWarek.Add(warka);

                warka.Etap = EtapWarki.Planowanie;
            }

            if (!warka_.Czy_Pobrano_Materialy && checkBox1.Checked)
            {
                warka_.Czy_Pobrano_Materialy = true;
                ZabierzZMagazynu();
                if (checkBox2.Checked)
                {
                    warka_.Czy_Na_minus = true;
                }


            }
            Warka.Zapisz();
            if (checkBox4.Checked) //Jezeli uzytkownik zaznaczył dodajemy wydarzenia do Kalendarza Google
            {

                try
                {
                    Dodaj_Warzenie_Kalendarz();
                    GoogleCalendarHelper.DodajWydarzenie("Butelkowanie " + Receptura_wzorcowa.Nazwa, "Zabutelkować Piwo", warka_.DataButelkowania);
                    GoogleCalendarHelper.DodajWydarzenie("Gotowe " + Receptura_wzorcowa.Nazwa, "Wypić Piwo :]", warka_.DataGotowe);

                    if (checkBox3.Checked)
                    {
                        warka_.DataCichej = DateOnly.FromDateTime(dateTimePicker_cicha.Value);
                        GoogleCalendarHelper.DodajWydarzenie("Cicha " + Receptura_wzorcowa.Nazwa, "Przelać Piwo na Cichą Fermentajce", warka_.DataCichej);

                    }
                    if (checkBox_lagerowanie.Checked)
                    {
                        warka_.DataLezakowania = DateOnly.FromDateTime(dateTimePicker_lezakowanie.Value);
                        GoogleCalendarHelper.DodajWydarzenie("Leżakowanie " + Receptura_wzorcowa.Nazwa, "Przelać Piwo na Leżakowanie", warka_.DataLezakowania);

                    }
                    MessageBox.Show("Udało się wszystko dodać do kalendarza :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bład przy dodawaniu warzenia do kalendarze " + ex.Message);
                }

            }
            MojeWarki mojeWarki = new(Magazyn1);
            mojeWarki.Show();
            this.Close();


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (!checkBox3.Checked)
            {
                label_Cicha.Enabled = false;
                dateTimePicker_cicha.Enabled = false;
            }
            else
            {
                if (!Czyedytowane)
                {
                    label_Cicha.Enabled = true;
                    dateTimePicker_cicha.Enabled = true;
                }
                else
                {
                    label_Cicha.Visible = true;
                    dateTimePicker_cicha.Visible = true;
                    label_Cicha.Enabled = true;
                    dateTimePicker_cicha.Enabled = true;
                }

            }
        }

        private void checkBox_lagerowanie_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_lagerowanie.Checked)
            {
                dateTimePicker_lezakowanie.Enabled = false;
                label8.Enabled = false;

            }
            else
            {
                if (!Czyedytowane)
                {
                    dateTimePicker_lezakowanie.Enabled = true;
                    label8.Enabled = true;
                }
                else
                {
                    label8.Visible = true;
                    label8.Enabled = true;
                    dateTimePicker_lezakowanie.Enabled = true;
                    dateTimePicker_lezakowanie.Visible = true;

                }
            }
        }





        private void Dodaj_Warzenie_Kalendarz()
        {
            string opis = "";
            opis += "Objętość: " + Receptura_wzorcowa.Objetosc + " L" + "\n";
            opis += "Gęstość Początkowa: " + Receptura_wzorcowa.BLG + " BLG" + "\n";
            opis += "\nSkładniki fermentujące: \n ";

            foreach (Slod_uzytkownika slod in Receptura_wzorcowa.ListaSlodowReceptura)
            {
                opis += $"{slod.Slod.Nazwa,-15} {slod.Waga,4:0.00} {"kg",2}\n";

            }

            opis += "\nChmiele:\n ";

            string Chmiele_na_Zimno = "\n Chmiele na Zimno \n";
            string HopStand = "\n Hop Stand \n";
            for (int i = 0; i < Receptura_wzorcowa.ListaChmieluReceptura.Count; i++)
            {
                if (Receptura_wzorcowa.ListaChmieluReceptura[i].Chmielenie == RodzajChmielenia.Gotowanie)
                {
                    opis += $"{Receptura_wzorcowa.ListaChmieluReceptura[i].Chmiel.Nazwa,-15} {Receptura_wzorcowa.ListaChmieluReceptura[i].Waga,3} {"g",1} {Receptura_wzorcowa.ListaChmieluReceptura[i].Czas,6} {"min",3}\n";
                }
                else if (Receptura_wzorcowa.ListaChmieluReceptura[i].Chmielenie == RodzajChmielenia.ChmielNaZimno)
                {
                    Chmiele_na_Zimno += $"{Receptura_wzorcowa.ListaChmieluReceptura[i].Chmiel.Nazwa,-15} {Receptura_wzorcowa.ListaChmieluReceptura[i].Waga,3} {"g",1} {Receptura_wzorcowa.ListaChmieluReceptura[i].Dni,6} {"Dni",3}\n";
                }
                else if (Receptura_wzorcowa.ListaChmieluReceptura[i].Chmielenie == RodzajChmielenia.HopStand)
                {
                    HopStand += $"{Receptura_wzorcowa.ListaChmieluReceptura[i].Chmiel.Nazwa,-15} {Receptura_wzorcowa.ListaChmieluReceptura[i].Waga,3} {"g",1} {Receptura_wzorcowa.ListaChmieluReceptura[i].Czas,6} {"min",3}\n";
                }

            }
            opis += Chmiele_na_Zimno;
            opis += HopStand;

            opis += "\n Drozdze\n ";
            opis += Receptura_wzorcowa.Drozdze_Receptura.Drozdze.Nazwa + " " + Receptura_wzorcowa.Drozdze_Receptura.Waga + " opk";

            GoogleCalendarHelper.DodajWydarzenie("Warzenie " + warka_.Nazwa, opis, warka_.DataWarzenia);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            


        }
        //Przycisk zmieniający etap Warki
        private void button_uwarz2_Click(object sender, EventArgs e)
        {
            warka_.Etap = EtapWarki.Warzenie;
            UaktualnijWidok();
            Warka.Zapisz();
        }

        private void Fermentacja_Wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
        //Przyciski Zmieniające Etap
        private void button_Fermentacja_Click(object sender, EventArgs e)
        {
            warka_.Etap = EtapWarki.Fermentacja;
            UaktualnijWidok();
            Warka.Zapisz();
        }

        private void EtapNaGotowe_Click(object sender, EventArgs e)
        {
            warka_.Etap = EtapWarki.Gotowe;
            UaktualnijWidok();
            Warka.Zapisz();
        }

        private void Archiwum_button_Click(object sender, EventArgs e)
        {
            warka_.Etap = EtapWarki.Zarchiwizowane;
            UaktualnijWidok();
            Warka.Zapisz();

        }

        private void Warka_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Czyedytowane)
            {
                MojeWarki mojeWarki = new(Magazyn1);
                mojeWarki.Show();
            }
            else
            {
                Form_Dodaj_Recepture form_Dodaj_Recepture = new(Magazyn1, Receptura_wzorcowa);
                form_Dodaj_Recepture.Show();
            }
        }
    }
}
