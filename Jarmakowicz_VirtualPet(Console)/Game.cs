using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmakowicz_VirtualPet_Console_
{
    class Game
    {
        private Player player;

        public Game()
        {
            Title();
            Menu();
        }

        private void Title()
        {
            Console.WriteLine("Amazing Title");
            Console.WriteLine("lets get started");
        }

        private void Menu()
        {
            Console.WriteLine("Name?");
            string input = Console.ReadLine();
            player = new Player(input);

            Console.WriteLine("What kind of pet do you want?");
            Console.WriteLine("1) Dog");
            Console.WriteLine("2) Cat");
            Console.WriteLine("3) Bird");

            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                player.pet = new Dog();
            }

            if (choice == 2)
            {
                player.pet = new Cat();
            }
            Console.WriteLine("pet name?");
            input = Console.ReadLine();
            player.pet.name = input;




            Console.WriteLine(player.pet.name +" says " + player.pet.Talk());
            player.pet.Sleep();
        }
    }
}
