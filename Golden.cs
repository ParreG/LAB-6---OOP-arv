using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6___OOP_arv
{
    public class Golden : Dog
    {
        public string Bath { get; set; }
        public Golden(string bath, string likesToDo, string type, string name, int age, string bread, int teeths, int legs, string food, string sound) : base(likesToDo, type, name, age, bread, teeths, legs, food, sound)
        {
            Bath = bath;
        }

        public void bath()
        {
            Console.WriteLine("Golden Retrivern badar!");
        }
    }
}
