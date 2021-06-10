using System;
using baithi.ex2;

namespace baithi
{
    internal class Program
    {
        public static PrimeNumberFinder pn;
        public static void Main(string[] args)
        {
            //ex1
            MobilePhone mbPhone = new MobilePhone();
            mbPhone.PhoneName = "Trinh Quang Hoa";
            mbPhone.PhoneType = "098889999";
            mbPhone.PhonePrice = 200;
            mbPhone.Display();
            //ex2
            pn(1);
            pn(2);
            pn(3);
            pn(4);
            pn(5);
            pn(6);
            pn(7);
            pn(8);
            pn(9);
            pn(10);


        }
    }

    
}