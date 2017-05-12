
using ood_iterator_eng_2;
using ood_iterator_eng_2.CustomCollections;
using ood_iterator_eng_2.Model;
using ood_iterator_eng_2.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood_iterator_eng_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<Hero> zone1List = generateZone1();
            ICustomCollection<Hero> zone2List = generateZone2();
            ICustomCollection<Hero> zone3List = generateZone3();

            Console.WriteLine("\n\n--------- First list---------\n\n");

            IEnumerable<Hero> linkedListIterator = new LinkedListIterator(zone1List);
            foreach(var item in linkedListIterator)
                Console.WriteLine($"Name: {item.HeroName}, Class: {item.HeroClass}");

            Console.WriteLine("\n\n--------- Second list---------\n\n");

            IEnumerable<Hero> reversedListIterator = new ReversedArrayListIterator(zone2List);
            foreach(var item in reversedListIterator)
                Console.WriteLine($"Name: {item.HeroName}, Class: {item.HeroClass}");

                
            Console.WriteLine("\n\n--------- Concatenated list: PvP pairs ---------\n\n");

            var concatenatedList = linkedListIterator.Concat(reversedListIterator);

            /* 

            foreach (var item in concatenatedList)
            {
                foreach(var item2 in concatenatedList)
                {
                    Console.Write($"{{{item.HeroName}, {item2.HeroName}}}\t");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            */

            Console.WriteLine("\n\n--------- Concrete hero class linked list ---------\n\n");

            var heroClassIterator = new HeroClassIterator(linkedListIterator, HeroClass.Mage);
            foreach (var item in heroClassIterator)
            {
                Console.WriteLine($"{item.HeroClass} hero: {item.HeroName}");
            }

            Console.WriteLine("\n\n--------- Concrete hero class array list ---------\n\n");

            var heroClassArrayListIterator = new HeroClassIterator(reversedListIterator, HeroClass.Mage);
            foreach (var item in heroClassArrayListIterator)
            {
                Console.WriteLine($"{item.HeroClass} hero: {item.HeroName}");
            }
        }

        // DO NOT CHANGE CODE BELOW

        static ICustomCollection<Hero> generateZone1()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for(int i=0; i<20; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone2()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone3()
        {
            ReversedArrayList<Hero> result = new ReversedArrayList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }
    }
}
