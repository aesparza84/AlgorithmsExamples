using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    public class QuadraticAlgorithmExample : IAlgorithm
    {
        public int count;
        private string[] myArray;
        public QuadraticAlgorithmExample() 
        {
            myArray= new string[5];
            myArray[0] = "A";
            myArray[1] = "B";
            myArray[2] = "C";
            myArray[3] = "D";
            myArray[4] = "E";
        }

        /// <summary>
        /// This is a seperate algorithm, it returns N^N print calls
        /// based on the array length. NOT Quadratic.
        /// </summary>
        public void DoAlgorithmTwo()
        {
            Console.WriteLine("Quadratic");

            ///With this algorithm, we make all possible combination of letters we put 
            ///into the array. This means that the print is called 'myArray.length^myArray.length' times.
            ///If the array length is 4, we get 4^4 calls, and so on with other lengths. Of course,
            ///I would need to change the for loops.

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    for (int n = 0; n < myArray.Length; n++)
                    {
                        for (int g = 0; g < myArray.Length; g++)
                        {
                            for (int h = 0; h < myArray.Length; h++)
                            {
                                Console.WriteLine(myArray[i] + myArray[j] + myArray[n] + myArray[g] + myArray[h]);
                                count++;
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine("Count "+count);
            Console.WriteLine("(Scroll back to top)");
            Console.WriteLine("----------------------------------------------");
        }

        public void DoAlgorithm()
        {
            ///This is a quadratic time aglorithm. We have 5 elements in our array.
            ///When this runs it iterates through, BUT at each element it prints 
            ///out the entire array but in reverse.
            ///We print out A, then the array reversed.
            ///B, then the array reversed, and so on.
            ///This returns (array length)^2 print calls.


            Console.WriteLine("Quadratic");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(" "+myArray[i]);
                for (int j = myArray.Length; j > 0; j--)
                {
                    Console.WriteLine("  "+myArray[j - 1]);
                    count++;
                }
            }

            Console.WriteLine("Count "+count);

        }
    }
}
