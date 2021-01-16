using System;

namespace ConsoleApp1_Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            araba car1 = new araba();
            car1.marka = "Toyota";
            car1.model = "Corolla";
            car1.tarih = 2011;
            car1.renk = "Kırmızı";

            Console.WriteLine(car1.marka);

        }
    }

    class araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int tarih { get; set; }
        public string renk { get; set; }


    }
}
