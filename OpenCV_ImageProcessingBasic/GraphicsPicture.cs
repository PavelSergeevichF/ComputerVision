using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCV_ImageProcessingBasic
{
    internal class GraphicsPicture
    {
        public void DrawGraphics(Graphics graph, Bitmap pictur, int сoefficient)
        {
            Graphics graphics = graph;
            Pen penBlack = new Pen(Color.Black, 3f);
            Pen penR = new Pen(Color.Red, 3f);
            Pen penG = new Pen(Color.Green, 3f);
            Pen penB = new Pen(Color.Blue, 3f);

            Point[] pointsBlack = GraphBleack(pictur, сoefficient);
            Point[] pointsR = Graph(pictur, сoefficient, TypeColor.RED);
            Point[] pointsG = Graph(pictur, сoefficient, TypeColor.GREEN);
            Point[] pointsB = Graph(pictur, сoefficient, TypeColor.BLUE);

            graphics.Clear(Color.White);
            graphics.DrawLines(penBlack, pointsBlack);
            graphics.DrawLines(penR, pointsR);
            graphics.DrawLines(penG, pointsG);
            graphics.DrawLines(penB, pointsB);
        }
        public Point[] GraphBleack(Bitmap pictur, int сoefficient)
        {
            Point[] graph = new Point[512];
            int[] graphInt = new int[256];
            int coint = 0;

            for (int i = 0; i < pictur.Width; i++)
            {
                for (int j = 0; j < pictur.Height; j++)
                {
                    Color c1 = pictur.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int luminance = (int)((r1 + g1 + b1) / 3);
                    graphInt[luminance]++;
                }
            }
            for (int i = 0;i< graphInt.Length;i++)
            {
                int y = 180 - (int)(graphInt[i] / сoefficient)+1;
                graph[coint] = new Point(coint, y);
                graph[coint + 1] = new Point(coint + 1, y);
                coint += 2;
            }
            return graph;
        }

        private Point[] Graph(Bitmap pictur, int сoefficient, TypeColor typeColor)
        {
            Point[] graph = new Point[512];
            int[] graphInt = new int[256];
            int coint = 0;

            for (int i = 0; i < pictur.Width; i++)
            {
                for (int j = 0; j < pictur.Height; j++)
                {
                    Color c1 = pictur.GetPixel(i, j);
                    switch (typeColor)
                    { 
                        case TypeColor.RED:
                            graphInt[c1.R]++;
                            break;
                        case TypeColor.GREEN:
                            graphInt[c1.G]++;
                            break;
                        case TypeColor.BLUE:
                            graphInt[c1.B]++;
                            break;
                    };
                    
                }
            }
            for (int i = 0; i < graphInt.Length; i++)
            {
                int y = 180 - (int)(graphInt[i] / сoefficient) + 1;
                graph[coint] = new Point(coint, y);
                graph[coint + 1] = new Point(coint + 1, y);
                coint += 2;
            }
            return graph;
        }

    }
    enum TypeColor
    {
        RED = 0,
        GREEN = 1,
        BLUE = 2,
    }
}
