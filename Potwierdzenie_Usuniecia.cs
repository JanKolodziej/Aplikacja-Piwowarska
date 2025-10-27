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
    public partial class Potwierdzenie_Usuniecia : Form
    {
        public Potwierdzenie_Usuniecia()
        {
            InitializeComponent();
            JasnyMotyw.StyleButton(button_anuluj, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleButton(button_usun, Color.LightGreen, Color.FromArgb(0, 200, 83));
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
