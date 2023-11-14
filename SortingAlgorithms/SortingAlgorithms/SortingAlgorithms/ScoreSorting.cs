using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public abstract class ScoreSorting
    {
        protected StreamReader reader;
        string filePath = "..\\..\\..\\File\\scores.txt";
        protected string text;
        protected int[] scores;
        protected string[] stringScores;

        protected void GetScoresFromFile()
        {
            reader = new StreamReader(filePath);
            text = reader.ReadToEnd();
            stringScores = text.Split(new char[] { '\n' });
            scores = new int[stringScores.Length];

            for (int i = 0; i < stringScores.Length; i++)
            {
                scores[i] = Convert.ToInt32(stringScores[i]);
            }
        }
    }
}
