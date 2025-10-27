using System.Diagnostics;

namespace Projekt_Piwowar
{
    public partial class MojeWarki : Form
    {
        bool Przejscie_Dalej = false;

        Form_Magazyn Magazyn;
        public MojeWarki(Form_Magazyn magazyn)
        {
            Magazyn = magazyn;
            InitializeComponent();
            dataGridView1.RowPrePaint += Dgv_RowPrePaint;
            dataGridView1.CellPainting += Dgv_CellPainting;

            // dodaj nagłówek grupy
            AddHeaderRow("Planowanie");
            Dodaj_Dany_typ(EtapWarki.Planowanie);
            AddHeaderRow("Fermentacja");
            Dodaj_Dany_typ(EtapWarki.Fermentacja);
            AddHeaderRow("Nagazowywanie");
            Dodaj_Dany_typ(EtapWarki.Nagazowanie);
            AddHeaderRow("Gotowe");
            Dodaj_Dany_typ(EtapWarki.Gotowe);
            AddHeaderRow("Archiwum");
            Dodaj_Dany_typ(EtapWarki.Zarchiwizowane);
            StyleGridLight(dataGridView1);


            JasnyMotyw.StyleButton(button1, Color.RosyBrown, Color.IndianRed);
            JasnyMotyw.StyleForm(this);

            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        /// <summary>
        /// Dodaje Do tabeli Warki o zadanym etapie warzenia
        /// </summary>
        /// <param name="etap"></param>
        public void Dodaj_Dany_typ(EtapWarki etap)
        {
            for (int i = Warka.ListaWarek.Count() - 1; i >= 0; i--)
            {
                if (Warka.ListaWarek[i].Etap == etap)
                {
                    double Abv;
                    double BLG;
                    int Dni = 0;
                    switch (etap)
                    {
                        case EtapWarki.Fermentacja:
                            Dni = (DateTime.Now - Warka.ListaWarek[i].DataWarzenia.ToDateTime(TimeOnly.MinValue)).Days;
                            break;
                        case EtapWarki.Nagazowanie:
                            Dni = (DateTime.Now - Warka.ListaWarek[i].DataButelkowania.ToDateTime(TimeOnly.MinValue)).Days;
                            break;
                        case EtapWarki.Gotowe:
                            Dni = (DateTime.Now - Warka.ListaWarek[i].DataGotowe.ToDateTime(TimeOnly.MinValue)).Days;
                            break;


                    }




                    if (Warka.ListaWarek[i].FaktABV != 0.0)
                    {
                        Abv = Warka.ListaWarek[i].FaktABV;
                    }
                    else { Abv = Warka.ListaWarek[i].receptura.Alkohol; }

                    if (Warka.ListaWarek[i].FaktBLG != 0.0)
                    {
                        BLG = Warka.ListaWarek[i].FaktBLG;
                    }
                    else
                    {
                        BLG = Warka.ListaWarek[i].receptura.BLG;
                    }

                    dataGridView1.Rows.Add(Warka.ListaWarek[i].NumerWarki, EBCtoRGB.UtworzProbeKoloru(EBCtoRGB.GetNearestColor(Warka.ListaWarek[i].receptura.EBC)),
                        Warka.ListaWarek[i].receptura.Nazwa, Warka.ListaWarek[i].receptura.Styl, Abv, BLG, Dni);
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if ((string)dataGridView1.Rows[e.RowIndex].Tag != "HEADER")
                {
                    int numer = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    foreach (Warka warka in Warka.ListaWarek)
                    {
                        if (warka.NumerWarki == numer)
                        {
                            Warka_form warka_Form = new(warka.receptura, Magazyn, warka);
                            warka_Form.Show();
                            Przejscie_Dalej = true;
                            this.Close();

                            break;

                        }
                    }

                }
            }
        }

        //Poniżej Kod wygenerowany przez Chatgpt
        /// <summary>
        /// Dodaje wiersz-nagłówek (grupę)
        /// </summary>
        /// <param name="title"></param>
        private void AddHeaderRow(string title)
        {
            int idx = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[idx];
            row.Tag = "HEADER";                 // <-- flaga rozpoznawcza
            row.ReadOnly = true;
            row.Height = 28;
            row.Cells[0].Value = title;         // tekst nagłówka trzymamy w pierwszej komórce (nie będzie widoczna, tylko źródło tekstu)
        }

        private void Dgv_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = (DataGridView)sender!;
            var row = dgv.Rows[e.RowIndex];

            if (row.Tag as string == "HEADER")
            {
                e.Handled = true; // przejmujemy pełne rysowanie

                int left = 0; // <-- zaczynamy od lewej krawędzi, zakrywamy też rowHeader
                int width = dgv.RowHeadersWidth + dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
                var rect = new Rectangle(left, e.RowBounds.Top, width, e.RowBounds.Height);

                using var back = new SolidBrush(Color.SteelBlue); // mocniejsze tło
                using var textBrush = new SolidBrush(Color.White);
                using var font = new Font(dgv.Font, FontStyle.Bold);
                using var format = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };

                e.Graphics.FillRectangle(back, rect);

                string title = row.Cells[0].Value?.ToString() ?? "";
                var textRect = new Rectangle(rect.Left + 8, rect.Top, rect.Width - 16, rect.Height);
                e.Graphics.DrawString(title, font, textBrush, textRect, format);
            }
        }

        private void Dgv_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dgv = (DataGridView)sender!;
                if (dgv.Rows[e.RowIndex].Tag as string == "HEADER")
                {
                    e.Handled = true; // nie rysujemy standardowych komórek
                }
            }
        }



        public void StyleGridLight(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.EnableHeadersVisualStyles = false;


        }

        private void MojeWarki_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Przejscie_Dalej)
            {
                Magazyn.Show();
            }

        }

        private int _rowIndex = -1;

        private void usunPozycjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("0");
            Debug.WriteLine(_rowIndex);
            if (_rowIndex >= 0 && dataGridView1.Rows[_rowIndex].Tag as string != "HEADER")
            {
               
                int numer = Convert.ToInt32(dataGridView1.Rows[_rowIndex].Cells[0].Value);
                for (int i = Warka.ListaWarek.Count - 1; i >= 0; i--)
                {
                    Debug.WriteLine("2");
                    if (Warka.ListaWarek[i].NumerWarki == numer)
                        {
                            Potwierdzenie_Usuniecia potwierdzenie_Usuniecia = new();
                            potwierdzenie_Usuniecia.ShowDialog();
                            if (potwierdzenie_Usuniecia.DialogResult == DialogResult.OK)
                            {
                                Warka.ListaWarek.Remove(Warka.ListaWarek[i]);
                                Warka.Zapisz();
                                dataGridView1.Rows.RemoveAt(_rowIndex);
                                _rowIndex = -1;
                                break;
                            }


                        }
                    
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.WriteLine("1");
            if (e.Button == MouseButtons.Right && e.RowIndex>=0 && dataGridView1.Rows[e.RowIndex].Tag as string!="HEADER")
            {
                Debug.WriteLine("1");
                _rowIndex = e.RowIndex;

                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(Cursor.Position);
                

            }
        }
    }
}
