using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Dog : AbAnimal
    {
        public override void animalSound()
        {
            //The body of the animalSound() method is here from the AbAnimal parent class
            Console.WriteLine("The dog says woof!!!");
        }
    }
}
