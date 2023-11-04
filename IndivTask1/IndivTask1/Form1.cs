using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndivTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gr.Clear(Color.White);
        }

        static Bitmap bmp = new Bitmap(1000, 400);

        public Graphics gr = Graphics.FromImage(bmp);

        List<Point> points = new List<Point>();
        List<Point> lines = new List<Point>();
        List<Point> result = new List<Point>();
        List<List<Point>> polygons = new List<List<Point>>();
        bool Mose_D = false;
        public int x0, y0;
        bool flagLeft = false;
        bool flagRight = false;

        void MD(object sen, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
        }

        void MU(object sen, MouseEventArgs e) { Mose_D = false; }

        void MouseClick(object sen, MouseEventArgs e)
        {
            if (Mose_D)
                points.Add(new Point(e.X, e.Y));
        }

        void Algorithm_Bras(int x0, int y0, int x1, int y1)
        {
            int dX = Math.Abs(x1 - x0), dY = -Math.Abs(y1 - y0);
            int sx, sy;
            if (x0 < x1)
                sx = 1;
            else
            {
                sx = -1;
            }
            if (y0 < y1)
                sy = 1;
            else
            {
                sy = -1;
            }
            int err = dX + dY;
            bmp.SetPixel(x1, y1, Color.Black);
            while (x0 != x1 || y0 != y1)
            {
                bmp.SetPixel(x0, y0, Color.Black);
                int err2 = err * 2;
                if (err2 >= dY)
                {
                    err += dY;
                    x0 += sx;
                }
                if (err2 <= dX)
                {
                    err += dX;
                    y0 += sy;
                }
            }
            pictureBox1.Image = bmp;
        }

        private void AddPolygon_Click(object sender, EventArgs e)
        {
            List<Point> tmp = new List<Point>();
            if (points.Count > 2)
            {
                for (int i = 0; i < points.Count() - 1; i++)
                {
                    Algorithm_Bras(points[i].X, points[i].Y, points[i + 1].X, points[i+1].Y);
                    if (!lines.Contains(points[i]))
                        lines.Add(points[i]);
                    if (!lines.Contains(points[i + 1]))
                        lines.Add(points[i + 1]);
                }
                if (points[0] != points[points.Count() - 1])
                    Algorithm_Bras(points[points.Count() - 1].X, points[points.Count() - 1].Y, points[0].X, points[0].Y);
                points.Clear();
                tmp = lines;
                polygons.Add(tmp);
            }
            else if (points.Count() == 2)
            {
                MessageBox.Show("Точек недостаточно для построения полигона");
            }
        }

        private void United_Click(object sender, EventArgs e)
        {

            gr.Clear(Color.White);
            int tempx , tempy ;
            if (polygons.Count == 2)
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 4; j < polygons[1].Count - 1; j++)
                    {
                        int a = polygons[0][i].Y - polygons[0][i + 1].Y;
                        int b = polygons[0][i + 1].X - polygons[0][i].X;
                        int c = polygons[0][i].X * a + polygons[0][i].Y * b;

                        int d = polygons[1][j].Y - polygons[1][j + 1].Y;
                        int ed = polygons[1][j + 1].X - polygons[1][j].X;
                        int f = polygons[1][j].X * d + polygons[1][j].Y * ed;
                        if(a*ed - d*b == 0)
                        {
                            throw new Exception("Zero div");
                        }
                        tempy = (a * f - d * c) / (a * ed - d * b);
                        tempx = (ed * c - b * f) / (a * ed - d * b);
                        
                        if(tempx > polygons[0][i].X && tempx < polygons[0][i + 1].X && tempy > polygons[0][i].Y &&
                            tempy < polygons[0][i + 1].Y)
                            if(tempx > polygons[1][j+1].X && tempx < polygons[1][j].X && tempy > polygons[1][j+1].Y &&
                                tempy < polygons[1][j].Y)
                            {
                                Point p = new Point(tempx, tempy);
                                polygons[0][i + 1] = p;
                                polygons[1][j] = p;
                                result.Add(p);
                            }
                            else
                            {
                                result.Add(polygons[0][i]);

                            }
                        else
                        {
                            result.Add(polygons[1][j]);
                        }
                        //Algorithm_Bras(polygons[1][j].X, polygons[1][j].Y, polygons[1][j + 1].X, polygons[1][j + 1].Y);
                        //Algorithm_Bras(polygons[1][j].X, polygons[1][j].Y, polygons[1][j + 1].X, polygons[1][j + 1].Y);
                    }
                }
                for(int i = 0; i < result.Count - 1; i++)
                {
                    Algorithm_Bras(result[i].X, result[i].Y, result[i + 1].X, result[i + 1].Y);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            pictureBox1.Image = null;
            points.Clear();
            lines.Clear();
            polygons.Clear();
            result.Clear();
            flagLeft = false;
            flagRight = false;
        }
    }
}
