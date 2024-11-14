using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6___OOP_arv
{
    public abstract class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bread { get; set; }
        public int Teeths { get; set; }
        public int Legs { get; set; }
        public string Food { get; set; }
        public string Sound { get; set; }

        public Animal(string type, string name, int age, string bread, int teeths, int legs, string food, string sound)
        {
            Type = type;
            Name = name;
            Age = age;
            Bread = bread;
            Teeths = teeths;
            Legs = legs;
            Food = food;
            Sound = sound;
        }
        public abstract void eat();
        public abstract void makeSound();
        public abstract void Information();
        
        
    }
}
