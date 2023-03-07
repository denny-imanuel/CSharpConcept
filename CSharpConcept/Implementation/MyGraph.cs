using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept.Implementation
{
    public class MyGraph<T>
    {

        public Dictionary<T, List<T>> graph = null;

        public MyGraph()
        {
            graph = new Dictionary<T, List<T>>();
        }

        public void InsertVertex(T val)
        {
            if (!graph.ContainsKey(val))
            {
                graph.Add(val, new List<T>());
            }
        }

        public void RemoveVertex(T val)
        {
            if (graph.ContainsKey(val))
            {
                graph.Remove(val);
            }
        }

        public void InsertEdges(T val1, T val2)
        {
            if (!(graph.ContainsKey(val1) & graph.ContainsKey(val2)))
            {
                graph[val1].Add(val2);
            } 

        }

        public void RemoveEdges(T val1, T val2)
        {
            if (graph.ContainsKey(val1) & graph.ContainsKey(val2))
            {
                graph[val1].Remove(val2);
            }
        }

        public void PrintGraph()
        {
            foreach(var key in graph.Keys)
            {
                foreach(var val in graph[key])
                {
                    Console.WriteLine("graph:" + key + "->" + val);
                }
            }
        }

        public void DFSUsingStack(T start)
        {
            var visited = new HashSet<T>();
            var stack = new Stack<T>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                // get the last stack 
                var last = stack.Pop();
                if (!visited.Contains(last))
                {
                    visited.Add(last);
                    // insert neighbors that has not been visited to the stack
                    var neighbors = graph[last];
                    foreach (var neighbor in neighbors)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            stack.Push(neighbor);
                        }
                    }

                }
            }
        }

        public void BFSUsingQueue(T start)
        {
            var visited = new HashSet<T>();
            var queue = new Queue<T>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                // get the first stack 
                var first = queue.Dequeue();
                if (!visited.Contains(first))
                {
                    visited.Add(first);
                    // insert neighbors that has not been visited to the stack
                    var neighbors = graph[first];
                    foreach (var neighbor in neighbors)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }

                }
            }
        }


    }
}
