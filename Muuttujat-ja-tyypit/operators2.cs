using System;

class Program
{
    static void Main()
    {
        int x = 10;
        int z = 9;
        int y = 7;
        string s = "C";

        if (((x >= y) && (y < z)) || ((x > y) && (s == "A")) )
        {
            if (s == "C")
            {
                Console.WriteLine("Onnistui!");
            }
            else
            {
                Console.WriteLine("Melkein!");
            }
        }
        else
        {
            Console.WriteLine("Ei iha, yritä vielä!");
        }
    }
}