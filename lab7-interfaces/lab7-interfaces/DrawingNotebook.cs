using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public class DrawingNotebook<Image> : Notebook<Image>
    {
        public List<Image> images = new List<Image>();
        public DrawingNotebook(int pageAmount)
        {
            this.PageAmount = pageAmount;
        }

        public override void WriteOnMe(Image image)
        {
            this.images.Add(image);
        }
    }
}
