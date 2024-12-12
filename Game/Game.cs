using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1.Games
{
    class Game
    {
        public string Index { get; set; }
        public static int GameIndex = 1234567890;
        public string OpponentName { get; set; }
        public string Result { get; set; }
        public int Rating { get; set; }

        public Game(string opponentName, string result, int rating)
        {
            this.Index = GameIndex.ToString();
            GameIndex++;
            OpponentName = opponentName;
            Result = result;
            Rating = rating;
        }
    }
}
