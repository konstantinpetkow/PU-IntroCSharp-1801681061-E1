using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Count1 = rnd.Next(33, 187);
            int Count2 = rnd.Next(33, 187);

            int area = Count1 * Count2;
            Console.WriteLine($"Rectangle area is {area:0}");
        }
    }
}
