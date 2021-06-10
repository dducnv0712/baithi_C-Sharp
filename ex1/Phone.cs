using System;

namespace baithi
{
    public class Phone
    {
        protected string phoneName ;
        protected string phoneType;
        protected float phonePrice;

        public Phone()
        {
        }

        public string PhoneName
        {
            get => phoneName;
            set => phoneName = value;
        }

        public string PhoneType
        {
            get => phoneType;
            set => phoneType = value;
        }
        public float PhonePrice
        {
            get => phonePrice;
            set => phonePrice = value;
        }

        public Phone(string phoneName, string phoneType, float phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneType = phoneType;
            this.phonePrice = phonePrice;
        }


        public void Display()
        {
                 Console.WriteLine("Phone : {0} ", phoneName);
                 Console.WriteLine("Type  : {0} ", phoneType);
                 Console.WriteLine("Price : {0} ", phonePrice);
        }


    }
}