Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());

Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(3));
Console.WriteLine(DateTime.Now.AddYears(1));
Console.WriteLine(DateTime.Now.AddMinutes(1));
Console.WriteLine(DateTime.Now.AddMilliseconds(1));

// format
Console.WriteLine();
Console.WriteLine(DateTime.Now.ToString("dd")); // 07
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sun
Console.WriteLine(DateTime.Now.ToString("dddd")); // Sunday

Console.WriteLine(DateTime.Now.ToString("MM")); // 07
Console.WriteLine(DateTime.Now.ToString("MMM")); // Aug
Console.WriteLine(DateTime.Now.ToString("MMMM")); // August

Console.WriteLine(DateTime.Now.ToString("yy")); // 22
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

// math
Console.WriteLine(Math.Abs(-13 + 5));
Console.WriteLine(Math.Sin(90));
Console.WriteLine(Math.Cos(90));
Console.WriteLine(Math.Tan(90));

Console.WriteLine(Math.Ceiling(12.4));
Console.WriteLine(Math.Round(12.4));
Console.WriteLine(Math.Floor(12.7));

Console.WriteLine(Math.Max(82,3));
Console.WriteLine(Math.Min(82,3));

Console.WriteLine(Math.Pow(5,3));
Console.WriteLine(Math.Sqrt(16));
Console.WriteLine(Math.Log(2));
Console.WriteLine(Math.Log10(10));
Console.WriteLine(Math.Exp(3));
