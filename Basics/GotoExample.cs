class Program
{
    static void Main()
    {
        int i = 1;
        Console.WriteLine("USA");
        Console.WriteLine("UK");
        Console.WriteLine("India");
        mylabel:
        Console.WriteLine("France");
        Console.WriteLine("Italy");
        Console.WriteLine("Iran");
        i++;
        if (i <= 5)
        {
            goto mylabel;
        }
        Console.WriteLine("Nepal");
        Console.WriteLine("Dubai");
    }
}