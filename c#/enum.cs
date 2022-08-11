using System;

namespace dotnet
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int deger = 32;

            if (deger <= (int)HavaDurumu.Normal)
                Console.WriteLine("dışarısı soğuk");
            else if (deger >= (int)HavaDurumu.Sicak)
                Console.WriteLine("hava çok sıcak");
            else if (deger >= (int)HavaDurumu.Normal && deger < (int)HavaDurumu.CokSicak)
                Console.WriteLine("hava iyi ya");
        }
    }
}

enum Gunler
{
    Pazartesi = 1,
    Sali,
    Carsamba,
    Persembe,
    Cuma = 21,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 22,
    Sicak = 30,
    CokSicak = 40
}
