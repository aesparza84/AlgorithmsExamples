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
        public void DoAlgorithm()
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
    }
}
