int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("ocak");
        break;
    case 2:
        Console.WriteLine("şubat");
        break;
    case 3:
        Console.WriteLine("mart");
        break;
    case 4:
        Console.WriteLine("nisan");
        break;
    default:
        Console.WriteLine("vs vs");
        break;
}

Console.WriteLine("switch 2");

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar");
        break;
}