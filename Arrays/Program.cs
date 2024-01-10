string data = "Imad,Maha,Ahmed,Zianb,Zahraa,Shams";
string[] fattalFamily = data.Split(',');

foreach (var person in fattalFamily )
{
    Console.WriteLine(person);
}