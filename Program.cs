using System;
using baithi.ex2;

namespace baithi
{
    public delegate void ShowNumber(int a, int b );
    internal class Program
    {
        public static ShowNumber ss = new ShowNumber(PrimeNumberFinder.PriceNumber);
        public static void Main(string[] args)
        {
            //ex1
            MobilePhone mbPhone = new MobilePhone();
            mbPhone.PhoneName = "Trinh Quang Hoa";
            mbPhone.PhoneType = "098889999";
            mbPhone.PhonePrice = 200;
            mbPhone.Display();
            //ex2
            PrimeNumberFinder pn = new PrimeNumberFinder();


        }
    }

  
}