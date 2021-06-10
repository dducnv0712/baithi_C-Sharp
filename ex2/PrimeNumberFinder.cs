using System;

namespace baithi.ex2
{

    public delegate int PrimeNumberFinder(int num);
    public class PrimeNumber
    {
        public event PrimeNumberFinder OnPrimeNumber;
        private int num;

        public int Num
        {
            get => num;
            set => num = value;
        }
        public static void primeNumberFinder(int num)
        {
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " Khong Phai So Nguyen To");
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " Khong Phai So Nguyen tO");
                    
                    }

                }
                Console.WriteLine(num + " La So Nguyen To");
            }
        }
        public int Result(int num)
        {
            return num;
        }
        
        public int ShowEvent(int num)
        {
            if (OnPrimeNumber == null)
            {
            }
            return num;
        }


       
    }
}