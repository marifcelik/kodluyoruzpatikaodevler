string cumle;

Console.Write("kelimeyi girin : ");
cumle = Console.ReadLine() ?? "boş değer";


string[] kelimeler = cumle.Split(' ');
int kelimeSayisi = kelimeler.Length;

string harfler= String.Join("", kelimeler);
int harfSayisi = harfler.Length;

Console.WriteLine("kelime sayısı : " + kelimeSayisi);
Console.WriteLine("harf sayısı : " + harfSayisi);