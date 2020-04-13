using System;
using System.IO;
using Draw = System.Drawing;
using Avalonia.Media.Imaging;
using System.Collections.Generic;
using System.Text;
using Aura.Maths;

namespace Aura.Patterns
{
    public class Image : ISizeable
    { 
        public Pixel[,] Pixels;

        public Image(Bitmap bitmap)
        {
            DecodeImage(bitmap);
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public Stream DecodeImage(Bitmap bitmap)
        {
            var str = new MemoryStream();
            bitmap.Save(str);
            return str; 
        }

        public Pixel[,] ToArray(Stream BitmapCoded)
        {
            Pixel[,] p = new Pixel[Height,Width];
            var stream = DecodeImage(new Bitmap(BitmapCoded));
            
            return p;
        }

        public void SetPixel()
        {

        }
    }
}
