using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    public class LinearAlgorithmExample : IAlgorithm
    {
        private int number;
        public LinearAlgorithmExample(int N) 
        {
            this.number = N;
        }
        public void DoAlgorithm()
        {
            Console.WriteLine("Linear");

            ///A simple linear algorithm
            ///that counts up to the number entered.
            ///If you enter 4, there will be 4 print calls, and so on with other numbers.
            ///

            if (number < 0)
            {
                number = 10;
                Console.WriteLine("No Negatives. Default  to 10");
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Counting: " + (i + 1));
                }
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Counting: " + (i+1));
                }
            }
            Console.WriteLine("-------------------------------------------");
        }

    }
}
