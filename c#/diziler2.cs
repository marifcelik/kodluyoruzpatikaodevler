static void sirala(int[] dizi)
{
    foreach (int sayi in dizi)
        Console.Write(sayi + " ");
    Console.WriteLine();
}

//sıralama
int[] sdizi = { 10, 8, 36, 25, 21, 28, 9, 1 };
Console.WriteLine("-sırasız dizi-");
sirala(sdizi);
Array.Sort(sdizi);
Console.WriteLine("-sıralı dizi-");
sirala(sdizi);

//clear
Console.WriteLine("-clear-");
Array.Clear(sdizi, 2, 2);
sirala(sdizi);

//reverse
Console.WriteLine("-reverse-");
Array.Reverse(sdizi);
sirala(sdizi);

//indexof
Console.WriteLine("-index of-");
Console.WriteLine(Array.IndexOf(sdizi,21));

//resize
Console.WriteLine("-resize-");
Array.Resize<int>(ref sdizi, 12);
sdizi[11] = 99;
sirala(sdizi);
