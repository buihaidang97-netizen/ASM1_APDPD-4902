using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab2
{
    public class PhuongTrinhBac2
    {
        private double hsa { get; set; }
        private double hsb { get; set; }
        private double hsc { get; set; }

        public PhuongTrinhBac2(double a, double b, double c)
        {
            hsa = a;
            hsb = b;
            hsc = c;
        }
        private string PhuongTrinhBN()
        {
            //hsbX + hsc = 0
            if (hsb == 0)
            {
                if (hsc == 0)
                {
                    return "Phương trình có vô số nghiệm";
                }
                return "Phương trình vô nghiệm";
            }
            return $"Phương trình có nghiệm duy nhất: x = {- hsc / hsb}";
        }
        private string GiaiPhuongTrinh()
        {
            if (hsa == 0)
            {
                return PhuongTrinhBN();
            }
            double delta = (hsb * hsb) - 4 * (  hsa * hsc);
            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -hsb / (2 * hsa);
                return $"Phương trình có nghiệm kép: x1 = x2 = {x}";
            }
            else
            {
                double x1 = (-hsb + Math.Sqrt(delta)) / (2 * hsa);
                double x2 = (-hsb - Math.Sqrt(delta)) / (2 * hsa);
                return $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
                        
            
        }
        public string ShowResult()
        {
            return GiaiPhuongTrinh();
        }
    }
}
