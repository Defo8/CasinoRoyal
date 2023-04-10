using System;

namespace CasinoRoyal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            int pot = 0;
            Player player = new Player()
            {
                Name = "Player",
                Cash = 100
            };

            Console.WriteLine("Welcome to CasinoRoyale Del Mondo A'Sierra. Chance to lose is equale 0,75");
            while (true)
            {
                player.WriteMyInfo();
                Console.Write("Stake: ");
                string howMuch = Console.ReadLine();

                pot = 0;
                if (int.TryParse(howMuch, out pot))
                {
                    pot *= 2;
                }
                if(random.NextDouble() > odds)
                {
                    Console.WriteLine("...Win! :D");
                    player.ReceiveCash(pot);
                }
                else
                {
                    Console.WriteLine("...Lose :<");
                    player.GiveCash(pot/2);
                }

                if(player.Cash <= 0)
                {
                    break;
                }
            }
        }
    }
}
