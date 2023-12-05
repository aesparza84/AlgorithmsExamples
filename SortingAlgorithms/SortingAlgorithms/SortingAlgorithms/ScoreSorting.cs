using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public abstract class ScoreSorting
    {
        protected StreamReader ?reader;
        string filePath = "..\\..\\..\\File\\scores.txt";
        protected string ?text;
        protected int[] ?scores;
        protected string[] ?stringScores;


        protected Stopwatch ?myStopWatch;

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

        protected void startTimer()
        {            
            myStopWatch= Stopwatch.StartNew();
        }

        protected void stopTimer() 
        {
            myStopWatch.Stop();
        }

        protected void PrintArray(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write($"{array[k]} ");
            }
            Console.WriteLine();
        }

        protected void Swap(int[] arr, int i, int j)
        {
            int swapSpot;
            swapSpot = arr[i];
            arr[i] = arr[j];
            arr[j] = swapSpot;
        }
    }
}
