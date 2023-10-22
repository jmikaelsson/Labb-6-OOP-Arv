using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
    internal class Sources
    {
        public static void SourceList()
        {
            Console.WriteLine("Källförteckning:" +
            "\nhttps://sv.wikipedia.org/wiki/Tiger" +
            "\nhttps://www.wwf.se/djur/tiger/fakta-om-tigrar/"+
            "\nhttps://chat.openai.com/"+
            "\nhttps://hallagarden.com/asnor/"+
            "\nhttps://www.pandaplanet.se/elefanten-en-kanslig-jatte"+
            "\nhttps://sv.wikipedia.org/wiki/Elefanter"+
            "\nhttps://destinationasien.se/2019/08/24/elefanten-en-omdebatterad-jatte/"+
            "\nhttps://www.theperfectworld.com/se/save-the-elephant/" +
            "\nhttps://www.pandaplanet.se/lejon" +
            "\nhttps://www.kolmarden.com/djurpark/djur/lejon" +
            "" +
            "\n");

            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("<--- Tryck enter för att gå tillbaka");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }
}
