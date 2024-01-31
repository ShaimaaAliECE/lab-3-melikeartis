using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; } // Add this line for association with CollectionBoard

        public abstract void Display();
        public abstract void AddMe(List<Collectable> collection);
    }
}
