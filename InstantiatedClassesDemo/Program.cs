using InstantiatedClassesDemo;

List<PersonModel> people = new List<PersonModel>();
string? firstName = string.Empty;
string? lastName = string.Empty;

do
{
    Console.Write("What's your first name (Type exit to quit): ");
    firstName = Console.ReadLine();
    if (firstName == null || firstName.ToLower() =="exit")
    {    

        break;
    }
    else
    {
        Console.Write("What's your last name: ");
        lastName = Console.ReadLine();
    }
    if (firstName.ToLower() != "exit" && lastName.ToLower()!= "exit")
    {
        PersonModel person = new();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }
} while (firstName.ToLower() !="exit" && lastName.ToLower() != "exit");

foreach (PersonModel person in people)
{
    Console.WriteLine($"{ person.FirstName} {person.LastName}");
}

Console.ReadLine();
