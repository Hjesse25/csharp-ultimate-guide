class Sample
{
    static void Main()
    {
        sbyte a = sbyte.MaxValue;
        sbyte b = 100;
        sbyte c = default(sbyte);

        byte d = byte.MaxValue;
        short e = short.MaxValue;
        ushort f = ushort.MaxValue;
        int g = int.MaxValue;
        uint h = uint.MaxValue;
        long i = long.MaxValue;
        ulong j = ulong.MaxValue;
        float k = float.MaxValue;
        double l = double.MaxValue;
        decimal m = decimal.MaxValue;
        char n = 'A';
        string o = "abc";
        bool p = true;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(l);
        Console.WriteLine(m);
        Console.WriteLine(n);
        Console.WriteLine(o);
        Console.WriteLine(p);
    }
}