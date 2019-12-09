using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag, typeOfToDO;
        Graphics VectorGraph;
        Bitmap vectorImage;
        VectorLine vl;
        Canvas canvas;
        int Tochka;
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas();
            vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            VectorGraph = Graphics.FromImage(vectorImage);
            VectorGraph.Clear(Color.White);
            pictureBox1.Image = vectorImage;
            typeOfToDO = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            if (typeOfToDO)
            {
                vl = new VectorLine(e.Location, Color.Black, 1);
                canvas.figures.Add(vl);
            }
            else
            {
                vl = canvas.FindPoint(e.Location);
                if (vl != null)
                {
                    for (int i = 0; i < vl.points.Count; i++)
                    {
                        if (vl.points[i] == e.Location)
                        {
                            Tochka = i;
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (typeOfToDO)
            {
                if (flag)
                {
                    vl.MouseMoveTillCreation(e.Location);
                    vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    VectorGraph = Graphics.FromImage(vectorImage);
                    VectorGraph.Clear(Color.White);
                    pictureBox1.Image = canvas.Update(vectorImage);
                }
            }
            else
            {
                if (flag)
                {
                    if (vl != null)
                    {
                        vl.points[Tochka] = e.Location;
                        vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        VectorGraph = Graphics.FromImage(vectorImage);
                        VectorGraph.Clear(Color.White);
                        pictureBox1.Image = canvas.Update(vectorImage);
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            
        }

        private void Line_Click(object sender, EventArgs e)
        {
            typeOfToDO = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            typeOfToDO = false;
        }
    }
}
