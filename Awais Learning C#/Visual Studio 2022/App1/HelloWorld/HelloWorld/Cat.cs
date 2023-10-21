using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Cat : IAnimal
    {
        public void animalSound()   //no need to override
        {
            //The body of the animalSound() method is here from the interface IAnimal parent class
            Console.WriteLine("The cat goes Meow Meow!!!");
        }
    }
}
