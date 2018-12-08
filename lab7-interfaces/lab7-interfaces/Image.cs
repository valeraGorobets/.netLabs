using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public struct Pixel
    {
        public int x;
        public int y;
        public string color;
        public Pixel(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }

    public class Image
    {
        public List<Pixel> pixels = new List<Pixel>();

        public Image()
        {

        }
        public void AddPixel(Pixel pixel)
        {
            this.pixels.Add(pixel);
        }
    }
}
