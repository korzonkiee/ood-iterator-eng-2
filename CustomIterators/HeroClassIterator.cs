using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ood_iterator_eng_2.Model;

namespace ood_iterator_eng_2.CustomCollections
{
    public class HeroClassIterator : IEnumerable<Hero>
    {
        private readonly IEnumerable<Hero> list;
        private HeroClass heroClass;

        public HeroClassIterator(IEnumerable<Hero> list, HeroClass heroClass)
        {
            this.list = list;
            this.heroClass = heroClass;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            foreach (var hero in list)
            {
                if (hero.HeroClass == heroClass)
                    yield return hero;
            }
        }            

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
