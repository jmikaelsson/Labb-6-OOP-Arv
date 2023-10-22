using System.Numerics;
using System;
using Labb_6_OOP_Arv.Animlas;

namespace Labb_6_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välkommen till EdugradeZoo");

                Console.WriteLine("Vilket av våra djurarter vill du lära dig mer om?" +
                    "\n" +
                    "\n[1] Elefanter" +
                    "\n[2] Åsnor" +
                    "\n[3] Kattdjur" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n--------------" +
                    "\n[4] Källor");


                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int validInput))
                    {

                        if (validInput == 1)
                        {
                            Console.Clear();
                            ElephantInfo();
                            break;
                        }
                        else if (validInput == 2)
                        {
                            Console.Clear();
                            DonkeyInfo();
                            break;
                        }
                        else if (validInput == 3)
                        {
                            Console.Clear();
                            FelidaeInfo();
                            break;
                        }
                        else if (validInput == 4)
                        {
                            Console.Clear();
                            Sources.SourceList();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Välj 1, 2, 3 eller 4..");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ej korrekt inskrivet! Välj 1, 2 eller 3");
                    }
                }
            }
        }
        public static void ElephantInfo()
        {
            List<Animal> animals = new List<Animal>();

            Elephant elephant = new Elephant(speeches: "3", origin: "Afrika och Asien", population: 40.000, eat: "gräs, löv, frukter och små grenar och kvistar", age: 60);
            animals.Add(elephant);

            foreach (Animal animal in animals)
                if (animal is Elephant e)
                {
                    e.AnimalSort();
                    e.MakeSound();
                    e.PrintInfo();
                    e.WorldsOldest();
                    e.FunFact();
                }

            Console.WriteLine(""+
                "\n"+
                "\n" +
                "\n" +
                "\n" +
                "\n-----------------------------------------");
            Console.WriteLine("<--- Tryck enter för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();

            return;
        }

        public static void DonkeyInfo()
        {
            List<Animal> animals = new List<Animal>();

            Donkey donkey = new Donkey(speeches: "mula eller mulåsna", origin: "Egymten och Afrika", population: 450, eat: "hö" , crossing: "Zonkey");
            animals.Add(donkey);


            foreach (Animal animal in animals)
                if (animal is Donkey d)
                {
                    d.AnimalSort();
                    d.MakeSound();
                    d.PrintInfo();
                    d.FamusDonkey();
                    d.FunFact();
                }

            Console.WriteLine(""+
                "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n-----------------------------------------");
            Console.WriteLine("<--- Tryck enter för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        public static void FelidaeInfo()
        {
            while (true)
            {
                
                Console.WriteLine("" +
                "\nVilket kattdjur vill du veta mer om?" +
                "\n------------------------------------" +
                "\n [1] Tigern" +
                "\n [2] Lejonet");

                Console.WriteLine("" +
                    "\n" +
                "\n" +
                "\n" +
                "\n" +
                "\n-----------------------------------------");
                Console.WriteLine("<--- Tryck enter för att gå tillbaka");

                bool successfulParse = int.TryParse(Console.ReadLine(), out int userInput);

                if (successfulParse)
                {
                    Console.Clear();
                    if (userInput == 1)
                    {
                        List<Animal> felidaes = new List<Animal>();

                        Tiger tiger = new Tiger(speeches: "2", origin: "Afrika och Asien", population: 4.500, eat: "kött", maxSpeed: 65, length: "1,9 – 2,8", weight: "65 – 170" );
                        felidaes.Add(tiger);

                        foreach (Animal animal in felidaes)
                            if (animal is Tiger t)
                            {
                                t.AnimalSort();
                                t.MakeSound();
                                t.PrintInfo();
                                t.Hunting();
                                t.Family();
                                t.Territory();
                                t.FunFact();

                                Console.WriteLine("" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n-----------------------------------------");
                                Console.WriteLine("<--- Tryck enter för att gå tillbaka");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                    }
                    else if (userInput == 2)
                    {
                        List<Animal> felidaes = new List<Animal>();

                        Lion lion = new Lion(speeches: "2", origin: "Afrika och delar av Indien", population: 30.000, eat: "Zebra, antilop", maxSpeed:74 , habitat: "savannen");
                        felidaes.Add(lion);

                        foreach (Animal animal in felidaes)
                            if (animal is Lion l)
                            {
                                l.AnimalSort();
                                l.PrintInfo();
                                l.MakeSound();
                                l.Hunting();
                                l.LionHabitat();
                                l.FunFact();

                                Console.WriteLine("" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n-----------------------------------------");
                                Console.WriteLine("<--- Tryck enter för att gå tillbaka");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                    }
                }
                else
                {
                    Console.Clear();
                    return;
                }

            }
        
            

        }

        
    }
}