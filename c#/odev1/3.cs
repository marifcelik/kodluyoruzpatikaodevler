internal class Program
{
    private static void Main(string[] args)
    {
        int n = takePositiveNum("kaç adet kelime girilecek ? : ");
        string[] kelimeler = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. kelimeyi girin : ", i + 1);
            string kelime = Console.ReadLine() ?? "boş değer";
            kelimeler[i] = kelime;
        }

        Array.Reverse(kelimeler);
        foreach (string kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }
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