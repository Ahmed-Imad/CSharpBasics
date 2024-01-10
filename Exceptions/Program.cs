
try
{
    BadCall();
}
catch (Exception ex)
{

    Console.WriteLine("there was an exception in our app");
    Console.WriteLine(ex.Message);
}

Console.ReadLine();

 static void BadCall()
{
    int[] numbers = new int[] { 1, 5, 6 };

    for (int i = 0; i <= numbers.Length; i++)
    {
        try
        {
            Console.WriteLine(numbers[i]);
        }
        catch (Exception ex)
        {

            Console.WriteLine("We have an error!");
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}