using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Testt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
            lastlabel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void dfs(int v, ref bool[] used, ref List<int> ans, int[][] smez)
        {
            (used)[v] = true;
            for (int i = 0; i < smez[v].Length; ++i)
            {
                int to = smez[v][i];
                if (!(used)[to])
                    dfs(to, ref used, ref ans, smez);
            }
            ans.Add(v);

        }



        private void go_button_Click(object sender, EventArgs e)
        {
            int[][] adjacencyList = new int[][]
            {
               new int[] {3},
               new int[] {},
               new int[] {1},
               new int[] {1,2},
           };

 
            const int k = 8;
            
            Pen boards = new Pen(Color.Black, 8);

            System.Drawing.Graphics graphics = this.CreateGraphics();
            graphics.DrawLine(boards, 1415, 140, 1415, 540);
            graphics.DrawLine(boards, 1308, 536, 1418, 536);
            graphics.DrawLine(boards, 1312, 540, 1312, 140);
            System.Drawing.Rectangle[] rectangle = new Rectangle[k + 1];
            SolidBrush solidBrush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Blue, 6);
            int x = 420;
            int y = 60;

            int i = 1;

            string text2 = i.ToString();

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);


            solidBrush.Color = Color.Red;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            //////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////

            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 420, 120, 195, 260);//1
            Thread.Sleep(1000);

            
            pen.Color = Color.Black;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 420, 120, 195, 260);//1

            i = 4;
            x = 110;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Red;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            pen.Color = Color.Blue;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 200, 270, 763, 270);
            Thread.Sleep(1000);

            pen.Color = Color.Black;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 200, 270, 763, 270);

            i = 2;
            x = 765;
            y = 230;

            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            i = 5;
            x = 1320;
            y = 440;


            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, "2", font2, rectangle[i], Color.White);
            }
            ///////////////////////////////////////////////////////////////////////////

            i = 4;
            x = 110;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Red;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            //////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            pen.Color = Color.Blue;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 188, 300, 420, 470);
            Thread.Sleep(1000);

            pen.Color = Color.Black;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 188, 300, 420, 470);

            i = 3;
            x = 420;
            y = 440;

            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            i = 6;
            x = 1320;
            y = 352;


            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, "3", font2, rectangle[i], Color.White);
            }

            ////////////////////////////////////////////////////////////////////////////

            i = 4;
            x = 110;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            i = 7;
            x = 1320;
            y = 264;


            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, "4", font2, rectangle[i], Color.White);
            }

            ////////////////////////////////////////////////////////////////////////////

            x = 420;
            y = 60;
            i = 1;

            text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            i = 8;
            x = 1320;
            y = 176;


            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, "1", font2, rectangle[i], Color.White);
            }


            const int n = 4;
            bool[] used = new bool[n] { false, false, false, false };
            List<int> ans = new List<int>(n);

            for (int j = 0; j < n; ++j)
                if (!used[j])
                    dfs(j, ref used, ref ans, adjacencyList);

            ans.Reverse();
            string[] txt = new string[n];
            for (int j = 0; j < n; ++j)
            {
                ++ans[j];
                txt[j] = ans[j].ToString();
            }
            label7.Text = String.Join(" ", txt);
            label2.Visible = true;
            label7.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Hide();
            label1.Show();
            const int n = 4;
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle[] rectangle = new Rectangle[n + 1];
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            int x = 420;
            int y = 60;
            for (int i = 1; i < n + 1; ++i)
            {

                string text2 = i.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                    graphics.FillEllipse(solidBrush, rectangle[i]);
                    TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
                }
                if (i == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (i == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (i == 3)
                {
                    x = 110;
                    y = 230;
                }

            }


            Pen pen = new Pen(Color.Black, 6);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, 420, 120, 195, 260);//1
            graphics.DrawLine(pen, 200, 270, 763, 270);//2
            graphics.DrawLine(pen, 188, 300, 420, 470);//3
            graphics.DrawLine(pen, 505, 470, 780, 305);//4


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            System.Drawing.Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);///////////////////////////1 вершина
            System.Drawing.Rectangle[] rectangle = new Rectangle[5];
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int x = 420;
            int y = 60;
            for (int j = 1; j < 5; ++j)
            {
                string text = j.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[j] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[j]);
                    graphics.FillEllipse(solidBrush, rectangle[j]);
                    TextRenderer.DrawText(graphics, text, font2, rectangle[j], Color.White);
                }
                if (j == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (j == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (j == 3)
                {
                    x = 110;
                    y = 230;
                }

            }

            Pen pen1 = new Pen(Color.Black, 6);
            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4

            System.Drawing.Rectangle rect = new Rectangle();
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, "Длиннейший путь:    0 ребер", font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     0\nВершина 3     0\nВершина 4     0\n", font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }
            Pen pen = new Pen(Color.Green, 6);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            x = 420;
            y = 60;

            int i = 1;
            solidBrush.Color = Color.Green;
            string text2 = i.ToString();

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            graphics.DrawLine(pen, 420, 120, 195, 260);//1
            Thread.Sleep(1000);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            graphics.Clear(Color.White);///////////////////////////4 вершина
            solidBrush.Color = Color.Black;
            x = 420;
            y = 60;
            for (int j = 1; j < 5; ++j)
            {
                string text = j.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[j] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[j]);
                    graphics.FillEllipse(solidBrush, rectangle[j]);
                    TextRenderer.DrawText(graphics, text, font2, rectangle[j], Color.White);
                }
                if (j == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (j == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (j == 3)
                {
                    x = 110;
                    y = 230;
                }

            }
            pen1.Color = Color.Green;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4

            i = 4;
            x = 110;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Green;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, "Длиннейший путь:    1 ребро", font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     0\nВершина 3     0\nВершина 4     1\n", font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            graphics.DrawLine(pen, 200, 270, 763, 270);//2
            Thread.Sleep(1000);
            //////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////2 вершина
            graphics.Clear(Color.White);
            solidBrush.Color = Color.Black;
            x = 420;
            y = 60;
            for (int j = 1; j < 5; ++j)
            {
                string text = j.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[j] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[j]);
                    graphics.FillEllipse(solidBrush, rectangle[j]);
                    TextRenderer.DrawText(graphics, text, font2, rectangle[j], Color.White);
                }
                if (j == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (j == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (j == 3)
                {
                    x = 110;
                    y = 230;
                }

            }
            pen1.Color = Color.Green;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4

            i = 2;
            x = 765;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Green;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, "Длиннейший путь:    2 ребра", font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     2\nВершина 3     0\nВершина 4     1\n", font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////4 вершина
            i = 4;
            x = 110;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Green;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            graphics.DrawLine(pen, 188, 300, 420, 470);//3
            Thread.Sleep(1000);

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////3 вершина
            graphics.Clear(Color.White);
            solidBrush.Color = Color.Black;
            x = 420;
            y = 60;
            for (int j = 1; j < 5; ++j)
            {
                string text = j.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[j] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[j]);
                    graphics.FillEllipse(solidBrush, rectangle[j]);
                    TextRenderer.DrawText(graphics, text, font2, rectangle[j], Color.White);
                }
                if (j == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (j == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (j == 3)
                {
                    x = 110;
                    y = 230;
                }

            }
            pen1.Color = Color.Green;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4

            i = 3;
            x = 420;
            y = 440;
            text2 = i.ToString();
            solidBrush.Color = Color.Green;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, "Длиннейший путь:    2 ребра", font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     2\nВершина 3     2\nВершина 4     1\n", font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            graphics.DrawLine(pen, 505, 470, 780, 305);//4
            Thread.Sleep(1000);

            //////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            graphics.Clear(Color.White);
            solidBrush.Color = Color.Black;
            x = 420;
            y = 60;
            for (int j = 1; j < 5; ++j)
            {
                string text = j.ToString();

                using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    rectangle[j] = new System.Drawing.Rectangle(x, y, 85, 85);

                    graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[j]);
                    graphics.FillEllipse(solidBrush, rectangle[j]);
                    TextRenderer.DrawText(graphics, text, font2, rectangle[j], Color.White);
                }
                if (j == 1)
                {
                    x = 765;
                    y = 230;
                }
                if (j == 2)
                {
                    x = 420;
                    y = 440;
                }
                if (j == 3)
                {
                    x = 110;
                    y = 230;
                }

            }
            pen1.Color = Color.Green;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4

            i = 2;
            x = 765;
            y = 230;
            text2 = i.ToString();
            solidBrush.Color = Color.Green;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, "Длиннейший путь:    3 ребра", font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     3\nВершина 3     2\nВершина 4     1\n", font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            Thread.Sleep(2000);

            solidBrush.Color = Color.Black;
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
            lastlabel.Show();
        }
    }
}

