using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.LSP_Example
{
    public class PenguinLSP : BirdLSP
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin is eating fish.");
        }
        public override void Sleep()
        {
            Console.WriteLine("Penguin is sleeping.");
        }
    
    }
}
