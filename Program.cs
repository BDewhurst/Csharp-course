// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.XPath;
using ClassesAndObjects;
using Microsoft.VisualBasic;

internal class Program
{
 static void Main(string[] args) { 
  Car audi = new Car();
  audi.Drive();
  Console.WriteLine("Press 1 to stop car");
  string userInput = Console.ReadLine();
  if (userInput == "1") {
    audi.Stop();
  }
    }
}

