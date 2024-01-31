using System;
using System.Collections.Generic;

namespace Lab3App
{                                                                                                                                                     
    internal abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score)
        {
            this.Description = description;
            this.Score = score;
        }

        public override void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            UpdateTotalScore();
        }

        public void UpdateTotalScore()
        {
            Board.UpdateTotalScore(Score); // Use Board property to update the score
        }

        public abstract void UpdateTotalValue();
    }
}

