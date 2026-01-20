using System;

class BugLegGunGame{

    static void Main()
        {
            Random random = new Random();

            while(true){
                Console.WriteLine("Torakka-Jalka-Ydinase. Valitse 1-4.");
                Console.WriteLine("1) Torakka 2) Jalka 3) Ydinase 4) Poistu");

            int player;
            if(!int.TryParse(Console.ReadLine(), out player)){
                Console.WriteLine("Virheellinen valinta.\n");
                continue;
            }

            if (player == 4)
                break;

            if (player < 1 || player > 3){
                Console.WriteLine("Virheellinen arvo.");
            }

             int computer = random.Next(1, 4);

             string playerChoice = ChoiceToString(player);
             string computerChoice = ChoiceToString(computer);

             Console.WriteLine(player + " " + playerChoice + "!");

             if (player == computer){
                Console.WriteLine("Tietokone valitsi " + computerChoice + ". Tasapeli!\n");
             } else if (
                (player == 1 && computer == 2) ||
                (player == 2 && computer == 3) ||
                (player == 3 && computer == 1)
             ){
                Console.WriteLine("Tietokone valitsi " + computerChoice + ". Tietokone voitti!\n");
             }else{
                Console.WriteLine("Tietokone valitsi " + computerChoice + ". Voitit!\n");
             }
        }

        static string ChoiceToString(int choice){
            switch(choice){
                case 1: return "Torakka";
                case 2: return "Jalka";
                case 3: return "Ydinase";
                default: return "";
            }
        }
    }
}