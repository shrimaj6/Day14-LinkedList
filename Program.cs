using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(30);
            L1.Add(70);
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }
            L1.RemoveAt(0);
            Console.WriteLine("Afetr removing first element------------");
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

        }
    }
}
