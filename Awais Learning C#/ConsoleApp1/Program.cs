using System;
using System.Linq;
using System.Security.AccessControl;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {

      Cars myObj = new Cars();
      Console.WriteLine(myObj.colour);
      
      

    }

    static void arraysTu(){
            //Arrays
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Audi", "Toyota", "Nissan", "Mercedes"};

      cars[0] = "Range Rover";
      Console.WriteLine("Volvo has been chnaged to " + cars[0]);
      Console.WriteLine("The length of the array is " + cars.Length + " cars");

      //sorting arrays
      foreach(string b in cars){
        Console.WriteLine("Cars before sorting - " + b);
      }

      Array.Sort(cars);

      foreach(string i in cars){
        Console.WriteLine("Cars after sorting - " + i);
      }

      //creating a int array
      int[] myNumber = new int[] {3, 5, 7, 3, 2, 6, 1, 5, 9, 8, 5, 1, 5, 4};

      //Linq methods
      //max
      Console.WriteLine("Biggest number in array is - " + myNumber.Max());
      //min
      Console.WriteLine("Smallest number in array is - " + myNumber.Min());
      //sum
      Console.WriteLine("The sum of array is - " + myNumber.Sum());

      //Multi dimesional arrays
      //initilising a 2d array u have 1 , in the braket - [,]
      //initilising a 3d array u have 2 , in the braket - [,,]
      //you add more ,'s for more dimensions

      int[,] numbers = {{1, 4, 2}, {3, 6, 8}};
      Console.WriteLine("This is the output of [0,2] - " + numbers[0, 2]);

      //chanign an item
      numbers[1, 0] = 9;

      Console.WriteLine("Chnaged 3 to - " + numbers[1,0]);

      //looping through a 2d array using for each
      foreach(int d in numbers){
        Console.WriteLine(d);
      }

      //looping thorugh a 2d array using a for loop
      for(int a = 0; a < numbers.GetLength(0); a++){
        for(int b = 0; b < numbers.GetLength(1); b++){
          Console.WriteLine("Elements are - " + numbers[a,b]);
        }
      }
    }

    static void loopsTut(){
            
      //loops
      //while loop basic
       int i = 0;
       int j = 0;
       while( i < 5){
        Console.WriteLine(i);
        i++;
       }

       //do while loop
       do{
        
        Console.WriteLine(j);
        j++;

       }
       while(j < 5);

       //for loops example 1
       for(int k = 0; k < 5; k++){
        Console.WriteLine("This is k - " + k);
       }

       for (int f = 0; f <= 10; f = f + 2){
        Console.WriteLine("This is f - " + f);
       }

       //nested loops
       for(int n = 0; n <= 2; ++n){
        Console.WriteLine("This is the outer loop and n = " + n);
        for(int g = 1; g <= 3; g++){
          Console.WriteLine("This is the inner loop and g = " + g);
        }

        //for each loop is used to loop through arrays
        //first create an array
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Audi", "Toyota", "Nissan", "Mercedes"};

        //now the for each loop
        foreach(string c in cars){
          Console.WriteLine("Car brand is - " + c);
        }

       }
    }

    static void userInput(){

      Console.WriteLine("Enter Username");
      String userName = Console.ReadLine();

     Console.WriteLine("You username is " + userName);
     Console.WriteLine("Enter your age: ");

      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Your age is - " + age);

    }

    static void ifAndSwitch(){
            int myAge = 23;
      int votingAge = 18;
      

      if(myAge >= votingAge){
        Console.WriteLine("Old enough to vote");
      }
      else{
        Console.WriteLine("Too young to vote");
      }

      //now shorthand if statment

      string canVote = (myAge > votingAge) ? "Can vote" : "Cannot Vote";
      Console.WriteLine(canVote);

      //switch statments
      Console.WriteLine("Enter Day");
      int day = Convert.ToInt32(Console.ReadLine());

      switch(day)
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
        default:
          Console.WriteLine("Day not entered");
          break;
      }
    }

    static void tut1(){
            const double pi = 3.14; //fixed variable that cant be changed
      int x =10, y = 6, z = 50;

      string hello = "Hello";

      Console.WriteLine("Hello World! " + pi);  

      //Console.WriteLine("Enter Username");
      //String userName = Console.ReadLine();

      //Console.WriteLine("You username is " + userName);
     // Console.WriteLine("Enter your age: ");

      //int age = Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine("Your age is - " + age);

      //userInput
      //userInput();

      Console.WriteLine(hello[1]);  //accessing strings
      Console.WriteLine(hello.IndexOf("o"));  //accessing strings
      Console.WriteLine(hello.IndexOf("f"));  //accessing strings   //error becasue f doesnt exist

      //substrings
      String name = "Awais Tasleem";

      //location of letter T
      int charPos = name.IndexOf("T");

      //get last name
      string lastName = name.Substring(charPos);

      Console.WriteLine(lastName);
    }
  }

}