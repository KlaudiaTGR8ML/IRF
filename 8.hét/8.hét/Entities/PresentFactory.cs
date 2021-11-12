using _8.hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.hét.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color BoxColor { get; set; }
        public Color RibbenColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(BoxColor, RibbenColor);
        }
    }
}
