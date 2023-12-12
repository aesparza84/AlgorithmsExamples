using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class FileStuff
    {
        protected StreamReader? reader;
        string filePath = "..\\..\\..\\File\\scores.txt";
        protected string? text;
        //protected int[]? scores;
        protected string[]? stringScores;

        public int[] GetScoresFromFile()
        {
            int[] newArray;

            reader = new StreamReader(filePath);
            text = reader.ReadToEnd();
            stringScores = text.Split(new char[] { '\n' });
            newArray = new int[stringScores.Length];

            for (int i = 0; i < stringScores.Length; i++)
            {
                newArray[i] = Convert.ToInt32(stringScores[i]);
            }

            return newArray;
        }
    }
}
