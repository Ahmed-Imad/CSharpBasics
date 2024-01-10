
namespace InstantiatedClassesDemo;

public static class ProcessPerson
{
    public static void GreetPerson(PersonModel person)
    {
        Console.WriteLine($"Hello {person.LastName}");
        person.HasBeenGreeted = true;
    }
}
