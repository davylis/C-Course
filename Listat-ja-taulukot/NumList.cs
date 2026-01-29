using System;
using System.Collections.Generic;

class NumList
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Syötä numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                break;
            }

            numbers.Add(num);
        }

        Console.Write("Syöttämäsi numerot: ");
        foreach(int num in numbers){
        Console.Write(" " + num);
        }
    }
}