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

        public void Add(int index, Game game)
        {
            games[index] = game;
        }

        public void Remove(int index)
        {
            games[index] = null;
        }

        public string PrintGames()
        {
            string print = "";
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i] != null)
                    print += games[i].GiveGameDescription() + "\n";
            }
            return print;
        }
    }
}
