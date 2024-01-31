// See https://aka.ms/new-console-template for more information
Console.WriteLine("Huomenta! Haluatko kirjautua (k) vai luoda uuden käyttäjän (u)?");

string vastaus = Console.ReadLine();

switch (vastaus)
{
    case "k":
        Console.WriteLine("Kirjaudu");
        break;
    case "u":
        Console.WriteLine("Luo käyttäjä");
        break;

    default:
}
