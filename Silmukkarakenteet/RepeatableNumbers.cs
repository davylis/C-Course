using System;

class Program{
    static void Main(string[] args){
        int n = 12;

        string row = "";
        for(int i = 1; i <= n; i++){
            row += i;
            Console.WriteLine(row);
            Console.WriteLine();
        }
    }
}