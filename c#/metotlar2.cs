using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "452";

            bool sonuc = int.TryParse(sayi, out int cikanSayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı : {0}", cikanSayi);
            }
            else
            {
                Console.WriteLine("hata");
            }
            Methods sinif = new Methods();
            sinif.topla(2, 3, out int toplam);
            Console.WriteLine(toplam);

            sinif.yazdir("arif");
            sinif.yazdir(22);
            sinif.yazdir("arif", 22);
        }
    }
}

class Methods
{
    public void topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void yazdir(string str)
    {
        Console.WriteLine(str);
    }

    public void yazdir(int sayi)
    {
        Console.WriteLine(sayi);
    }

    public void yazdir(string str, int sayi)
    {
        Console.WriteLine("{0} ve {1}", str, sayi);
    }
}