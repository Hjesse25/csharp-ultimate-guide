class Sample
{
    static void Main()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("to");
        Console.WriteLine("C# Programming");

        Console.Write("Welcome");
        Console.Write("to");
        Console.Write("C# Programming");

        /*
            Wait for pressing some key on the keyboard

            Instructor uses below statement because he used Visual Studio
            which opens and closes the terminal when the program is executed
        */
        Console.ReadKey();

        //clear the screen
        Console.Clear();

        Console.WriteLine("Thank you.");
        Console.ReadKey();
    }
}