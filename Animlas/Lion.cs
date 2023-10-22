using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv.Animlas
{
    internal class Lion : Animal, IFelidae
    {

        public string Habitat { get; set; }



        public Lion(string speeches, string origin, double population, string eat, int maxSpeed, string habitat)
            : base(speeches, origin, population, eat, maxSpeed)
        {
            Habitat = habitat;

        }

        public override void AnimalSort()
        {
            Console.WriteLine($"Lion" +
                $"\n{Mammal}" +
                "\n");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roooawr");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("" +
            "\nSnabbfakta:" +
            "\n-----------" +
            $"\n* Det finns idag endast {Speeches} stycken olika arter av lejon kvar." +
            $"\n* Vilda lejon finns i idag kvar i {Origin}." +
            $"\n* Det är oäkert hur många lejon det finns i dag. Man tror att det finns {Population} stycken lejon i världen." +
            $"\n* Vanlig föda för ett lejon är: {Eat}." +
            $"\n* I korta spurter kan ett lejon nå upp till en hantighet på {MaxSpeed} km/h");

        }

        public override void FunFact()
        {
            Console.WriteLine("" +
                "\nLite roligt fakta om lejon:" +
                "\n---------------------------" +
                "\nTungan är sträv som sandpapper, lejon kan till och med slicka bort kött från skelett! Ett vuxet" +
                "\nlejon kan äta så mycket som 30 kg kött på en och samma gång. " +
                "\nDet är ungefär lika mycket som 526 grillkorvar (utan bröd alltså)!" +
                "\nNär de ätit vill de gärna chilla lite, och de kan vila 20 timmar per dygn. Riktiga latmaskar!" +
                "\nVisste du att ..." +
                "\nMan kan höra lejon ryta på över 8 kilometers avstånd.");


        }

        public override void Hunting()
        {
            Console.WriteLine("" +
                "\nJakt" +
                "\n____" +
                "\nLejon jagar oftast under natten eller på morgonen. Lejon föredrar även att jaga under storm " +
                "\noch oväder, då åskmuller och kraftig vind gör det svårt för potentiella byten att se och höra " +
                "\ndem. Under jakten strövar en individ eller en flock oftast långsamt genom reviret och letar efter" +
                "\nbyten. I regioner med bra tillgång till föda som Serengeti eller Nairobi nationalpark vandrar arten" +
                "\nbara 2 till 13 km per dag/natt. Vid Namibias kustlinje iakttogs däremot lejon som vandrade 50 km" +
                "\nper dag längs stranden för att fånga sälar. Arten gräver mer än andra stora kattdjur, bland annat" +
                "\nför att komma åt vårtsvin. Typiska bytesdjur är antiloper, gaseller, gnuer, afrikansk buffel och" +
                "\nzebror men även harar, fåglar och deras ägg, fiskar, ormar samt mindre krokodiler. I grupp kan de även" +
                "\nfälla större djur som afrikanska bufflar, elefanter och vuxna giraffer. Sällan är lejonet kannibaliskt.");
        }


        //new method, only in class-lion
        public void LionHabitat()
        {
            Console.WriteLine("" +
                "\nHabitat " +
                "\n----" +
                $"\nLejon är inte särskilt specialiserade vad gäller habitat. De föredrar {Habitat} men lever" +
                "\näven i torra skogar och i halvöken. Lejon undviker däremot täta och fuktiga skogar samt" +
                "\nvattenfattiga ökenområden.De är inte lika goda simmare som tigrar men trots detta dokumenteras" +
                "\nibland individer som korsar större floder. Arten har en tendens att vara aktiv  på natten. " +
                "\nBeroende på vädret, födotillgången, människan och andra faktorer kan lejonet flytta sin aktivitet" +
                "\ntill dagen.");
        }
    }
}
