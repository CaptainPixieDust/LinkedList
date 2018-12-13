using System;

namespace LInkedListImplementation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(32);
            linkedList.AddLast(33);
            linkedList.AddFirst(31);
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            linkedList.RemoveLast();
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }

            bool b = linkedList.Contains(36);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
