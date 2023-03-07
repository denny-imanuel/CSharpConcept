using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept.Implementation
{
    public class MyDictionary<K,V>
    {
        public class Pair<K,V>
        {
            public K key;
            public V value;
            public Pair(K key, V value)
            {
                this.key = key; this.value = value;
            }
        }

        public HashSet<Pair<K, V>> pairs;
        public MyDictionary()
        {
            pairs = new HashSet<Pair<K, V>>();
        }

        public V? Get(K key)
        {
            V? value = default;
            var pair = pairs.Where(i => i.key != null && i.key.Equals(key)).FirstOrDefault();
            if (pair != null)
                value = pair.value;
            return value;
        }

        public void Add(K key, V value)
        {
            // check for duplicated key
            var pair = pairs.Where(i => i.key != null && i.key.Equals(key)).FirstOrDefault();
            if (pair != null)
                pairs.Add(new Pair<K, V>(key, value));
        }

        public void Remove(K key)
        {
            var pair = pairs.Where(i => i.key != null && i.key.Equals(key)).FirstOrDefault();
            if (pair != null)
            {
                var value = pair.value;
                pairs.Remove(new Pair<K, V>(key, value));
            }
        }
    }
}
