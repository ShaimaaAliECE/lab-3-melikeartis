using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        protected Tool(string description)
        {
            Description = description;
        }

        public override void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction(); // Call DoAction here
        }

        public abstract void DoAction();
    }
}

