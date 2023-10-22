using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv.Animlas
{
    internal class Donkey : Animal
    {

        public string  Crossing{ get; set; }

        public Donkey(string speeches, string origin, double population, string eat, string crossing) : base(speeches, origin, population, eat)
        {
            Crossing = crossing;
        }

        public override void AnimalSort()
        {
            Console.WriteLine($"Åsna" +
                $"\n{Mammal}"+
                "\n");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hee-haw");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("" +
                "\nSnabbfakta:" +
                "\n-----------"+
                
                $"\n* Åsnan härstammar från {Origin}." +
                $"\n* Det finns runt {Population} stycken åsnor i Sverige." +
                $"\n* Vanlig föda för en åsna är: {Eat}." +
                $"\n* Om man korsar en åsna med en häst, så heter det {Speeches}." +
                $"\n* Men om man korsar den med en zebra, heter det {Crossing}");
        }

        public override void FunFact()
        {
            Console.WriteLine("" +
               "\nLite roligt fakta om åsnor" +
               "\n--------------------------" +
               "\nÅsnan är ett av de viktigaste husdjuren, och har skildrats i många olika litterära sammanhang. "+
               "\nDen representerar både positiva egenskaper som flit och anspråkslöshet, och negativa egenskaper "+
               "\nsom envishet och dumhet. Åsnan är också maskot för demokratiska partiet i USA");
        }

        public void FamusDonkey()
        {
            Console.WriteLine("" +
                "\nKända åsnor" +
                "\n-----------"+
                "\nNågra av de kända åsnorna från film eller berättelsere är I-or i Nalle Puh, "+
                "\nÅsnan i Shrek-trilogin, " +
                "\noch åsnan i berättelsen om Stadsmusikanterna från Bremen av Bröderna Grimm.");
       
        }


    }
}
