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
        public List<Point> points;
        public Pen pen;
        public VectorLine(Point p, Color c, float s)
        {
            this.pen = new Pen(c, s);
            points = new List<Point>();
            points.Add(p);
            points.Add(p);
        }
        public void MouseMoveTillCreation(Point p)
        {
            points[1] = p;
        }
    }
}
