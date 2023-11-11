namespace Assignement1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///Here is an example of a Constant time algorithm.
            ///Explore the class to see the specifics
            ConstantAglorithmExample ConstantAlgorithm = new ConstantAglorithmExample(12);

            ///Here is an example of a Linear time algorithm.
            ///Explore the class to see the specifics
            LinearAlgorithmExample LinearAlgorithm = new LinearAlgorithmExample(20);

            ///Here is an example of a Quadratic time algorithm.
            ///Explore the class to see the specifics
            QuadraticAlgorithmExample QuadraticAlgorithm = new QuadraticAlgorithmExample();

            ConstantAlgorithm.DoAlgorithm();
            LinearAlgorithm.DoAlgorithm();
            QuadraticAlgorithm.DoAlgorithm();

            Console.WriteLine("Algorithms done");

        }
    }
}