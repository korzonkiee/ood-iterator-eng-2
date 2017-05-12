using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ood_iterator_eng_2.Model;

namespace ood_iterator_eng_2.CustomCollections
{
    public class LinkedListIterator : IEnumerable<Hero>
    {
        private readonly ICustomCollection<Hero> list;

        public LinkedListIterator(ICustomCollection<Hero> list)
        {
            this.list = list;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            for(int i = list.Size - 1; i >= 0; i--)
                yield return list.Get(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
