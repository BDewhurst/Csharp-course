// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic;

public class Lecture {
    int age = 15;
    string myname = "brad";
    double myDouble = 13.37;
    float myFloat = 13.23f;
    
    int myInt;
    public void DisplayAge() {
        Console.WriteLine("Hello, Dennis!");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("My name is " + myname);
        Console.WriteLine(myname.ToUpper());
        myInt = (int)myDouble;
        Console.WriteLine(myInt);

    }

   // public static void Main(string[] args) {
    //    Lecture lecture = new Lecture();
      //  lecture.DisplayAge();
   // }
}

public class Assignment1 {
       public static void Main(string[] args)
    {   
       string stringForFloat = "0.85"; // datatype should be float
       string stringForInt = "12345"; // datatype should be int
       float floatValue = float.Parse(stringForFloat);
       int intValue = int.Parse(stringForInt);
        Console.WriteLine(intValue);
        Console.WriteLine(floatValue);
    }  
}
