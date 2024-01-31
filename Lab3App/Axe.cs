using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string description) : base(description)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}
