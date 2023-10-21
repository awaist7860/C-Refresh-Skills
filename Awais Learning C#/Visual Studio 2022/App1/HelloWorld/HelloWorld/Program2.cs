using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program2
    {

        public string model;
        public string colour;
        public int year;

        private string fName = "Awais";
        string lNmae = "Tasleem";   //no access modifier means the varibale is private by default
        int age = 23;
        bool hasCar = true;

        public Program2(string modelName, string colourName, int yearName)
        {
            model = modelName;
            colour = colourName;
            year = yearName;
        }

        public void fullThrottle()
        {
            Console.WriteLine("The car is going full throttle");
            Console.WriteLine("This is fName varibale from Program2 Class - " + fName);
            Console.WriteLine("Program2 Class");
        }

        //GETTERS
        public string getlName() {
            return lNmae;
        }
        public int getAge()
        {
            return age;
        }

        public bool getHasCar()
        {
            return hasCar;
        }

        //SETTERS
        public void setlName(string enterLname)
        {
            lNmae = enterLname;
        }

        public void setAge(int Age)
        {
            age = Age;
        }

        public void setHasCar(bool HasCar)
        {
            hasCar = HasCar;
        }

        //now short hand for getters and setters
        public string name
        {

            get { return lNmae; }
            set { lNmae = value; }
        }

        public int newAge
        {
            get { return age; }
            set { age = value; }
        }

        public bool newHasCar
        {
            get { return hasCar; }
            set { hasCar = value; }
        }

    }
}
