using System;
class BiggestNum{
    static void Main(){
        int num1 = 0;
        int num2 = 0;

        Console.Write("Syötä ensimmäinen numero: \n");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Syötä toinen numero: \n");
        num2 = int.Parse(Console.ReadLine());

        if(num1>num2){
            Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
        } else if(num1<num2){
            Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
        }else{
            Console.WriteLine("Numerot ovat yhtä suuret.");
        }
    }
}