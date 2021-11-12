using _8.hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.hét.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color boxColor, Color ribbenColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbenColor);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor,0, 0, Width, Height);
            g.FillRectangle(RibbonColor,0, Height * 0.4f, Width,Height * 0.2f);
            g.FillRectangle(RibbonColor, Width * 0.4f,0, Width * 0.2f,Height);
        }
    }
}
