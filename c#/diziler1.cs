string[] diller = new string[3];
string[] pdiller = { "C", "C++", "Java", "Python", "Javascript" };
int[] dizi;
dizi = new int[6];

//değer atama
diller[0] = "Türkçe";
Console.WriteLine(pdiller[0]);
dizi[2] = 10;
Console.WriteLine(dizi[0]);

//döngülerle dizi
Console.Write("eleman sayısı : ");
int esayi = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[esayi];
float toplam = 0;
for (int i = 0; i < esayi; i++)
{
    Console.Write("{0}. sayı : ", i+1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayilar[i];
}
Console.WriteLine("ortalama : {0}", toplam / sayilar.Length);