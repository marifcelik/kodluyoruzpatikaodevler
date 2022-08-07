internal class Program
{
    private static void Main(string[] args)
    {
        int n = takePositiveNum("kaç adet sayı girilecek ? (n) : ");
        int m = takePositiveNum("ikinci sayı (m) : ");
        string esit = "m' e eşit olanlar :";
        string tam = "m' e tam bölünenler :";

        for (int i = 0; i < n; i++)
        {
            int sayi = takePositiveNum(i + 1 + ". sayıyı girin : ");
            if (sayi == m)
            {
                esit += " " + (i + 1) + ". sayı,";
                continue;
            }
            tam += m % sayi == 0 ? " " + sayi : "";
        }

        Console.WriteLine(esit);
        Console.WriteLine(tam);
    }

    static int takePositiveNum(string message)
    {
        int num;
        do
        {
            Console.Write(message);
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (num < 1);

        return num;
    }
}