// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.XPath;
using ClassesAndObjects;
using Microsoft.VisualBasic;

internal class Program
{

  static int[,] matrix = {
    {1,2,3}, 
    {4,5,6}, 
    {7,8,9}
    };
 static void Main(string[] args) {
  foreach (int item in matrix) {
    Console.WriteLine(item);
  }

  for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
      Console.WriteLine(matrix[i, j]);
    }
  }

  Car myCar = new Car();
  Car audi = new Car("audi", 350);
  Car bmw = new Car("bmw");
  audi.Drive("audi");
  audi.Details();
  myCar.setName("Ford");
  myCar.Colour = "Green";
  Console.WriteLine(myCar.getName());
  Console.WriteLine(myCar.getHp());
  myCar.maxSpeed = 180;
  Console.WriteLine("My car max speed is " + myCar.maxSpeed);
  myCar.Details();

  Console.WriteLine("Press 1 to stop car");
  string userInput = Console.ReadLine();
  if (userInput == "1") {
    audi.Stop("audi");
  }
    }
}

