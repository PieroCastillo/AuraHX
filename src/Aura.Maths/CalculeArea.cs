using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public static class CalculeArea
    {
        /// <summary>
        /// This method calcule the object's area
        /// </summary>
        public static double CalculeAreaof2DObject(Poligon Object)
        {
            throw new System.NotImplementedException();
        }

        public static double CalculeTriangleArea(Triangle Triangule)
        {
            double a = (Triangule.Base * Triangule.High) / 2; 
            return a;
        }

        public static double CalculeSquareArea(Square Square)
        {
            double a = ((int)Square.Side ^ 2);
            return a;
        }

        public static double CalculeRectangleArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static double CalculeCircleArea(Circle Circle)
        {
            return Math.PI * ((Circle.Diameter / 2) ^ 2);
        }
    }
}