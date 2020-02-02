using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Game
    {
        public string GameName { get; set; }
        public int MaxNumPlayers { get; set; }

        public Game (string gameName, int maxNumPlayers)
        {
            GameName = gameName;
            MaxNumPlayers = maxNumPlayers;
        }

        public override string ToString()
        {
            return String.Format("Class info: {0}\nGame's Name: {1}\n Maximum Number of Player: {2}",
                                  GetType(), GameName, MaxNumPlayers);
                                
        }

    }
}
