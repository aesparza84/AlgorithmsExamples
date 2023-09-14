namespace Assignement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstantAglorithmExample ConstantAlgorithm = new ConstantAglorithmExample();
            LinearAlgorithmExample LinearAlgorithm = new LinearAlgorithmExample(20);
            QuadraticAlgorithmExample QuadraticAlgorithm = new QuadraticAlgorithmExample();

            ConstantAlgorithm.DoAlgorithm();
            LinearAlgorithm.DoAlgorithm();
            QuadraticAlgorithm.DoAlgorithm();

            Console.WriteLine("Algorithms done");

        }
    }
}