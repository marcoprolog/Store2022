using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2022
{
    class Game
    {
        public float price;
        string name;
        Genre[] genre;
        bool esport = false;
        //bool isBought; //maybe in a User class
        int metacriticScore;
        string description;
        bool isMultiplayer;
        bool hasDlc;
        // ? what about dlcs?
        List<DLC> dlcs;

        public Game(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public Game(string name, string description, float price, bool multiplayer)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.isMultiplayer = multiplayer;
        }

        public string GiveGameDescription()
        {
            return name + "\n" + description + "\n" + price;
        }
    }

    enum Genre
    {
        FPS, Horror, Platformer, Survival, MMO, Puzzle, RPG, MOBA
    }
}
