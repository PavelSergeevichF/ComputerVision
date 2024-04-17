using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCV_ImageProcessingBasic
{
    internal class Method
    {
        public Method() { }
        public static bool ConvertToGray(Bitmap b)
        {
            for(int i = 0; i < b.Width; i++) 
            {
                for(int j = 0;  j < b.Height; j++) 
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i,j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }
        public static bool ConvertToNegative(Bitmap b) 
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int a = c1.A;
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    r1 = 255-r1;
                    g1 = 255-g1;
                    b1 = 255-b1;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }
    }
}
