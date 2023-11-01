// See https://aka.ms/new-console-template for more information
using System;

public class Lecture {
    int age = 15;

    public void DisplayAge() {
        Console.WriteLine("Hello, Dennis!");
        Console.WriteLine("Age: " + age);
    }

    public static void Main(string[] args) {
        Lecture lecture = new Lecture();
        lecture.DisplayAge();
    }
}
