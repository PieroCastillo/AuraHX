using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aura.Maths
{
    public class Pixel : IColoreable
    {
        public double X
        {
            get => default;
            set
            {
            }
        }

        public double Y
        {
            get => default;
            set
            {
            }
        }

        public Color Color { get; set; }
    }
}