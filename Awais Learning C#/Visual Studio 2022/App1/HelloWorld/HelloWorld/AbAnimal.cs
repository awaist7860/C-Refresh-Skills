﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    abstract class AbAnimal
    {
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("ZZZ!!!");
        }
    }
}
