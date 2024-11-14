using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB_6___OOP_arv
{
    internal class Cat : Animal
    {
        public string LikesToDo { get; set; }


        public Cat(string likesToDo, string type, string name, int age, string bread, int teeths, int legs, string food, string sound)
            : base(type, name, age, bread, 30, legs, food, sound) // sätter defoult värde på antal tänder
        {
            LikesToDo = likesToDo;
        }

        public override void eat()
        {
            Console.WriteLine($"{Type} äter {Food}. GU va GÖÖTT.");
        }



        public override void makeSound()
        {
            Console.WriteLine($"{Name} säger {Sound}.");
        }

        public override void Information()
        {
            Console.WriteLine($"Detta djur är {Type} och heter {Name}. Den är {Age}år gammal." +
                $" Rasen för {Name} är {Bread} och den har {Teeths} tänder. Den går på {Legs} ben och dens favorit mat är {Food}. {Name} säger {Sound}");
        }

        public void play()
        {
            Console.WriteLine("Katten älskar att klättra väldigt högt.");
        }
    }
}
