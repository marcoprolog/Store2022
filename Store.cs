using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2022
{
    class Store
    {
        //what should the store contain?
        public Showcase showcase;

        public Store()
        {
            showcase = new Showcase(6);
            showcase.Add(1, new Game("Inscryption", "Weird card game", 29.99f));
            showcase.Add(0, new Game("League of Legends", "very salty people", 0));
            showcase.Add(2, new Game("Heaven's Vault", "language/archeology narrative game", 15));
            showcase.Add(3, new Game("Civilization", "killer Ghandi", 40));
            showcase.Add(4, new Game("The Medium", "Haunted Poland simulator", 30.5f));
        }

        //what should the store do?
    }
}
