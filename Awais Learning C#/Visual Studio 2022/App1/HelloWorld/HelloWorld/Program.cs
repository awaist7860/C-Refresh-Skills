using HelloWorld;
using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {

        enum Dificulty
        {
            Easy,   //0
            Normal, //1
            Hard    //2
                //enum index stars from 0
        }

        static void Main(string[] args)
        {

            //files
            string writeText = "Hello World from Visual Stuido text";   //creates a text string to enter into a file

            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);

        }

        static void interfaceAndEnumsTut()
        {
            Dog myDog = new Dog();
            myDog.animalSound();
            myDog.sleep();

            Cat myCat = new Cat();
            myCat.animalSound();

            DemoClass myDemoClass = new DemoClass();
            myDemoClass.myMethod();
            myDemoClass.myMethod2();

            //eneum
            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);

            Dificulty dificulty = Dificulty.Hard;
            Console.WriteLine(dificulty);

            int count = (int)Level.High;
            Console.WriteLine(count);

            //enum in switch statement

            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
        }

        static void inheritienceAndPolymorTut()
        {
            //the animal class and sub classes cat and dog

            Animal myAnimal = new Animal();
            //Animal myDog = new Dog();
            //Animal myCat = new Cat();

            //this will give the same out put for all 3 if the animalSound method in the Animal parent class is not made virtual and make the child classed ovveride functions

            myAnimal.animalSound();
            //myDog.animalSound();
            //myCat.animalSound();
        }

        static void classesTut()
        {
            Console.WriteLine("Hello World!");

            Program2 newClass = new Program2("Toyota", "Yellow", 2011);
            newClass.fullThrottle();
            Console.WriteLine(newClass.model + " " + newClass.colour + " " + newClass.year);
            //Console.WriteLine(newClass.fName);    protection level issue due to varibale fName being private
            Console.WriteLine("lName - " + newClass.getlName() + " Age - " + newClass.getAge() + " hasCar - " + newClass.getHasCar());

            //calling the setters now
            newClass.setlName("Safeer");
            newClass.setAge(45);
            newClass.setHasCar(false);

            Console.WriteLine("lName - " + newClass.getlName() + " Age - " + newClass.getAge() + " hasCar - " + newClass.getHasCar());

            //now using shorthad getters
            Console.WriteLine("lName - " + newClass.name + " Age - " + newClass.newAge + " hasCar - " + newClass.newHasCar);

            //calling shortand setter
            newClass.name = "Tabassum";
            newClass.newAge = 47;
            newClass.newHasCar = true;

            //now using shorthand getters
            Console.WriteLine("lName - " + newClass.name + " Age - " + newClass.newAge + " hasCar - " + newClass.newHasCar);

            Cars myCar = new Cars();

            myCar.honk();   //calling method from the Vehicle class which is a parent to the Cars class

            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            /*            Program2 Ford = new Program2();

            Ford.model = "Mustang";
            Ford.colour = "Red";
            Ford.year = 1969;

            Program2 Opel = new Program2();
            Opel.model = "Astra";
            Opel.colour = "White";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);*/
        }

    }
}