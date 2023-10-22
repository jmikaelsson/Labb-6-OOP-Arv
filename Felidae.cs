using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
    internal abstract class Felidae : Animal
    {
        public int MaxSpeed { get; set; }

        public Felidae(string speeches, string origin, double population, string eat, int maxSpeed)
            : base(speeches, origin, population, eat)
        {
            MaxSpeed = maxSpeed;
        }

        public override abstract void AnimalSort();



        public override abstract void FunFact();


        public override abstract void MakeSound();


        public override abstract void PrintInfo();

        public abstract void Hunting();

    }
}
