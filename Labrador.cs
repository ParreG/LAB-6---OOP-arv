using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6___OOP_arv
{
    public class Labrador : Dog
    {
        public bool Snore { get; set; }
        public Labrador(bool snore, string likesToDo, string type, string name, int age, string bread, int teeths, int legs, string food, string sound) : base(likesToDo, type, name, age, bread, teeths, legs, food, sound)
        {
            Snore = snore;
        }

        public void snoring()
        {
            if (Snore == true)
            {
                Console.WriteLine("Labradorn snarkar!");
            }
            else
            {
                Console.WriteLine("Labradorn snarkar inte!");
            }
            
        }
    }
}
