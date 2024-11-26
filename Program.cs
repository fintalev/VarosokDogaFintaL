using VarosokDogaFintaL;
List<VarosClass> varosok = [];

StreamReader sr = new StreamReader(@"..\..\..\src\varosok.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    varosok.Add(new VarosClass(sr.ReadLine()));
}
sr.Close();
//+
Console.WriteLine(varosok.Count);
//1
Console.WriteLine($"{varosok.Where(v=>v.Orszag=="Kína").Sum(v=>v.Nepesseg)} millió fő él kínai nagyvárosokban");
//2
Console.WriteLine($"Indiai városok átlag lélekszáma: {varosok.Where(v=>v.Orszag=="India").Average(v=>v.Nepesseg)}");
//3
Console.WriteLine($"A legnépesebb nagyváros: {varosok.OrderByDescending(v=>v.Nepesseg).First()}");
//4
var legnepesebbvarosok = varosok.OrderByDescending(v => v.Nepesseg).Where(v => v.Nepesseg > 20);
Console.WriteLine("20m fő feletti legnépesebb városok:");
foreach (var item in legnepesebbvarosok)
{
    Console.WriteLine(item);
}
//5
Console.WriteLine($"Országok száma amik többször is szerepelnek: {varosok.GroupBy(v=>v.Orszag).Where(v=>v.Count()>1).Count()} db");
//6
var kezdobetu = varosok.GroupBy(v => v.Varos[0]).OrderByDescending(group => group.Count()).FirstOrDefault();
Console.WriteLine($"A legtöbb város neve '{kezdobetu.Key}' betűvel kezdődik, és {kezdobetu.Count()} ilyen város van.");