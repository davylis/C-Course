using System;
using System.IO;

class FileReading{
    static void Main(string [] args){
        if (args.Length == 0){
            Console.WriteLine("Ei tiedostonimeä!");
            return;
        }

        string file = args[0];
        if(!File.Exists(file)){
            Console.WriteLine("Tiedostoa ei löydy!");
            return;
        }
        string content = File.ReadAllText(file);
         Console.Write(content);
    }
}