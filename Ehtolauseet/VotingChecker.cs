using System;

class votingChecker{
    static void Main(){
        int age = 0;

        Console.Write("Syötä ikäsi, ole hyvä: \n");
        age = int.Parse(Console.ReadLine());

        if(age >= 18){
        Console.WriteLine("Voit äänestää!");
        }
    }
}