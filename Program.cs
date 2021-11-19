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
            L1.Add(40);

            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("-------------After sorting -----------------");
            L1.Sort();
            foreach (var element in L1)
            {
                Console.WriteLine(element);
            }

            
            
        }
    }
}
