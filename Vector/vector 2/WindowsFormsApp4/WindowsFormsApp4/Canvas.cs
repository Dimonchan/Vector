using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Vector
{
   public class Canvas
    {
      public  List<VectorLine> figures;
        
        public Canvas()
        {
            figures = new List<VectorLine>();
        }

        public Bitmap Update(Bitmap b)
        {
            // вызает метод для форича, а апдейт возращает битмап

            foreach (VectorLine f in figures)
            {
                Painter.DrawFigure(f, b);
            }
            return b;
        }

        public Point FindPoint(Point p)
        {
            foreach (VectorLine f in figures)
            {
                if (f.points.Contains(p))
                {
                    foreach (Point i in f.points)
                    {
                        if (i.Equals(p))
                        {
                            return i;
                        }
                    }
                }
            }
            return new Point();
        }



    }
}
