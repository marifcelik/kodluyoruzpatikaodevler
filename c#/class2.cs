using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** çalışan 1 ***");
        Calisan calisan1 = new Calisan("bekir", "taş", 1245, "kölelik");
        calisan1.bilgiler();

        Console.WriteLine("*** çalışan 2 ***");
        Calisan calisan2 = new();
        calisan2.ad = "bahar";
        calisan2.soyad = "spring";
        calisan2.no = 92;
        calisan2.departman = "insan kaynakları";
        calisan2.bilgiler();

        Console.WriteLine("*** çalışan 2 ***");
        Calisan calisan3 = new Calisan("arif", "çelik");
        calisan3.bilgiler();
    }
}

class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.no = no;
        this.departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }

    public Calisan() { }

    public void bilgiler()
    {
        Console.WriteLine("ad : " + ad);
        Console.WriteLine("soyad : " + soyad);
        Console.WriteLine("no : " + no);
        Console.WriteLine("departman : " + departman);
    }
}