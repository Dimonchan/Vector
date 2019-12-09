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
        Canvas canvas;
        VectorLine vl;
        Point pointToChange;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LINE_Click(object sender, EventArgs e)
        {
            typeOfToDo = true;
        }

        // Pen P;
        Bitmap vectorImage;
        Graphics VectorGraph;

        private void Form1_Load(object sender, EventArgs e)
        {
            vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            VectorGraph = Graphics.FromImage(vectorImage);
            VectorGraph.Clear(Color.White);
            pictureBox1.Image = vectorImage;
            canvas = new Canvas();
            typeOfToDo = true;
        }

        private void LINE_MouseMove(object sender, MouseEventArgs e)
        {
            if (typeOfToDo)
            { 
            if (flag)
            {
                vl.MouseMoveTillCreate(e.Location);
                vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);//
                VectorGraph = Graphics.FromImage(vectorImage);//
                VectorGraph.Clear(Color.White);//
                pictureBox1.Image = canvas.Update(vectorImage);
            }
        }
    }

        bool flag, typeOfToDo; // - рисовать
       

        private void LINE_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void LINE_MouseUp(object sender, MouseEventArgs e)
        {
             
               
           
        }

        private void LINE_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            if (typeOfToDo)
            {
                vl = new VectorLine(e.Location, Color.Black, 2);
                canvas.figures.Add(vl);
                
            }
            else
            {
                pointToChange = e.Location;

                vl.MouseMoveTillCreate(e.Location);
                vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);//
                VectorGraph = Graphics.FromImage(vectorImage);//
                VectorGraph.Clear(Color.White);//
                pictureBox1.Image = canvas.Update(vectorImage);
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
