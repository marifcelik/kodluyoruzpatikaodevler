//Implicit Conversion (Bilinçsiz Dönüşümler)

byte a = 2;
short b = a;
int c = a + b;
Console.WriteLine("c : {0}", c);

string ad1 = "iyi";
char v = ',';
string ad2 = " kötü ve çirkin";
int i = 3;

object tam = ad1 + v + ad2 + " " + i;
Console.WriteLine(tam);
Console.WriteLine("\n");

//Explicit Conversion (Bilinçli Dönüşümler)

int integer = 5;
byte bayt = (byte)integer;
Console.WriteLine(bayt + "\t" + bayt.GetType().ToString());

float flo = 10.3f;
byte bf = (byte)flo;
Console.WriteLine(bf + "\t" + bf.GetType().ToString());

int i2 = 5;
double di = (byte)i2;
Console.WriteLine(di + "\t" + di.GetType().ToString());

//ToString() yukarıda kullandım

//Convert

float ff = 12.912f;
double dd = 1.92;
int fd = Convert.ToInt32(ff) + Convert.ToInt32(dd);
Console.WriteLine("\n" + "convert : " + fd);

//Parse
parseMethodu();

static void parseMethodu()
{
     string s1 = "10";
     string s2 = "22.45";
     int r1;
     double d1;
     r1 = Int32.Parse(s1);
     d1 = Double.Parse(s2);
     Console.WriteLine("s1 parse : " + r1);
     Console.WriteLine("s2 parse : " + d1);
}