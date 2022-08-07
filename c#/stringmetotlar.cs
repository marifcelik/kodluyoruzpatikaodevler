string degisken = "c sharp dersi";
string degisken2 = "c sharp dersleri";

Console.WriteLine(degisken.Length);

Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// concat
Console.WriteLine(String.Concat(degisken, "concat "));
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken, degisken2, true));
Console.WriteLine(String.Compare(degisken, degisken2, false));

//contains
Console.WriteLine(degisken.Contains("ders"));
Console.WriteLine(degisken.EndsWith("rsi"));
Console.WriteLine(degisken.StartsWith("hi"));

//indexof
Console.WriteLine(degisken.IndexOf('s'));
Console.WriteLine(degisken.IndexOf("kim"));
Console.WriteLine(degisken2.LastIndexOf('e'));

//insert
Console.WriteLine(degisken.Insert(1, " deneme"));

// pad
Console.WriteLine(degisken.PadLeft(30));
Console.WriteLine(degisken.PadLeft(30, '-'));

//remove
Console.WriteLine(degisken.Remove(7));
Console.WriteLine(degisken.Remove(2, 3));

//replcae
Console.WriteLine(degisken.Replace("c sharp", "c#"));

//split
Console.WriteLine(degisken.Split(' ')[1]);

//
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4, 2));
