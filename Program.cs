using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public class Osnova
        {
            public ArrayList arraylist = new ArrayList();
            public List<int> intlist = new List<int>();
            public Stack<double> stack = new Stack<double>();
            public Queue<string> queue = new Queue<string>();


            public void AddInList(int a, double b, string c)
            {
                arraylist.Add(a);
                intlist.Add(a);
                stack.Push(b);
                queue.Enqueue(c);
            }
            public void Remove(int w)
            {
                intlist.Remove(w);
                stack.Pop();
                queue.Dequeue();
                arraylist.Remove(w);
            }
            public void Clear()
            {
                intlist.Clear();
                stack.Clear();
                queue.Clear();
            }
            public void GetItem(int index)
            {
                Console.WriteLine(arraylist[index]);
                Console.WriteLine(intlist[index]);
                Console.WriteLine(stack.Peek());
                Console.WriteLine(queue.Peek());
            }

            public void GetLenght()
            {
                Console.WriteLine(arraylist.Count);
                Console.WriteLine(intlist.Count);
                Console.WriteLine(stack.Count);
                Console.WriteLine(queue.Count);
            }
        }
        static void Main(string[] args)
        {
            Osnova coll = new Osnova();
            coll.AddInList(15, 10.1, "2");
            coll.AddInList(10, 20.1, "1");
            coll.AddInList(20, 30.1, "3");
            coll.AddInList(25, 40.1, "4");
            coll.GetItem(2);
            coll.GetLenght();
            coll.Remove(1);
            coll.GetLenght();
        }
    }
}
