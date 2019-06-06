using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRPG
{
    class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Tyler";
            CurrentPlayer.Gold = 2000;
            CurrentPlayer.Health = 10;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.Level = 1;
            CurrentPlayer.Experience = 0;
        }
    }
}
