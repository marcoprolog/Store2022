using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2022
{
    class DLC
    {
        string name;
        float price;
        int metacriticScore;
        string description;
        //bool hasBaseGame; //maybe in a User class
        Game baseGame;

        public DLC(string name, string description, float price, Game baseGame)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.baseGame = baseGame;
        }
    }
}
