// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.XPath;
using ClassesAndObjects;
using Microsoft.VisualBasic;

internal class Program
{
 static void Main(string[] args) {
  Car myCar = new Car();
  Car audi = new Car("audi", 350);
  Car bmw = new Car("bmw");
  audi.Drive("audi");
  audi.Details();
  myCar.setName("Ford");
  myCar.Colour = "Green";
  Console.WriteLine(myCar.getName());
  Console.WriteLine(myCar.getHp());
  myCar.Details();

  Console.WriteLine("Press 1 to stop car");
  string userInput = Console.ReadLine();
  if (userInput == "1") {
    audi.Stop("audi");
  }
    }
}

