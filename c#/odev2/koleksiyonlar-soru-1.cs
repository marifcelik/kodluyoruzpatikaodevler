using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        ArrayList prime = new ArrayList();
        ArrayList normal = new ArrayList();
        int primeav = 0, normalav = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.Write((i + 1) + ". sayı : ");
            bool valid = int.TryParse(Console.ReadLine(), out int num);
            if (!valid || num < 0)
            {
                Console.WriteLine("lütfen pozitif sayı girin !");
                --i;
                continue;
            }
            if (isPrime(num))
                prime.Add(num);
            else
                normal.Add(num);
        }

        Console.WriteLine("\nasal sayılar");
        prime.Sort();
        foreach (int number in prime)
        {
            primeav += number;
            Console.Write(number + " ");
        }
        Console.WriteLine("\neleman sayısı : " + prime.Count + "\nortalaması : " + primeav / prime.Count);

        Console.WriteLine("\nasal olmayan sayılar");
        normal.Sort();
        foreach (int number in normal)
        {
            normalav += number;
            Console.Write(number + " ");
        }
        Console.WriteLine("\neleman sayısı : " + normal.Count + "\nortalaması : " + normalav / prime.Count);
    }

    public static bool isPrime(int number)
    {
        int result = 0;

        for (int i = number; i >= 2; i--)
            result += number % i == 0 ? 1 : 0;

        return result == 1;
    }

}