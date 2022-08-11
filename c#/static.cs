using System;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("çalışan sayısı : {0}", Calisan.CalisanSayisi);
        Calisan aslan = new Calisan("aslan", "rakun", "reklam");
        Console.WriteLine("çalışan sayısı : {0}", Calisan.CalisanSayisi);
        Calisan hakan = new Calisan("hakan", "aslan", "it");
        Calisan umut = new Calisan("umut", "kuş", "ik");
        Console.WriteLine("çalışan sayısı : {0}", Calisan.CalisanSayisi);

        Console.WriteLine("toplama işlemi : {0}", Islemler.topla(15,12));
        Console.WriteLine("çıkarma işlemi : {0}", Islemler.cikar(15,12));
    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string isim;
    private string soyisim;
    private string departman;

    public Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisanSayisi++;
    }

    static Calisan()
    {
        calisanSayisi = 0;
    }
}

static class Islemler
{
    public static long topla(int a, int b) => a + b;
    public static long cikar(int a, int b) => a - b;
}
