using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Rectangle : MarthFormula
    {
        private double length { get; set; }
        private double width { get; set; }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double CalculateArea()
        {
            return length * width;
        }
        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }


    }
}
