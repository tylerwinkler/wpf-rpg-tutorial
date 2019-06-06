using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRPG
{
    class Player : INotifyPropertyChanged
    {
        private string name;
        private string characterClass;
        private int level;
        private int experience;
        private int health;
        private int gold;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string CharacterClass
        {
            get
            {
                return characterClass;
            }
            set
            {
                characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                OnPropertyChanged("Level");
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
                OnPropertyChanged("Experience");
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                OnPropertyChanged("Health");
            }
        }

        public int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
