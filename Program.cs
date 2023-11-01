// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic;

public class Lecture {
    int age = 15;
    string myname = "brad";
    double myDouble = 13.37;
    int myInt;
    public void DisplayAge() {
        Console.WriteLine("Hello, Dennis!");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("My name is " + myname);
        Console.WriteLine(myname.ToUpper());
        myInt = (int)myDouble;
        Console.WriteLine(myInt);

    }

    public static void Main(string[] args) {
        Lecture lecture = new Lecture();
        lecture.DisplayAge();
    }
}
