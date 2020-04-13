using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public class Square : Poligon, ISizeable , ICentreable
    {
        public Point CalculateCenterPoint()
        {
            var x1 = this.Ubication.X;
            var y1 = this.Ubication.Y;
            var p = new Point()
            {
                X = x1 + (this.Height / 2),
                Y = y1 + (this.Width / 2)
            };
            return p;
        }
        public double Side { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Point Center
        {
            get => this.CalculateCenterPoint();
        }
    }
}