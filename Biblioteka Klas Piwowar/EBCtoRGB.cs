using System.Drawing;

namespace Biblioteka_Klas_Piwowar
{
    public static class EBCtoRGB
    {
        public static readonly Dictionary<int, Color> EbcToColor = new()
    {
        { 2,  Color.FromArgb(255, 241, 181) },
        { 4,  Color.FromArgb(255, 231, 141) },
        { 6,  Color.FromArgb(248, 208, 85) },
        { 8,  Color.FromArgb(241, 190, 60) },
        { 10, Color.FromArgb(233, 174, 41) },
        { 12, Color.FromArgb(221, 155, 30) },
        { 16, Color.FromArgb(202, 123, 26) },
        { 20, Color.FromArgb(190, 98, 23) },
        { 26, Color.FromArgb(167, 77, 24) },
        { 33, Color.FromArgb(138, 54, 15) },
        { 39, Color.FromArgb(119, 40, 11) },
        { 47, Color.FromArgb(98, 28, 5) },
        { 57, Color.FromArgb(76, 23, 5) },
        { 69, Color.FromArgb(56, 19, 6) },
        { 80, Color.FromArgb(41, 14, 4) },
        { 100, Color.FromArgb(24, 12, 5) },
        { 120, Color.FromArgb(10, 10, 10) }
    };

        // (Opcjonalnie) Najbliższy kolor dla dowolnego EBC:
        public static Color GetNearestColor(double ebc)
        {
            int closestKey = EbcToColor.Keys
                .OrderBy(k => Math.Abs(k - ebc))
                .First();

            return EbcToColor[closestKey];
        }
        public static Bitmap UtworzProbeKoloru(Color kolor, int szerokosc = 30, int wysokosc = 15)
        {
            Bitmap bmp = new Bitmap(szerokosc, wysokosc);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(kolor);
            }
            return bmp;
        }
    }
}
