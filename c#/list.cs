using System;
using System.Collections.Generic;

namespace dotnet;

class Program
{
    private static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        numList.Add(12);
        numList.Add(3);
        numList.Add(5);
        numList.Add(76);

        List<string> colorList = new List<string>();
        colorList.Add("red");
        colorList.Add("blue");
        colorList.Add("yellow");
        colorList.Add("purple");

        //count 
        Console.WriteLine(colorList.Count);
        Console.WriteLine(numList.Count);

        foreach (int num in numList)
            Console.WriteLine("foreach " + num);

        foreach (string color in colorList)
            Console.WriteLine("foreach " + color);

        numList.ForEach(sayi => Console.WriteLine("list foreach " + sayi));
        colorList.ForEach(color => Console.WriteLine("list foreach " + color));

        // remove
        numList.Remove(2);
        colorList.Remove("blue");

        numList.ForEach(sayi => Console.WriteLine("list foreach " + sayi));
        colorList.ForEach(color => Console.WriteLine("list foreach " + color));

        numList.RemoveAt(1);
        colorList.RemoveAt(2);

        // search
        if (numList.Contains(12))
            Console.WriteLine("listede 12 var");

        // get index with element
        Console.WriteLine(colorList.BinarySearch("purple"));

        // convert array to list
        string[] animals = { "parrot", "komodo dragon", "cat" };
        List<string> animalList = new List<string>(animals);

        // clear
        animalList.Clear();

        // create a class list
        List<Sinif> sinifList = new List<Sinif>();
        Sinif kullanici = new Sinif();
        kullanici.Name = "ecrin";
        kullanici.Surname = "bal";
        kullanici.Age = 6;

        Sinif kullanici2 = new Sinif();
        kullanici2.Name = "mesut";
        kullanici2.Surname = "tembel";
        kullanici2.Age = 52;

        sinifList.Add(kullanici);
        sinifList.Add(kullanici2);

        List<Sinif> newList = new List<Sinif>();
        newList.Add(new Sinif()
        {
            Name = "deniz",
            Surname = "gök",
            Age = 32
        });

        foreach (Sinif item in sinifList)
        {
            Console.WriteLine("customer name : " + item.Name);
            Console.WriteLine("customer surname : " + item.Surname);
            Console.WriteLine("customer age : " + item.Age);
        }
    }

    public class Sinif
    {
        private string name = "";
        private string surname = "";
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}