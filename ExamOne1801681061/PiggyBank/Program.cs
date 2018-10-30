using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double sum = 0;

            Console.WriteLine("Enter a real number:");
            string input = Console.ReadLine();

            int inputNum;
            while (!int.TryParse(input, out inputNum))
            {
                Console.WriteLine("You have to enter a valid real number!");
                input = Console.ReadLine();
            }
        }
    }
}
