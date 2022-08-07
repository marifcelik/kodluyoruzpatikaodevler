int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("günaydın");
else if (time <= 18)
    Console.WriteLine("iyi günler");
else
    Console.WriteLine("iyi akşamlar");

// string mesaj = time <= 18 ? "iyi günler" : "iyi akşamlar";

string mesaj = time >= 6 && time < 11 ? "günaydın" : time <= 18 ? "iyi günler" : "iyi akşamlar";
Console.WriteLine(mesaj);