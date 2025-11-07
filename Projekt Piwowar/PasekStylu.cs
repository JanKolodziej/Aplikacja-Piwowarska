using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Piwowar
{
    public class PasekStylu : Control
    {
        public double MinValue { get; set; } = 0;
        public double MaxValue { get; set; } = 100;
        public double StyleMin { get; set; } = 30;
        public double StyleMax { get; set; } = 70;
        public double BeerValue { get; set; } = 50;

        public PasekStylu()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(300, 50);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            MinValue = 0.8 * StyleMin;
            MaxValue = 1.2 * StyleMax;

            double scale = (double)Width / (MaxValue - MinValue);
            int barHeight = 15;
            int y = Height / 2 - barHeight / 2;

            // Pasek bazowy (jasnoszary)
            using (var brush = new SolidBrush(Color.LightGray))
            {
                g.FillRectangle(brush, 0, y, Width, barHeight);
            }

            // Zakres stylu (zielony)
            int styleStart = (int)((StyleMin - MinValue) * scale);
            int styleWidth = (int)((StyleMax - StyleMin) * scale);

            using (var brush = new SolidBrush(Color.LightGreen))
            {
                g.FillRectangle(brush, styleStart, y, styleWidth, barHeight);
            }

            // Wartość piwa (niebieska kreska jeśli w stylu, czerwona jeśli poza)
            bool inRange = BeerValue >= StyleMin && BeerValue <= StyleMax;
            Color valueColor = inRange ? Color.Blue : Color.Red;
            if (inRange)
            {
                int beerX = (int)((BeerValue - MinValue) * scale);
                using (var pen = new Pen(valueColor, 4))
                {
                    g.DrawLine(pen, beerX, y - 5, beerX, y + barHeight + 5);
                }
                // Tekst z aktualną wartością piwa
                string valueText = BeerValue.ToString();
                var textSize = g.MeasureString(valueText, this.Font);
                g.DrawString(valueText, this.Font, Brushes.Black,
                    beerX - textSize.Width / 2, y - textSize.Height - 2);
            }
            else if(BeerValue < MinValue)
            {
                using (var pen = new Pen(valueColor, 4))
                {
                    g.DrawLine(pen, 0, y - 5, 0, y + barHeight + 5);
                }
                // Tekst z aktualną wartością piwa
                string valueText = BeerValue.ToString();
                var textSize = g.MeasureString(valueText, this.Font);
                g.DrawString(valueText, this.Font, Brushes.Black,
                      textSize.Width / 2, y - textSize.Height - 2);
            }
            else if(BeerValue>MaxValue)
            {
                using (var pen = new Pen(valueColor, 4))
                {
                    g.DrawLine(pen, Width, y - 5, Width, y + barHeight + 5);
                }
                // Tekst z aktualną wartością piwa
                string valueText = BeerValue.ToString();
                var textSize = g.MeasureString(valueText, this.Font);
                g.DrawString(valueText, this.Font, Brushes.Black,
                      Width- textSize.Width , y - textSize.Height - 2);

            }
                // Tekst wartości StyleMin i StyleMax
                using (var fontBrush = new SolidBrush(Color.Black))
                {
                    string minText = StyleMin.ToString();
                    string maxText = StyleMax.ToString();

                    g.DrawString(minText, this.Font, fontBrush, styleStart, y + barHeight + 2);
                    g.DrawString(maxText, this.Font, fontBrush, styleStart + styleWidth - g.MeasureString(maxText, this.Font).Width, y + barHeight + 2);
                }

           
        }
    }


}
