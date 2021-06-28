using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pair> pairs = new List<Pair>();
            pairs.Add(new Pair() { a = 1, b = 3 });
            pairs.Add(new Pair() { a = 2, b = 6 });
            pairs.Add(new Pair() { a = 8, b = 10 });
            pairs.Add(new Pair() { a = 15, b = 18 });

            foreach (Pair p in pairs)
            {
                Console.WriteLine($"[{p.a}, {p.b}]");
            }

            int intersectOne = 0;   //indexes in a list
            int intersectTwo = 1;   // which two elements I want to intersect

            List<Pair> newPairs = new List<Pair>();

            int newA = 0;
            int newB = 0;
            for (int i = 0; i < pairs.Count; i++)
            {

                bool intersected = false;
                if (i == intersectOne)
                {
                    newA = pairs[i].a;
                    intersected = true;
                }
                else if (i == intersectTwo)
                {
                    newB = pairs[i].b;
                    intersected = true;
                }

                if (intersected)
                {
                    if (newA != 0 && newB != 0)
                        newPairs.Add(new Pair() { a = newA, b = newB });
                    //intersected = false;
                }
                else
                {
                    newPairs.Add(new Pair() { a = pairs[i].a, b = pairs[i].b });

                }
            }

            foreach (Pair p in newPairs)
            {
                Console.WriteLine($"[{p.a}, {p.b}]");
            }
        }
        public class Pair
        {

            public int a { get; set; }
            public int b { get; set; }


        }


    }
}

