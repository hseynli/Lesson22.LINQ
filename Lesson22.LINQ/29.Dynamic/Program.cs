class Base
{
    public dynamic field;

    public dynamic Method()
    {
        return this.field;
    }
}

class Derived : Base
{

}

class Program
{
    static void Main()
    {
        dynamic instance = new Derived();

        // Dinamik sahələr istifadədən əvvəl hər-hansı dəyərə mənimsədilməlidir..
        instance.field = "Hello";

        Console.WriteLine(instance.Method());

        // Delay.
        Console.ReadKey();
    }
}