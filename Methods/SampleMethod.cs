namespace Methods;

public static class SampleMethod
{
    public static void SayHi()
    {
        Console.WriteLine("Hello User.");
    }

    public static void GoodBye()
    {
        Console.WriteLine("Good bye user.");
        Console.WriteLine("Thank you for choose us.");
    }

    public static void WordCounter (string count)
    {
        int wordsCount = count.Split(' ').ToList().Count();
        Console.WriteLine($"The number of words in sentance are {wordsCount}");
    }
}
