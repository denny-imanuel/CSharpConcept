using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Collection
    {
        public void LoopString()
        {
            var str = "abcde";
            foreach(var chr in str)
            {
                Console.WriteLine(chr);
            }
        }

        public void LoopTuple()
        {
            var tuple = new Tuple<int,int,int,string,string,string>(1,2,3,"aaa","bbb", "ccc");
            Console.WriteLine(tuple.ToString());              
        }

        public void LoopList()
        {
            var list = new List<string>{ "aaa", "bbb", "ccc", "ddd", "eee" };
            foreach(var itm in list)
            {
                Console.WriteLine(itm);
            }
        }

        public void LoopSet()
        {
            var set = new HashSet<string> { "aaa", "aaa", "bbb", "bbb", "ccc", "ccc" };
            foreach(var itm in set)
            {
                Console.WriteLine(itm);
            }
        }

        public void LoopDictionary()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(3, "ccc");
            dict.Add(2, "bbb");
            dict.Add(1, "aaa");
            foreach(var key in dict.Keys)
            {
                Console.WriteLine(key + "," + dict[key]);
            }
            foreach(var val in dict.Values)
            {
                Console.WriteLine(val);
            }
            foreach(var itm in dict)
            {
                Console.WriteLine(itm.Key + "," + itm.Value);
            }
        }

        public void LoopSortedSet()
        {
            var sset = new SortedSet<string>();
            sset.Add("ccc");
            sset.Add("bbb");
            sset.Add("bbb");
            sset.Add("aaa");
            foreach(var itm in sset)
            {
                Console.WriteLine(sset);
            }
        }

        public void LoopSortedList()
        {
            // similar to sorted dict, however it stored in continuous block in stack memory
            var slist = new SortedList<int, string>();
            slist.Add(3, "ccc");
            slist.Add(2, "bbb");
            slist.Add(1, "aaa");
            foreach(var key in slist.Keys)
            {
                Console.WriteLine(key + "," + slist[key]);
            }
            foreach (var val in slist.Values)
            {
                Console.WriteLine(val);
            }
            foreach (var itm in slist)
            {
                Console.WriteLine(itm.Key + "," + itm.Value);
            }
        }

        public void LoopSortedDict()
        {
            // similar to sorted list, however it stored in separate object in the heap memory
            var dict = new SortedDictionary<int, string>();
            dict.Add(3, "ccc");
            dict.Add(2, "bbb");
            dict.Add(1, "aaa");
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key + "," + dict[key]);
            }
            foreach (var val in dict.Values)
            {
                Console.WriteLine(val);
            }
            foreach (var itm in dict)
            {
                Console.WriteLine(itm.Key + "," + itm.Value);
            }
        }

        public void LoopStack()
        {
            var stack = new Stack<string>();
            stack.Push("aaa"); Console.WriteLine(stack.Peek());
            stack.Push("bbb"); Console.WriteLine(stack.Peek());
            stack.Push("ccc"); Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop()); 
        }

        public void LoopQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("aaa"); Console.WriteLine(queue.Peek());
            queue.Enqueue("bbb"); Console.WriteLine(queue.Peek());
            queue.Enqueue("ccc"); Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }

    }
}
