using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler sinif = new();

            Console.WriteLine(sinif.usAl(3, 4));

            string name = "Mehmet Arif ÇELİK";
            bool sonuc = name.checkSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(name.rmSpaces());

            Console.WriteLine(name.makeUpperCase());
            Console.WriteLine(name.makeLowerCase());

            int[] dizi = { 52, 23, 1, 69, 12, 17, 43 };
            dizi.sortArray();
            dizi.printArray();

            int tekSayi = 7;
            Console.WriteLine(tekSayi.isEven());
            Console.WriteLine(name.firstChar());
        }
    }
}

class Islemler
{
    public int usAl(int taban, int us)
    {
        return us != 1 ? taban * usAl(taban, us - 1) : taban;
    }
}

static class Extension
{
    public static bool checkSpaces(this string str)
    {
        return str.Contains(" ");
    }

    public static string rmSpaces(this string str)
    {
        return String.Join("", str.Split(' '));
    }

    public static string makeUpperCase(this string str)
    {
        return str.ToUpper();
    }

    public static string makeLowerCase(this string str)
    {
        return str.ToLower();
    }

    public static int[] sortArray(this int[] array)
    {
        Array.Sort(array);
        return array;
    }

    public static void printArray(this int[] array)
    {
        foreach (int item in array)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    public static bool isEven(this int num)
    {
        return num % 2 == 0;
    }

    public static char firstChar(this string str)
    {
        return Convert.ToChar(str.Substring(0, 1));
    }
}