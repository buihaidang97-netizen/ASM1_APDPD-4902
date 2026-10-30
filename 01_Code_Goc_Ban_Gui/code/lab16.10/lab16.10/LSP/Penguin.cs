using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.LSP
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            // Penguin flying logic (if applicable)
            throw new NotImplementedException("Penguins cannot fly.");
        }

        public override void Eat()
        {
            // Penguin eating logic
            Console.WriteLine("Penguin is eating fish.");
        }
    }
}
