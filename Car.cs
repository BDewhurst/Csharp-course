using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        //constructor

        private string _name; 
        private int _hp;
        public Car(string name, int hp = 0) {
            _name = name; 
            Console.WriteLine( name + " was created");
            _hp = hp;
        }
        public void Drive(string name) {
            _name = name;
            Console.WriteLine(name + " is driving");
        }
        public void Stop(string name) {
            _name = name;
            Console.WriteLine( name + " has stopped");
        }

        public void Details () {
            
            Console.WriteLine("the " + _name + " has " + _hp + "hp");
        }
    }
}