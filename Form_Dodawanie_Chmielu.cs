namespace Projekt_Piwowar
{
    public partial class Form_Dodawanie_Chmielu : Form
    {
        List<Chmiel_uzytkownika> ListaChmielu;
        public Form_Dodawanie_Chmielu(List<Chmiel_uzytkownika> Lc)
        {
            ListaChmielu = Lc;
            InitializeComponent();

            foreach (Chmiel chmiel in Chmiel.ListaChmieli)
            {
                comboBox1.Items.Add(chmiel.Nazwa);
            }
            JasnyMotyw.Watermark(textBox_Waga, "Waga");
            JasnyMotyw.Watermark(textBox_Czas, "Czas");
            JasnyMotyw.StyleButton(button_anuluj, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_dodaj, Color.LightGreen, Color.FromArgb(0, 200, 83));
           

        }
        private void button_dodaj_Click(object sender, EventArgs e)
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
            int Czas;
            if (int.TryParse(textBox_Czas.Text, out int result1))
            {
                Czas = result1;
            }
            else
            {
                
                MessageBox.Show("Błąd przy dodawaniu Czasu");
                return;
                
            }
            foreach (Chmiel element in Chmiel.ListaChmieli)
            {
                if (element.Nazwa == comboBox1.Items[comboBox1.SelectedIndex].ToString())
                {
                    if (comboBox_rodzajchmielenia.SelectedIndex == 1)
                    {
                        Chmiel_uzytkownika chmiel = new(Waga, 0, element);
                        chmiel.Chmielenie = RodzajChmielenia.ChmielNaZimno;
                        chmiel.Dni = Czas;
                        ListaChmielu.Add(chmiel);
                    }
                    else if (comboBox_rodzajchmielenia.SelectedIndex == 0)
                    {
                        Chmiel_uzytkownika chmiel = new(Waga, 0, element);
                        chmiel.Chmielenie = RodzajChmielenia.Gotowanie;
                        chmiel.Czas = Czas;
                        ListaChmielu.Add(chmiel);
                    }
                    else if (comboBox_rodzajchmielenia.SelectedIndex == 2)
                    {
                        Chmiel_uzytkownika chmiel = new(Waga, 0, element);
                        chmiel.Chmielenie = RodzajChmielenia.HopStand;
                        chmiel.Czas = Czas;
                        ListaChmielu.Add(chmiel);
                    }



                }

            }
            this.Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }
        }

        private void button_dodaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_dodaj.PerformClick();
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox_rodzajchmielenia_Enter(object sender, EventArgs e)
        {
            comboBox_rodzajchmielenia.DroppedDown = true;
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

        private void textBox_Czas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                JasnyMotyw.NastepnaKontrolka(sender, e, this);
            }
            else
            {
                JasnyMotyw.PrzyciskZmieniajacyWatermark(textBox_Czas, "Czas", e);
            }
        }

        private void textBox_Czas_TextChanged(object sender, EventArgs e)
        {
            JasnyMotyw.Watermark(textBox_Czas, "Czas");
        }

        private void textBox_Waga_TextChanged(object sender, EventArgs e)
        {
            JasnyMotyw.Watermark(textBox_Waga, "Waga");
        }
    }
}
