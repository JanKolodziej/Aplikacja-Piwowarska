using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Piwowar
{
    /// <summary>
    /// Zawiera elementy graficzne programu
    /// </summary>
   public static class JasnyMotyw
    { 
        /// <summary>
        /// Ustala kolory forms-a
        /// </summary>
        /// <param name="form"></param>
        public static void StyleForm(Form form)
        {
            form.BackColor = Color.WhiteSmoke;
            form.ForeColor = Color.Black;
        }
        /// <summary>
        /// Ustawia kolory datagrdidview
        /// </summary>
        /// <param name="grid"></param>
        public static void StyleGridLight(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.EnableHeadersVisualStyles = false;
            

            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        //
        public static void StyleButton(RoundedButton btn, Color baseColor, Color hoverColor)
        {
            btn.BackColor = baseColor;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = baseColor;
        }
        public static void Watermark(TextBox textBox, string tekst)
        {
            if (textBox.Text.Length == 0)
            {
                textBox.Text = tekst;
                textBox.ForeColor = Color.LightSlateGray;
            }
            else
            {
                textBox.ForeColor = Color.Black;
            }
        }
        public static void PrzyciskZmieniajacyWatermark(TextBox textBox,string tekst, KeyEventArgs e)
        {
            if (textBox.Text == tekst)
            {
                textBox.Text = ((char)e.KeyValue).ToString();
                e.Handled = true;
                e.SuppressKeyPress = true;
                textBox.SelectionStart = 1;
            }
        }
        public static void NastepnaKontrolka(object sender, KeyEventArgs e,Form form)
        {
            form.SelectNextControl((Control)sender, true, true, true, true);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

       
    }
}
