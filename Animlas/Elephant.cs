using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Labb_6_OOP_Arv.Animlas
{
    internal class Elephant : Animal
    {
        public int Age { get; set; }

        public Elephant(string speeches, string origin, double population,  string eat, int age ) : base(speeches, origin, population,  eat)
        {
            Age = age;
        }

        public override void AnimalSort()
        {
            Console.WriteLine($"Elephant" +
                $"\n{Mammal}"+
                "\n");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Tumpetar");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("" +
                "\nSnabbfakta:"+
                "\n-----------"+
                $"\n* Det finns {Speeches} arter av elefanter." +
                $"\n* Idag kan man hitta vilda elefanter i {Origin}." +
                $"\n* Idag finns det bara ungefär {Population} stycken vilda elefanter i världen." +
                $"\n* Vanlig föda för en elefant är {Eat}.");  
        }

        public override void FunFact()
        {
            Console.WriteLine("" +
                "\nLite roligt fakta om elefanter" +
                "\n------------------------------" +
                "\nAsiatiska elefanter har faktiskt setts plocka upp en jordnöt, skala den, blåsa iväg skalet och sedan äta nöten. "+
                "\nAllt med sin snabel!"+
                "\nSnabel består av omkring 40 000 (!) muskler – vi människor har runt 600 muskler i hela kroppen!");
        }
        public void WorldsOldest()
        {
            Console.WriteLine(""+
            "\nElefantens livslängd"+
            "\n--------------------"+
            $"\nEn elfant kan bli mycket gammal, runt {Age} år. "+
            "\nVärldens äldsta elefant hette Lin Wang och dog 2003 när hon var 86 år gammal i Taiwan");
        }

    }
}
