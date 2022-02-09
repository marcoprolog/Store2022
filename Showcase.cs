using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2022
{
    class Showcase
    {
        Game[] games;

        public Showcase(int size)
        {
            games = new Game[size];
        }

        public Game Peek(int index)
        {
            if (index >= 0 && index < games.Length)
                return games[index];
            else
                return null;
        }

        public void Add(int index, Game game)
        {
            if (index >= 0 && index < games.Length)
                games[index] = game;
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < games.Length)
                games[index] = null;
        }

        public string PrintGames()
        {
            string print = "";
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i] != null)
                    print += "["+i+"] " + games[i].GiveGameDescription() + "\n";
            }
            return print;
        }
    }
}
