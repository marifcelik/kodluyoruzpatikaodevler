using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 2;

            Methods sinif = new Methods();


            Console.WriteLine(topla(a, b));
            sinif.yazdir("class içinden değer yazımı");
            Console.WriteLine("yeni değerleri : " + arttirVeTopla(ref a, ref b).ToString());
        }

        static int topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

        static int arttirVeTopla(ref int deger1, ref int deger2)
        {
            return ++deger1 + ++deger2;
        }
    }
}

class Methods
{
    public void yazdir(string str)
    {
        Console.WriteLine(str);
    }
}