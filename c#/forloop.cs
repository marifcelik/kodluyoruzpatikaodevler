//tek sayıları yazdırma
Console.Write("sayı girin : ");
int sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= sayi; i++)
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

//1 - 1000 arası tek çift sayı toplamı
int ctoplam = 0;
int ttoplam = 0;
for (int i = 0; i <= 1000; i++)
{
    if (i % 2 == 0)
        ctoplam += i;
    else
        ttoplam += i;
}
Console.WriteLine("1-1000 arası sayıların toplamı\ntek : {0}\nçift : {1}", ttoplam, ctoplam);


// break, continue
for (int i = 1; i < 10; i++)
{
    if (i==4)
      continue;
    if (i==8)
      break;
    Console.WriteLine(i);
}