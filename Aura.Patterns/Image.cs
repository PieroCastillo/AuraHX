using System;
using System.IO;
using Draw = System.Drawing;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System.Collections.Generic;
using System.Text;
using Aura.Maths;
using libpngsharp;

namespace Aura.Patterns
{
    public class Image 
    { 
        public Pixel[,] Pixels;

        public Image(Stream stream) 
        {
            this.PngDecoder = new PngDecoder(stream);
            this.Height = PngDecoder.Height;
            this.Width = PngDecoder.Width;
        }

        public PngDecoder PngDecoder { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

       
    }
}
