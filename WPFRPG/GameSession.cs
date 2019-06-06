using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRPG
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Tyler";
            CurrentPlayer.Gold = 2000;
        }
    }
}
