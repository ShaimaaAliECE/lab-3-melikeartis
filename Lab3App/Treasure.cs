using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        protected int Score;
        public abstract void UpdateTotalScore();
        public abstract override void Display();
        public abstract override void AddMe(List<Collectable> list);
    }
}

