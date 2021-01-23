using System;
using System.Collections.Generic;
using System.Text;

namespace StenSaxPåse
{
    public class GameEngine
    {
        public string SelectWinner(Player player, Computer computer)
        {
            if (computer.Choice == player.Choice)
            {
                return "Oavgjort";
            }
            if (player.Choice == "Sten" && computer.Choice == "Sax")
            {
                return "Spelare";
            }
            if (player.Choice == "Sax" && computer.Choice == "Påse")
            {
                return "Spelare";
            }
            if (player.Choice == "Påse" && computer.Choice == "Sten")
            {
                return "Spelare";
            }
            return "Dator";
        }
    }
}
