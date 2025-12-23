string s;
Console.WriteLine("Enter a number:");
s = Console.ReadLine();

//Try Parse
bool b = int.TryParse(s, out int n);

if (b == true)
{
    Console.WriteLine("Conversion is successful");
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Conversion failed");
}