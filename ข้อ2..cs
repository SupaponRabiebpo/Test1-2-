using System;

namespace ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;
            while (x > y || x < y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }

            }
            if (x == y) { Console.WriteLine(x); }
            else { Console.WriteLine(""); }


        }
    }
}
