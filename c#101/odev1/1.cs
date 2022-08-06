int n;
string cift = "Çift sayılar :";

do
{
    Console.Write("kaç adet sayı girilecek : ");
    n = Convert.ToInt32(Console.ReadLine());
}
while (n < 1);

for (int i = 0; i < n; i++)
{
    int sayi;
    do
    {
        Console.Write("{0}. sayıyı girin : ", i + 1);
        sayi = Convert.ToInt32(Console.ReadLine());
    }
    while (sayi < 1);
    cift += sayi % 2 == 0 ? " " + sayi : "";
}

Console.WriteLine(cift);