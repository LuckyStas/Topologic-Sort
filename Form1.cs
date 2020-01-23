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

        private void buildCircles(int i, int x, int y, string text2, Color color, Rectangle[] rectangle, Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rectangle[i] = new System.Drawing.Rectangle(x, y, 85, 85);

                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle[i]);
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
        }

        private void paintCircles(int i, int x, int y, Color color, Rectangle[] rectangle, Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            string text2 = i.ToString();
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                graphics.FillEllipse(solidBrush, rectangle[i]);
                TextRenderer.DrawText(graphics, text2, font2, rectangle[i], Color.White);
            }
        }

        private void topologicSortVisual()
        {
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

            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);

            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Red, rectangle, graphics);
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

            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Red, rectangle, graphics);

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

            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Black, rectangle, graphics);

            i = 5;
            x = 1320;
            y = 440;


            buildCircles(i, x, y, "2", Color.Black, rectangle, graphics);
            ///////////////////////////////////////////////////////////////////////////

            i = 4;
            x = 110;
            y = 230;
            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Red, rectangle, graphics);

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

            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Black, rectangle, graphics);

            i = 6;
            x = 1320;
            y = 352;


            buildCircles(i, x, y, "3", Color.Black, rectangle, graphics);

            ////////////////////////////////////////////////////////////////////////////

            i = 4;
            x = 110;
            y = 230;
            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Black, rectangle, graphics);

            i = 7;
            x = 1320;
            y = 264;


            buildCircles(i, x, y, "4", Color.Black, rectangle, graphics);

            ////////////////////////////////////////////////////////////////////////////

            x = 420;
            y = 60;
            i = 1;

            string text2 = i.ToString();
            solidBrush.Color = Color.Blue;
            buildCircles(i, x, y, i.ToString(), Color.Blue, rectangle, graphics);
            Thread.Sleep(2000);

            paintCircles(i, x, y, Color.Black, rectangle, graphics);

            i = 8;
            x = 1320;
            y = 176;


            buildCircles(i, x, y, "1", Color.Black, rectangle, graphics);

        }

        private async void go_button_Click(object sender, EventArgs e)
        {
            int[][] adjacencyList = new int[][]
            {
               new int[] {3},
               new int[] {},
               new int[] {1},
               new int[] {1,2},
           };

            label1.Show();

            await Task.Run(()=>topologicSortVisual());

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
            const int n = 5;
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle[] rectangle = new Rectangle[n];
            rebuildGraph(Color.Red, rectangle, graphics);

            rebuildArrows(0, graphics);
        }


        private void rebuildGraph(Color color, Rectangle[] rectangle, Graphics graphics)
        {
            int x = 420;
            int y = 60;
            for (int j = 1; j < 5; ++j)
            {

                buildCircles(j, x, y, j.ToString(), color, rectangle, graphics);

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
        }

        private void rebuildArrows(int order, Graphics graphics)
        {
            Pen pen1 = new Pen(Color.Green, 6);
            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            if (order == 0)
                pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 420, 120, 195, 260);//1
            if (order == 1)
                pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 200, 270, 763, 270);//2
            if (order == 3 || order == 2)
                pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 188, 300, 420, 470);//3
            if (order == 4)
                pen1.Color = Color.Black;
            graphics.DrawLine(pen1, 505, 470, 780, 305);//4
        }



        private void rebuildLabels(string maxWayText, string tableText, Graphics graphics)
        {
            System.Drawing.Rectangle rect = new Rectangle();
            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(40, 600, 390, 80);
                TextRenderer.DrawText(graphics, maxWayText, font2, rect, Color.Black);

                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }

            using (Font font2 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                rect = new System.Drawing.Rectangle(810, 400, 290, 250);
                TextRenderer.DrawText(graphics, tableText, font2, rect, Color.Black);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rect);

            }
        }


        private void findMaxVisualisation()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            ///////////////////////////1 вершина
            System.Drawing.Rectangle[] rectangle = new Rectangle[5];


            string maxWayText = "Длиннейший путь:    0 ребер";
            string tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     0\nВершина 3     0\nВершина 4     0\n";

            Pen pen = new Pen(Color.Green, 6);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            int x = 420;
            int y = 60;
            int i = 1;



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            for (int j = 0; j < 5; ++j)
            {
                graphics.Clear(Color.White);

                rebuildGraph(Color.Black, rectangle, graphics);

                rebuildArrows(j, graphics);

                rebuildLabels(maxWayText, tableText, graphics);

                buildCircles(i, x, y, i.ToString(), Color.Green, rectangle, graphics);
                Thread.Sleep(2000);

                paintCircles(i, x, y, Color.Black, rectangle, graphics);
                if (j == 0)
                {
                    i = 4;
                    x = 110;
                    y = 230;
                    maxWayText = "Длиннейший путь:    1 ребро";
                    tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     0\nВершина 3     0\nВершина 4     1\n";
                    graphics.DrawLine(pen, 420, 120, 195, 260);//1
                    Thread.Sleep(1000);
                }
                if (j == 1)
                {
                    i = 2;
                    x = 765;
                    y = 230;
                    maxWayText = "Длиннейший путь:    2 ребра";
                    tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     2\nВершина 3     0\nВершина 4     1\n";
                    graphics.DrawLine(pen, 200, 270, 763, 270);//2
                    Thread.Sleep(1000);
                }
                if (j == 2)
                {
                    i = 4;
                    x = 110;
                    y = 230;
                    maxWayText = "Длиннейший путь:    2 ребра";
                    tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     2\nВершина 3     0\nВершина 4     1\n";
                }
                if (j == 3)
                {
                    i = 3;
                    x = 420;
                    y = 440;
                    maxWayText = "Длиннейший путь:    2 ребра";
                    tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     2\nВершина 3     2\nВершина 4     1\n";
                    graphics.DrawLine(pen, 188, 300, 420, 470);//3
                    Thread.Sleep(1000);
                }
                if (j == 4)
                {
                    i = 2;
                    x = 765;
                    y = 230;
                    maxWayText = "Длиннейший путь:    3 ребра";
                    tableText = "Длиннейшие пути к\n каждой вершине:\n\nВершина 1     0\nВершина 2     3\nВершина 3     2\nВершина 4     1\n";
                    graphics.DrawLine(pen, 505, 470, 780, 305);//4
                    Thread.Sleep(1000);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            await Task.Run(() => findMaxVisualisation());
            lastlabel.Show();
        }
    }
}
