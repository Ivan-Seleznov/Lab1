using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLab1
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
