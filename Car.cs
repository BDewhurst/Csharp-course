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
        private string _colour;

        public string Colour { 
        get {
            return _colour;
        } set {
            _colour = value;

        }
        }

        public void setName(string name) {
            _name = name;
        }

        public string getName() {
            return _name;
        }

        public int getHp() {
            return _hp;
        }
        public Car(){
            _name = "Car";
            _hp = 0;
            _colour = "red";

        }
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
            
            Console.WriteLine("the " + _name + " has " + _hp + "hp and the colour is " + _colour );
        }
    }
}