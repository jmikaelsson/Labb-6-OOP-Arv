using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
    internal abstract class Animal
    {
        public string Speeches { get; set; }
        public string Origin { get; set; }
        public double Population { get; set; }
        public string Eat { get; set; }
        public string Mammal { get; set; }

        public Animal(string speeches = "arter", string origin  ="ursprung", double population = 1, string eat ="äter", string mammal="däggdjur")
        {
            Speeches = speeches;
            Origin = origin;
            Population = population;
            Eat = eat;
            Mammal = "Däggdjur";
        }
        public abstract void AnimalSort();
        public abstract void MakeSound();
        public abstract void PrintInfo();
        public abstract void FunFact();




    }
}
