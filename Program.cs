using System;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz dönüşüm)
            
            byte a = 5;
            sbyte b =30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d : " + d);

            long h =d;
            Console.WriteLine("h : " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "Ekrem";
            char f = 'a';
            object g = e+f+d;
            Console.WriteLine("g : " + g);

            //Explicit Conversion(Bilinçli dönüşüm)

            Console.WriteLine("--------------------------------------");

            int x = 4;
            byte y;

            y = (byte) x;//casting
            Console.WriteLine("y : " + y);

            int z = 100;
            byte t = (byte) z;
            Console.WriteLine("t : " + t);

            //**ToString Methodu

            Console.WriteLine("--------------------------------------");

            int xx = 6;
            string yy= xx.ToString();
            Console.WriteLine("yy : " + yy);

            //System.Convert
            Console.WriteLine("--------------------------------------");
            string s1="10",s2="20";
            int sayi1,sayi2;
            int toplam;

            sayi1 =Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);       

            toplam = sayi1+sayi2;
            Console.WriteLine("Toplam : " + toplam);

            //Parse
            Console.WriteLine("--------------------------------------");
            string metin1="10";
            string metin2 ="10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);

        }
    }
}
