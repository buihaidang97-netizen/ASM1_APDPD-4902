using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.LSP_Example
{
    public class EagleLSP : BirdLSP, IBirdLSP
    {
        // Removed the override modifier from Fly, since BirdLSP does not declare Fly as abstract or virtual.
        public void Fly()
        {
            // Implementation for EagleLSP's Fly method
            Console.WriteLine("Eagle is flying.");
        }

        public override void Eat()
        {
            // Implementation for EagleLSP's Eat method
            Console.WriteLine("Eagle is eating.");
        }

        public override void Sleep()
        {
            // Implementation for EagleLSP's Sleep method
            Console.WriteLine("Eagle is sleeping.");
        }
    }
}