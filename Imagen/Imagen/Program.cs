using System.Drawing;
using System.Security.Cryptography;

namespace Imagen
{
    class Program
    {
        // Devuelve la distancia entre dos puntos
        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt(vx * vx + vy * vy);
        }

        public static void FillImage(Bitmap bitmap, Color color)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    bitmap.SetPixel(x, y, color);
                }
            }
        }

        public static void FillCircle(Bitmap bm, Color color, double centerx, double centery, double radius)
        {
            // Vamos a poner un círculo
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (GetDistance2D(centerx, centery, x, y) < radius)
                    {
                        bm.SetPixel(x, y, color);
                    }
                }
            }
        }

        public static void PaintRomanFace(Bitmap bm)
        {
            FillImage(bm, Color.White);
            FillCircle(bm, Color.Black, 249, 149, 90);
            FillCircle(bm, Color.LightPink, 249, 149, 85);
            FillCircle(bm, Color.Black, 224, 124, 5);
            FillCircle(bm, Color.Black, 284, 124, 5);
            FillCircle(bm, Color.Blue, 290, 124, 10);
            FillCircle(bm, Color.Blue, 230, 124, 10);


        }

        public static void PaintJapaneseFlag(Bitmap bm)
        {
            FillImage(bm, Color.White);

            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (x == 0 || y == 0 || x == (bm.Width) - 1 || y == (bm.Height) - 1)
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
            }

            FillCircle(bm, Color.Red, 249.0, 149.0, 65.0);
        }
        
        static void Main(string[] args)
        {
            Bitmap bitmap1 = new Bitmap(500, 500);

            //PaintJapaneseFlag(bitmap1);

            PaintRomanFace(bitmap1);

            bitmap1.Save("C:\\Users\\wollo19775\\Desktop\\repos\\imagen1.png");
        }
    }
}
