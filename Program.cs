using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            float userMoney = 25f;
            Console.WriteLine("Welcome to to our game store!");
            bool shouldContinue = true;
            do
            {
                Console.WriteLine("Available commands: show, buy, add, quit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "show":
                        Console.WriteLine(store.showcase.PrintGames());
                        break;
                    case "buy":
                        //ask the player what game they want to buy
                        Console.WriteLine("Which game would you like to buy? [Insert number]");
                        //read user input
                        string gameToBuy = Console.ReadLine();
                        //convert to int (note that it crashes if you don't input a number
                        int index = int.Parse(gameToBuy);
                        //(optional and currently unused) get the game we're about to remove
                        Game g = store.showcase.Peek(index);
                        //remove the game (the check if the index is valid is done within Showcase.Remove)
                        store.showcase.Remove(index);
                        break;
                    case "add":
                        // keep this for later
                        break;
                    case "quit":
                        shouldContinue = false;
                        break;
                    default:
                        Console.WriteLine("I don't understand that command");
                        break;
                }
            } while (shouldContinue);
        }
    }
}
