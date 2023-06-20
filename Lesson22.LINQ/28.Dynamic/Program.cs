delegate dynamic MyDelegate(dynamic argument);

class Program
{
    static dynamic Method(dynamic argument)
    {
        return argument;
    }

    static void Main()
    {
        dynamic myDelegate = new MyDelegate(Method);

        dynamic @string = myDelegate("Hello world!");

        Console.WriteLine(@string);

        // Delay.
        Console.ReadKey();
    }
}