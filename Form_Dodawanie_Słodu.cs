namespace Projekt_Piwowar
{
    public partial class Form_Dodawanie_Słodu : Form
    {
        List<Slod_uzytkownika> Listadoprzekazania;
        public Form_Dodawanie_Słodu(List<Slod_uzytkownika> Lista)
        {
            Listadoprzekazania = Lista;
            InitializeComponent();
            foreach (Slod slod in Slod.ListaSlodow)
            {
                comboBox_Nazwa_slodu.Items.Add(slod.Nazwa);
            }
            JasnyMotyw.Watermark(textBox_Waga, "Waga");
            JasnyMotyw.StyleButton(button_anuluj, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_dodaj, Color.LightGreen, Color.FromArgb(0, 200, 83));

        }


        private void button_dodaj_Click_1(object sender, EventArgs e)
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
            foreach (Slod element in Slod.ListaSlodow)
            {
                if (element.Nazwa == comboBox_Nazwa_slodu.Items[comboBox_Nazwa_slodu.SelectedIndex].ToString())
                {
                    Slod_uzytkownika slod = new(Waga, 0, element);
                    Listadoprzekazania.Add(slod);
                }

            }

            this.Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox_Nazwa_slodu_KeyDown(object sender, KeyEventArgs e)
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

        private void button_anuluj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_anuluj.PerformClick();
            }
        }

        private void comboBox_Nazwa_slodu_Enter(object sender, EventArgs e)
        {
            comboBox_Nazwa_slodu.DroppedDown = true;
        }

        private void textBox_Waga_TextChanged(object sender, EventArgs e)
        {
            JasnyMotyw.Watermark(textBox_Waga, "Waga");

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
    }
}
