using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vector
{


   public class VectorLine
    {
        public List<Point> points; // описание вектора
        public Color color;
        public int size;
        public Pen pen;

        public VectorLine(Point p, Color c, float s)
        {
            this.pen = new Pen(c, s);
            points = new List<Point>();
            points.Add(p); // сьартовая точка, где мы начали
            points.Add(p);

        }
            // еще нужен метод на любое движение мышка, который будем вызывать в маус муве
        public void MouseMoveTillCreate(Point p)
        {
            points[1] = p; 
        }


    }
}
