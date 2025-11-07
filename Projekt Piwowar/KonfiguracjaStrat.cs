using Biblioteka_Klas_Piwowar;
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
    public partial class KonfiguracjaStrat : Form
    {
        Form Form;
        public KonfiguracjaStrat(Form form)
        {
            Form = form;
            InitializeComponent();
            JasnyMotyw.StyleButton(button_anuluj, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_Zapisz, Color.LightBlue, Color.DeepSkyBlue);
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button_Zapisz_Click(object sender, EventArgs e)
        {
            this.Close();
            DaneAplikacji.Straty_Chlodzenie = Convert.ToDouble(textBox_stratychlodzenia.Text);
            DaneAplikacji.Straty_Fermentator = Convert.ToDouble(textBox_stratyfermentator.Text);
            DaneAplikacji.Straty_Ogolem = DaneAplikacji.Straty_Chlodzenie + DaneAplikacji.Straty_Fermentator;
            DaneAplikacji.Zapisz();

        }

        private void KonfiguracjaStrat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Show();
        }
    }
}
