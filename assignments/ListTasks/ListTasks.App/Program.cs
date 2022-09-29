using System;
using System.Collections.Generic;
using System.Linq;

namespace ListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // needs the System.Collections.Generic using statement 
            List<int> brandNewEmptyList = new List<int>(0);

            // or use a comma separated list in curly brackets 
            List<int> listOfIntegers = new List<int>() { 1, 2, -4, 3, 4 };

            // use square brackets to get the item at a specific location 
            int head = listOfIntegers[0];

            listOfIntegers.Add(42);

            brandNewEmptyList.Clear();

            if (listOfIntegers.Contains(13))
                Console.WriteLine("has 13");

            // question - what if the value is not there? 
            int whereisnegative4 = listOfIntegers.IndexOf(-4);

            // insert the value 94 at position 0 - careful that the index exists. 
            listOfIntegers.Insert(0, 94);


            // two types of deletion 

            // 1. by value 
            if (listOfIntegers.Contains(10))
                listOfIntegers.Remove(10);

            // 2. by position 
            listOfIntegers.RemoveAt(0);

            // various aggregation functions
            int c = listOfIntegers.Count;
            int s = listOfIntegers.Sum();
            int m1 = listOfIntegers.Min();

            // a python like loop 

            foreach (int i in listOfIntegers)
            {
                Console.WriteLine(i);
            }

            // or more c# like 

            for (int index = 0; index < listOfIntegers.Count; ++index)
                Console.WriteLine($"{index}: {listOfIntegers[index]}");

            Double(listOfIntegers); // passing by reference 

            List<int> secondList = listOfIntegers;
            secondList.Add(2021);
            if (listOfIntegers.Contains(2021))
                Console.WriteLine("that's unexpected");

            List<int> thirdList = CreateANewList(listOfIntegers);
            thirdList.Add(2022);
            if (listOfIntegers.Contains(2022))
                Console.WriteLine("that's unexpected");
            else
                Console.WriteLine("or was it?");

            // extension - linq - but you've not got your LINQ certification yet 
            List<int> negativeNumbers =
                listOfIntegers
                    .Where(i => i < 0)
                    .Select(i => Double(i))
                    .ToList();


            Console.ReadKey();
        }

        static int Double(int x)
        {
            x *= 2;
            return x;
        }

        static void Double(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
                l[i] *= 2;
        }
        static List<int> CreateANewList(List<int> incoming)
        {
            List<int> returnValue = new List<int>() { 2, 3, 5, 7 };
            return returnValue;
        }
    }
}