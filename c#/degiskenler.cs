
int deger = 2;
Console.WriteLine(deger);

string degisken = "deger1";
string Degisken = "deger2";

Console.WriteLine(degisken);
Console.WriteLine(Degisken);

//sayısal veriler yazılacak (vazgeçtim - gerek yok)

//DateTime
DateTime dt = DateTime.Now;
Console.WriteLine(dt);

string tarih = dt.ToString("dd.MM.yyyy");
Console.WriteLine(tarih);

string saat = dt.ToString("HH:mm:ss");
Console.WriteLine(saat);

//object
object o1 = 'a';
object o2 = "deneme";
object o3 = 89;
object o4 = false;

//string
string str1 = String.Empty;
str1 = "arif";
string ad = "Arif";
string soyad = "Çelik";
String adsoyad = ad + " " + soyad;
Console.WriteLine(adsoyad);

//tür dönüşümü
string yil1 = "20";
int yil2 = 22;
Console.WriteLine(yil1 + yil2.ToString());
Console.WriteLine(Convert.ToInt32(yil1));

int parse = int.Parse(yil1) + yil2;
