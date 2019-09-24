using System;

namespace uppgift_byta_plats__power
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            BytPlats(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }

        public static void BytPlats(ref int a, ref int b)
        {
            int tal1 = a;
            int tal2 = b;
            a = tal2;
            b = tal1;
        }
    }
}
