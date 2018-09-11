using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmakowicz_VirtualPet_Console_
{
    class Pet
    {
        public string name;
        public bool isAwake;

        public Pet()
        {
            isAwake = true;
        }

        public virtual string Talk()
        {
            return "Hello!";
        }

        
        public void Sleep()
        {
            if (isAwake)
            {
                isAwake = false;
                Console.WriteLine(name + " goes to sleep!");
            }
            else
            {
                isAwake = true;
            }
               
        }
    }
}
