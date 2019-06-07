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
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {

                Name = "Tyler",
                Gold = 2000,
                Health = 10,
                CharacterClass = "Fighter",
                Level = 1,
                Experience = 0
            };

            CurrentLocation = new Location
            {
                Name = "Home",
                XCoordinate = 0,
                YCoordinate = 0,
                Description = "This is your house",
                ImageName = "/Engine;component/Images/Locations/Home.png"
            };
        }
    }
}
