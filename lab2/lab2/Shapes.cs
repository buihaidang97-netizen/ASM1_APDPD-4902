using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public abstract class Shapes 
    {
        // định nghĩa các phương thức trừu tượng (abstract methods) mà các lớp con phải triển khai
        public abstract double Area(); // phương thức trừu tượng tính diện tích
        public abstract double Perimeter(); // phương thức trừu tượng tính chu vi
    }
}
