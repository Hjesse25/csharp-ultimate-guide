class Program
{
    static void Main()
    {
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 10);
        Console.WriteLine();

        i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);
        Console.WriteLine();

        i = 9;
        do
        {
            Console.WriteLine(i);
            i--;
        } while (i >= 0);
    }
}