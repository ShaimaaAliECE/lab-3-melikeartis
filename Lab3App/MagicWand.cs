using System;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Lab3App
{
    internal class MagicWand : Tool
    {
        private string Name;
        public MagicWand(string name)
        {
            this.Name = name;
        }
        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(Name + " Collected, Congrats!!!!");
            list.Add(this);
            DoAction();
        }
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Name + " is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}