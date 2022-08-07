Console.Write("sayı : ");
try
{
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("girdiğiniz sayı : " + i);
}
catch (Exception ex)
{
    Console.WriteLine("hata : " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("finally çalıştı");
}

//try 2
try
{
    // int a = Int32.Parse(null); //null
    // int b = int.Parse("deneme"); //format
    byte c = byte.Parse("256"); //overflow
}
catch(ArgumentNullException ex)
{
    Console.WriteLine("hata a : ");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("hata : ");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("hata : ");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("ikinci finally çalıştı");
}