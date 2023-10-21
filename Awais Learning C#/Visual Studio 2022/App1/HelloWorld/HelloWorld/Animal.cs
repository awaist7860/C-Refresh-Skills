using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Animal
    {

        //parent class (base class)
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
