using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.LSP
{
    internal class Eagle : Bird
    {
        public override void Fly()
        {
            // Eagle flying logic
            Console.WriteLine("Eagle is flying high in the sky.");
        }

        public override void Eat()
        {
            // Eagle eating logic
            Console.WriteLine("Eagle is eating meat.");
        }
    }
}
