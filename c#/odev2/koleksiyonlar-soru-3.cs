using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        List<char> vowels = new List<char>{'a', 'A', 'e', 'E', 'ı', 'I', 'i', 'İ', 'o', 'O', 'ö', 'Ö', 'ü', 'Ü'};
        List<char> inSentence = new List<char>();
        
        Console.Write("cümle : ");
        string sentence = Console.ReadLine();

        foreach (char letter in sentence)
        {
            if(vowels.Contains(letter))
                inSentence.Add(letter);
        }

        Console.WriteLine("cümle içerisindeki sesli harfler sırasıyla şöyledir : ");
        foreach (char item in inSentence)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

    }
}