using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Piwowar
{
    public partial class Edycja_Magazyn : Form
    {
        List<double> ListaD;
        string Nazwa;
        string Typ;
        bool CzyReceptura;

        public Edycja_Magazyn(List<string> nazwa, List<double> tablicaD, string typ, bool czyReceptura=false)
        {
            Nazwa = nazwa[0];
            ListaD = tablicaD;
            CzyReceptura = czyReceptura;

            Typ = typ;
            InitializeComponent();
            if(czyReceptura&& Typ=="Chmiel")//W przypadku gdy mamy do czynienia z Chmielem i edytujemy zawartość receptury zamiast ceny pojawi nam się czas gotowania
            {

                label2.Text = "Czas";
            }else if(czyReceptura)
            {
                label2.Visible = false;
                textBox_cena.Visible = false;
            }
                label_nazwa.Text = Typ + " " + Nazwa;
            textBox_waga.Text = ListaD[0].ToString();
            textBox_cena.Text = ListaD[1].ToString();
            CzyReceptura = czyReceptura;


            JasnyMotyw.StyleForm(this);
            JasnyMotyw.StyleButton(Anuluj_przycisk, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_usun, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(Zapisz_przycisk, Color.LightBlue, Color.DeepSkyBlue);

        }

        private void Zapisz_przycisk_Click(object sender, EventArgs e)
        {


            ListaD[0] = Convert.ToDouble(textBox_waga.Text);
            ListaD[1] = Convert.ToDouble(textBox_cena.Text);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }


        private void Anuluj_przycisk_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            Potwierdzenie_Usuniecia potwierdzenie_Usuniecia = new Potwierdzenie_Usuniecia();
            potwierdzenie_Usuniecia.ShowDialog();
            if (potwierdzenie_Usuniecia.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.No;

            }

            
        }
    }
}
