using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv.Animlas
{
    internal class Tiger : Animal, IFelidae
    {

        public string Length { get; set; }
        public string Weight { get; set; }
        public int MaxSpeed { get; set; }

   


        public Tiger(string speeches, string origin, double population, string eat, int maxSpeed, string length, string weight)
            : base(speeches, origin, population, eat)
        {

            Length = length;
            Weight = weight;
            MaxSpeed = maxSpeed;
        }


        public override void AnimalSort()
        {
            Console.WriteLine($"Tiger" +
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
            $"\n* Det finns idag endast {Speeches} stycken olika arter av tiger kvar." +
            $"\n* Vilda tigrar finns i {Origin}." +
            $"\n* Tigrar har och är ett hotat djur. Det finns runt {Population} stycken tigrar i världen." +
            $"\n* Vanlig föda för ett lejon är: {Eat}." +
            $"\n* Längd, inklusive svans: {Length} meter." +
            $"\n* Vikt: {Weight}kg.");

        }

        public override void FunFact()
        {
            Console.WriteLine("" +
                "\nLite roligt fakta om tigrar:" +
                "\n----------------------------" +
                "\nTigrar är utmärkta simmare: Många tror att tigrar inte gillar vatten, men i självaverket" +
                "\när de skickliga simmare. De är kända för att simma i floder och sjöar för att jaga byten" +
                "\neller kyla ner sig i varma klimat. En del tigrar är så bekväma i vattnet att de till och" +
                "\nmed tar sig ut på längre simturer för att korsa floder och utforksa nya områden. Det är" +
                "\novanligt bland kattartade rovdjur, och det är en fascinerande aspekt av tigrar beteende");
        }


        //new method, only in class-tiger
        public void Hunting()
        {
            Console.WriteLine("" +
                "\nJakt" +
                "\n----" +
                "\nTigern smyger likt de övriga kattdjuren fram nära bytet och gör sedan ett snabbt utfall " +
                "\noch använder då sin kroppstyngd och styrka till att knuffa bytet ur balans. De kan övermanna " +
                "\nbytet från nästan vilket håll som helst, vanligtvis från ett bakhåll. De biter i halsen och " +
                "\nkan ofta bita av ryggraden, luftstrupen eller en artär.Tigern kan även ta större djur som " +
                "\ngauroxar, vilka kan väga upp till ett ton." +
                $"\nEn tiger kan i korta suprter komma upp i en hastigete på {MaxSpeed}km/h" +
                "\n");
        }

        public void Territory()
        {
            Console.WriteLine("" +
                "\nRevir:" +
                "\n------" +
                "\nStorleken på tigrarnas revir skiftar beroende på tillgång av lämpliga ytor och bra föda." +
                "\nHanarna rör sig över ett större område än honorna och ett tigerrevir i exempelvis Indien " +
                "\nkan uppgå till runt 150 kvadratkilometer. I områden med lägre bytestäthet, som till exempel " +
                "\nryska Fjärran Östern, kan en tigerhanes revir vara upp till 1000 kvadratkilometer. " +
                "\nDet är ungefär 5 gånger så stort som Stockholm! Hanens revir överlappar ofta flera honors" +
                "\nområden och är ett av djurvärldens största revir. Tigrar markerar sitt revir genom urinering," +
                "\nsekret från analsäckarna,klösmärken på träd och genom rytande. Vid 2-2,5 års ålder etablerar" +
                "\ntigern ett eget revir. Hanarna drar sig då gärna långt bort från föräldrarna");
        }

        public void Family()
        {
            Console.WriteLine("" +
                "\nFamilj:" +
                "\n-------" +
                "\nHonorna blir könsmogna vid 3 – 4 år. Tre månader efter parningen föder honan vanligtvis 2 – 3 mycket " +
                "\nsmå, blinda och hjälplösa ungar. Storleken på kullarna kan dock variera från 1 till 7. Den första " +
                "\nmånaden hålls de väl gömda, gärna i en grotta eller bland täta buskar. Ungarna diar tills de är fem " +
                "\nmånader gamla, men börjar att äta kött redan efter två månader. Vid åtta till tio månaders ålder börjar " +
                "\nungarna att jaga tillsammans med sin mamma och mellan 17 – 24 månaders ålder lämnar de henne för gott.  ");
        }



    }
}
