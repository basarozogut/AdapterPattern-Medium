using System;

namespace AdapterPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateAndPrint(new Addition(3, 2)); // Will print 5. (3 + 2)
            CalculateAndPrint(new MultiplicationAdapter(new Multiplication(), 6, 2));  // Will print 12. (6 * 2)
        }

        static void CalculateAndPrint(IMathOperation mathOperation)
        {
            var result = mathOperation.Calculate();
            Console.WriteLine("Result is: " + result);
        }
    }
}
