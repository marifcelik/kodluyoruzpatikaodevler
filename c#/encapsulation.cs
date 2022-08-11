using System;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        Ogrenci davut = new Ogrenci();
        davut.Isim = "davut";
        davut.Soyisim = "sevgili";
        davut.OgrenciNo = 912;
        davut.Sinif = 3;

        davut.ogrenciGetir();
        davut.sinifAtlat();
        davut.ogrenciGetir();

        Ogrenci deniz = new Ogrenci("deniz", "arda", 256, 1);
        deniz.ogrenciGetir();
        deniz.sinifDusur();
        deniz.sinifDusur();
        deniz.ogrenciGetir();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => this.isim = value; }
    public string Soyisim { get => soyisim; set => this.soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => this.ogrenciNo = value; }
    public int Sinif { get => sinif; set => this.sinif = value < 1 ? 1 : value; }

    public Ogrenci() { }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public void ogrenciGetir()
    {
        Console.WriteLine("**** öğrenci bilgileri ****");
        Console.WriteLine("adı : " + this.Isim);
        Console.WriteLine("soyadı : " + this.Soyisim);
        Console.WriteLine("no : " + this.OgrenciNo);
        Console.WriteLine("sınıf : " + this.Sinif);
    }

    public void sinifAtlat()
    {
        this.Sinif++;
    }

    public void sinifDusur()
    {
        this.Sinif--;
    }
}