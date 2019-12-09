﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vector
{
    public static class Painter
    {
       public static void DrawFigure(VectorLine line, Bitmap b)
       {
            Graphics gr = Graphics.FromImage(b);

            for (int i = 0; i < line.points.Count -1 ; i++)
            {
                gr.DrawLine(line.pen, line.points[i], line.points[i + 1]);

            }
            gr.DrawLine(line.pen, line.points[0], line.points[line.points.Count - 1]);



        }
    }
}
