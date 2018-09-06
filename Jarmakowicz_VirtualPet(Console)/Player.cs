using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmakowicz_VirtualPet_Console_
{
    class Player
    {
        public string Name;
        public int Score;
        public Pet pet;


        public Player(string _name)
        {
            Name = _name;
            //pet = new Pet();
            pet = new Dog();
            Score = 0;
        }
    }
}
