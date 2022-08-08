using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.ad = "bekir";
        calisan1.soyad = "taş";
        calisan1.no = 1245;
        calisan1.departman = "kölelik";
        calisan1.bilgiler();

        Calisan calisan2 = new();
        calisan2.ad = "bahar";
        calisan2.soyad = "spring";
        calisan2.no = 92;
        calisan2.departman = "insan kaynakları";
        calisan2.bilgiler();
    }
}

class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;
    public void bilgiler()
    {
        Console.WriteLine("ad : " + ad);
        Console.WriteLine("soyad : " + soyad);
        Console.WriteLine("no : " + no);
        Console.WriteLine("departman : " + departman);
    }
}