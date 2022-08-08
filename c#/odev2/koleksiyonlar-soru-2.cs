using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        ArrayList all = new ArrayList();
        ArrayList greater = new ArrayList();
        ArrayList lower = new ArrayList();

        for (int i = 0; i < 6; i++)
        {
            Console.Write((i + 1) + ". sayı : ");
            bool valid = int.TryParse(Console.ReadLine(), out int num);
            if (!valid)
            {
                Console.WriteLine("lütfen pozitif sayı girin !");
                --i;
                continue;
            }
            all.Add(num);
        }
        all.Sort();
        greater.AddRange(all.GetRange(all.Count - 3, 3));
        lower.AddRange(all.GetRange(0, 3));

        yazdir("en büyük 3 sayı", greater);
        yazdir("en küçük 3 sayı", lower);

        Console.WriteLine("\nortalama toplamları : {0}", ortalama(greater) + ortalama(lower));

    }

    public static void yazdir(string message, ArrayList list)
    {
        int total = 0;
        Console.WriteLine("\n" + message);
        foreach (int item in list)
        {
            total += item;
            Console.Write(item + " ");
        }
        Console.WriteLine("\nortalamaları : " + ortalama(list));
    }

    public static int ortalama(ArrayList list)
    {
        int total = 0;
        foreach (int item in list)
            total += item;
        return total / list.Count;
    }
}