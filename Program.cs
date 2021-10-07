using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to Line comparison computation");
            int x1, x2, y1, y2;
            Console.WriteLine("Enter the value of(x1,y1),(x2,y2)cordinates");
             x1 = Convert.ToInt32(Console.ReadLine());
             x2 = Convert.ToInt32(Console.ReadLine());
             y1 = Convert.ToInt32(Console.ReadLine());
             y2 = Convert.ToInt32(Console.ReadLine());
             int lenght1= ToFindLength(x1, y1, x2, y2);

             x1 = Convert.ToInt32(Console.ReadLine());
             x2 = Convert.ToInt32(Console.ReadLine());
             y1 = Convert.ToInt32(Console.ReadLine());
             y2 = Convert.ToInt32(Console.ReadLine());
             int lenght2 = ToFindLength(x1, y1, x2, y2);

            Console.WriteLine(lenght1.Equals(lenght2));
        }
        private static int ToFindLength(int x1,int y1,int x2,int y2)
        {
            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.ReadLine();
        }
    }
}
