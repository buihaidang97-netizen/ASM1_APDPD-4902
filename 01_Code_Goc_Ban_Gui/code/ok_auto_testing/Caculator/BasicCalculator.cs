using System;
using System.Collections.Generic;
using System.Text;

namespace Caculator
{
    public class BasicCalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substract(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can not divide by zero");
            }
            return a / b;
        }
        public bool IsOddEven(int number)
        {
            return number % 2 == 0;
            // tra ve true => so chan
            // tra ve false => so le
        }
        public string PhuongTrinhBacNhat(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "ptvn";
                }
                else
                {
                    return "ptvsn";
                }
            }
            else
            {
                double x = (double)-b / a;
                return $"ptcn x = {x}";
            }
        }
        public string PhuongTrinhBacHai(int a, int b, int c)
        {
            if (a == 0)
            {
                return PhuongTrinhBacNhat(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    return "ptvn";
                }
                else if (delta == 0)
                {
                    double x = (double)-b / (2 * a);
                    return $"ptcn x = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return $"ptcn x1 = {x1}, x2 = {x2}";
                }
            }

        }
        public int TimUSCLN(int a, int b)
        {
           a = Math.Abs(a);// lay gia tri tuyet doi cua a   
            b = Math.Abs(b);// lay gia tri tuyet doi cua b
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        public long TimBSCNN(long a, long b)
        {
            if (a == 0 || b == 0)
                return 0;
            return  Math.Abs(a) / TimUSCLN((int)a, (int)b) * Math.Abs(b);
        }
        public long timGiaiThua( long n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1;
            for (long i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
