using System;

class Tietotyypit
{
    static void Main()
    {

        short var1 = 123;
        byte var2 = 255;
        float var3 = 3.14f;
        char var4 = 'A';
        bool var5 = true;
        ulong var6 = 12345678901234567890UL;
        decimal var7 = 12345.67890m;



        Console.WriteLine("Var1 on tyyppiä " + var1.GetType());
        Console.WriteLine("Var2 on tyyppiä " + var2.GetType());
        Console.WriteLine("Var3 on tyyppiä " + var3.GetType());
        Console.WriteLine("Var4 on tyyppiä " + var4.GetType());
        Console.WriteLine("Var5 on tyyppiä " + var5.GetType());
        Console.WriteLine("Var6 on tyyppiä " + var6.GetType());
        Console.WriteLine("Var7 on tyyppiä " + var7.GetType());
    }
}
