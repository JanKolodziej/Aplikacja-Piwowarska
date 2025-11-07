using Biblioteka_Klas_Piwowar;

namespace Projekt_Piwowar
{
    public partial class Moje_Receptury : Form
    {
        Form_Magazyn Magazyn;
        public Moje_Receptury(Form_Magazyn magazyn)
        {
            Magazyn = magazyn;
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach (Receptura receptura in Receptura.ListaReceptur)
            {

                dataGridView1.Rows.Add(EBCtoRGB.UtworzProbeKoloru(EBCtoRGB.GetNearestColor(receptura.EBC)), receptura.Nazwa, receptura.Styl, receptura.Alkohol, receptura.BLG, receptura.Final_BLG);
            }
            JasnyMotyw.StyleGridLight(dataGridView1);
            JasnyMotyw.StyleForm(this);
            JasnyMotyw.StyleButton(button_anuluj, Color.RosyBrown, Color.IndianRed);
        }


        private void Moje_Receptury_FormClosed(object sender, FormClosedEventArgs e)
        {
            Magazyn.Show();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Form_Dodaj_Recepture form_Dodaj_Recepture = new(Magazyn, Receptura.ListaReceptur[e.RowIndex]);
                form_Dodaj_Recepture.Show();
                this.Hide();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Magazyn.Show();
        }
    }
}
