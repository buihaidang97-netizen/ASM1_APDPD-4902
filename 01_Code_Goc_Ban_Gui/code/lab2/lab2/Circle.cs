using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Circle : Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
