using System;

class Kvadrants{
    static void Main(){
        int x = 0;
        int y = 0;

        Console.WriteLine("Löydä xy-akseleilla olevan pisteen kvadrantti: \nX-koordinaatti: \n");
        x = int.Parse(Console.ReadLine);
        Console.WriteLine("Y-koordinaatti: ");
        y = int.Parse(Console.ReadLine);
        Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on origossa.");
        
    }
}