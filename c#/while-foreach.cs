//ortalama bulma
Console.Write("sayı : ");
int sayi = Int32.Parse(Console.ReadLine());
int i = 1;
float toplam = 0;
while (i <= sayi)
{
    toplam += i;
    i++;
}
Console.WriteLine(toplam / sayi);

//a dan z ye kadar harfler
char c = 'a';
while (c <= 'z')
{
    Console.Write(c + " ");
    c++;
}

Console.WriteLine("\n****Foreach****");
string[] dizi = {"d1", "d2", "d3", "d4"};
foreach (string eleman in dizi)
{
    Console.WriteLine(eleman);
}