using System;
namespace Lab3App
{
    internal class CollectionBoard
    {
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }

        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {TotalScore}");
        }

        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
        }
    }
}

