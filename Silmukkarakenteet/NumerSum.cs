using System;

class Program{
    static void Main(string[] args){
        int sum=0;
        Console.Write("Summa on nyt 0. Syöte: ");
        int num = int.Parse(Console.ReadLine());
         sum+=num;
        while(sum<201){
            Console.Write("Summa on nyt " + sum + ". Syöte: ");
            num = int.Parse(Console.ReadLine());
            sum+=num;
        }

        Console.WriteLine("Saavutettiin 200. Summa oli " + sum + ".");
    }
}