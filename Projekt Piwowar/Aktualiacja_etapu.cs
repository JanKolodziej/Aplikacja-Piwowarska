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
    public partial class Aktualiacja_etapu : Form
    {
        
        public Aktualiacja_etapu(Warka warka)
        {
            
            InitializeComponent();
            JasnyMotyw.StyleButton(button_Nie, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_Tak, Color.LightGreen, Color.FromArgb(0, 200, 83));
            label1.Text = "Według planowania powinien się zmienić etap Warki \n" + warka.Nazwa + "-Warka numer: " + warka.NumerWarki+"\n Czy chcesz zmienić etap na: " +(warka.Etap +1)+" ?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button_Nie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
