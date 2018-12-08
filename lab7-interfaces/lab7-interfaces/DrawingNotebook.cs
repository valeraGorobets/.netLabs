using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public class DrawingNotebook : Notebook<Image>
    {
        public List<Image> images = new List<Image>();

        public DrawingNotebook(int pageAmount)
        {
            this.pageAmount = pageAmount;
        }

        public override void WriteOnMe(Image image)
        {
            this.images.Add(image);
        }
    }
}
