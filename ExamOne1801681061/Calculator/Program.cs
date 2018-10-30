using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 12.78;

            string operatorche = Console.ReadLine();

            switch (operatorche)
            {
                case "+":
                    double sum = a + b;
                    double withPercentage = sum + (sum * (10 / 100));
                    Console.WriteLine($"Result is: {withPercentage}");
                    break;

                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;




                default:
                    Console.WriteLine("Error 404. No such operator");
                    break;
            }

        }
    }
}
