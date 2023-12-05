using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class FileStuff
    {
        protected StreamReader? reader;
        string filePath = "..\\..\\..\\File\\scores.txt";
        protected string? text;
        //protected int[]? scores;
        protected string[]? stringScores;


        protected Stopwatch? myStopWatch;

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

        //protected void startTimer()
        //{
        //    myStopWatch = Stopwatch.StartNew();
        //}

        //protected void stopTimer()
        //{
        //    myStopWatch.Stop();
        //}

        //protected void PrintArray(int[] array)
        //{
        //    for (int k = 0; k < array.Length; k++)
        //    {
        //        Console.Write($"{array[k]} ");
        //    }
        //    Console.WriteLine();
        //}

        //protected void Swap(int[] arr, int i, int j)
        //{
        //    int swapSpot;
        //    swapSpot = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = swapSpot;
        //}
    }
}
