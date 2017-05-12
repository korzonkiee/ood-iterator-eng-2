using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ood_iterator_eng_2.Model;

namespace ood_iterator_eng_2.CustomCollections
{
    public class ReversedArrayListIterator : IEnumerable<Hero>
    {
        private readonly ICustomCollection<Hero> list;

        public ReversedArrayListIterator(ICustomCollection<Hero> list)
        {
            this.list = list;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            for(int i = 0; i < list.Size; i++)
                yield return list.Get(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
