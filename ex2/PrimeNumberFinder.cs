using System;

namespace baithi.ex2
{
    public class PrimeNumberFinder
    {
        public static event ShowNumber OnPriceNumber;

        



        public static void PriceNumber(int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                if (b % i == 0)
                {
                    Console.WriteLine("Finded " + i);
                }
                return;
            }
        }

       
    }
}