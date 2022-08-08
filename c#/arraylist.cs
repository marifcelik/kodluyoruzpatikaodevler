using System;
using System.Collections;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("arif");
        list.Add(12);
        list.Add(true);
        list.Add('g');

        // take an element
        Console.WriteLine(list[1]);

        foreach (var item in list)
            Console.WriteLine(item);

        // add range
        Console.WriteLine("** add range **");
        string[] colors = { "red", "purple", "yellow" };
        list.AddRange(colors);

        List<int> numList = new List<int>() { 1, 3, 5, 62, 465, 36, 8 };
        list.AddRange(numList);

        foreach (var item in list)
            Console.WriteLine(item);

        // sort
        Console.WriteLine("** sort **");
        list.Sort();

        // binary search
        Console.WriteLine(list.BinarySearch(3));

        // reverse
        list.Reverse();
        foreach (var item in list)
            Console.WriteLine(item);

        // clear
        list.Clear();
    }
}