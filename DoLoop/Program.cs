bool isValidAge;
int counter = 0;

do
{
    Console.Write("What's your age? ");
    string? ageText = Console.ReadLine();
    isValidAge = int.TryParse(ageText, out int age);

    if (!isValidAge && counter < 3)
    {
        counter++;
        Console.WriteLine("You entered an invalid number. Please try again.");
    }
    else if (!isValidAge)
    {
        Console.WriteLine("Too many invalid attempts. Exiting the loop.");
        break;  // exit the loop after three invalid attempts
    }

} while (!isValidAge);
