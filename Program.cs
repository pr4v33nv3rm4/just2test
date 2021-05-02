using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Calculator calc = new Calculator(double.Parse(args[0]), double.Parse(args[1]));
                Console.WriteLine($"Add :{calc.Add()}");
                Console.WriteLine($"Subtract :{calc.Subtract()}");
                Console.WriteLine($"Multiply :{calc.Multiply()}");
                Console.WriteLine($"Devide :{calc.Devide()}");

            }
            else {
                Console.WriteLine("no argument passed!");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
