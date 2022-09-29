using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ListTasks.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listA = new List<int> { 1,2,3,4,5};
            List<int> listA2 = new List<int> { 5,4,3,2,1 };
            List<int> listB = new List<int> {2,3,5,7,11,13};
            List<int> listB2 = new List<int> {2,3,5,13,11,7};
            List<int> listC = new List<int> {2,3,5,13,11,7,-2};
            List<int> listD = new List<int> {2,3,5,2, 13, -2, 11,7,-2, 13};
            
            // make some reasonable assertions for 1 a,b,c 
            Debug.Assert(MySum(listA) == 15);
            Debug.Assert(MyMax(listA) == 5);
            Debug.Assert(MyMax(listA2) == 5);
            Debug.Assert(MyMin(listA2) == 1);
            Debug.Assert(MyMin(listC) == -2);

            // 1d 
            List<int> negs = GetTheNegs(listA);
            Debug.Assert(negs.Count == 0);
            // ListC - we're expecting just one negative item in the list 
            negs = GetTheNegs(listC);
            Debug.Assert(negs.Count == 1);
            Debug.Assert(negs[0] == -2);

            // use the funkier negative getter 
            List<int> negs2 = GetTheNegs2(listA);
            Debug.Assert(negs2.Count == 0);
            negs2 = GetTheNegs2(listC);
            Debug.Assert(negs2.Count == 1);
            Debug.Assert(negs2[0] == -2);

            // Q2 - same items 
            Debug.Assert(SameItems(listA, listA2));
            Debug.Assert(SameItems(listB, listB2));
            Debug.Assert(!SameItems(listB, listC));

            // Generate a sorted list of random numbers by adding a random amount to the previous value ensuring it is non-decreasing  
            Random r = new Random();
            List<int> sortedList = new List<int>();
            int limit = 1024;
            for(int i = 0; i < limit; ++i)
            {
                int previous = i == 0 ? 0 : sortedList[i-1];
                sortedList.Add(previous + r.Next(0,100));
            }

            // pick a random index, so it must be in the list 
            int definitelyThere = sortedList[r.Next(limit)];
            
            // Q3a - naive search 
            Debug.Assert(NaiveSearch(sortedList, definitelyThere));

            // pick a random index somewhere near the middle 
            int definitelyNotThere = r.Next(limit/4, limit * 3/4 );
            // continue adding to it until we find something not there 
            while(sortedList.Contains(definitelyNotThere))
                ++definitelyNotThere;
            Debug.Assert(!NaiveSearch(sortedList, definitelyNotThere));
             

            // Q3b - binary search 
            Debug.Assert(BinarySearch(sortedList, definitelyThere));
            Debug.Assert(!BinarySearch(sortedList, definitelyNotThere));


            // Q4 - duplicates 
            List<int> listDDupes = Duplicates(listD);
            Debug.Assert(listDDupes.Count == 3);
            Debug.Assert(listDDupes.Contains(-2));

            // Q5 subsets 
            Debug.Assert(!IsSubset(listA, listB));
            Debug.Assert(IsSubset(listB2, listC));

            // Q6 - reverse in place 
            InPlaceReverse(listA2);
            for(int i = 0; i < listA.Count; ++i)
            {
                Debug.Assert(listA[i] == listA2[i]);
            }



            // Q7 sorting 

            // there's a lot going on here - basically the sort functions are Actions which take a list of integers 
            // (Actions are void functions)
            // this assigns each of the sort methods to a variable (a.k.a. a function pointer)
            foreach(Action<List<int>> sortFunc in new List<Action<List<int>>> {BubbleSort, SelectionSort, QuickSort})
            {
                // generate a random list of data 
                List<int> randomList = new List<int>();
                for(int i = 0; i < limit; ++i)
                {
                    randomList.Add(r.Next(0,limit));
                }

                // sort using the current method                 
                sortFunc(randomList);

                // loop through it, validating the ordering 
                for(int i = 0; i < randomList.Count-1; ++i)
                {
                    Debug.Assert(randomList[i] <= randomList[i+1]);
                }
            }




            Console.WriteLine("if assertions have all passed you'll just see this message");
        }

        static void QuickSort(List<int> incoming)
        {
            QuickSort(incoming, 0, incoming.Count-1);
        }

        static void QuickSort(List<int>incoming, int lower, int upper)
        {
            if(lower < upper)
            {
                int pivot = Partition(incoming, lower, upper);
                QuickSort(incoming, lower, pivot-1);
                QuickSort(incoming, pivot+1, upper);
            }
        }

        static int Partition(List<int> incoming, int lower, int upper)
        {
            int left = lower;
            int finalPoint = left;
            int right = upper;
            bool done = false;

            while(!done){
                while((incoming[finalPoint] <= incoming[right]) && (finalPoint!=right))  
                    --right;     
                if(finalPoint == right)  
                    done = true;  
                else if(incoming[finalPoint] > incoming[right])  
                {  
                    Swap(incoming, finalPoint, right);
                    finalPoint = right;  
                }  
                if(!done)  
                {  
                    while((incoming[finalPoint] >= incoming[left]) && (finalPoint != left))  
                        left++;  
                    if(finalPoint == left)  
                        done = true;  
                    else if(incoming[finalPoint] < incoming[left])  
                    {
                        Swap(incoming, finalPoint, left);  
                        finalPoint = left;  
                    }
                }  
            }
            return finalPoint;
        }  

        static void BubbleSort(List<int> incoming)
        {
            for(int numberInCorrectPlace = 0; numberInCorrectPlace < incoming.Count - 1; ++numberInCorrectPlace)
            {
                bool swapped = false;
                for(int i = 0; i < incoming.Count-1-numberInCorrectPlace; ++i)
                {
                    if(incoming[i] > incoming[i+1])                        
                    {
                        Swap(incoming, i, i+1);
                        swapped = true;
                    }
                }
                if(!swapped)
                    return;
            }

        }

        static void SelectionSort(List<int> incoming)
        {
            for(int index = -1; index < incoming.Count-1; ++index)
            {
                int positionOfMinimum = index+1;
                for(int isThisLower = positionOfMinimum+1; isThisLower < incoming.Count; ++isThisLower)
                {
                    if(incoming[isThisLower] < incoming[positionOfMinimum])
                        positionOfMinimum = isThisLower;
                }
                if(positionOfMinimum > index+1)
                    Swap(incoming, index+1, positionOfMinimum);
            }
        }

        static int MySum(List<int> incoming) {
            int rv = 0;
            foreach(int item in incoming)
                rv += item;
            return rv;
        }

        static int MyMax(List<int> incoming) {
            int rv = incoming[0];
            foreach(int i in incoming)
                rv = i > rv ? i : rv;
            return rv;
        }
        static int MyMin(List<int> incoming) {
            int rv = incoming[0];
            foreach(int i in incoming)
                rv = i < rv ? i : rv;
            return rv;
        }

        static List<int> GetTheNegs(List<int> incoming)
        {
            List<int> rv = new List<int>();
            foreach(int item in incoming)
                if(item < 0)
                    rv.Add(item);
            return rv;
        }

        static List<int> GetTheNegs2(List<int> incoming)
        {
            return incoming.Where(i => i < 0).Select(i => i).ToList();
        }

        static bool SameItems(List<int> incoming1, List<int> incoming2)
        {
            foreach(int i in incoming1)
                if(!incoming2.Contains(i))
                    return false;
            foreach(int i in incoming2)
                if(!incoming1.Contains(i))
                    return false;
            return true;
        }

        static bool NaiveSearch(List<int> incoming, int sought)
        {
            foreach(int item in incoming)
            {   
                if( sought == item)
                    return true;
                if(item > sought)
                    return false;
            }
            return false;
        }

        static bool BinarySearch(List<int> incoming, int sought)
        {
            return BinarySearch(incoming, sought, 0, incoming.Count-1);
        }

        static bool BinarySearch(List<int> incoming, int sought, int lower, int upper)
        {
            if(lower > upper)
                return false; 
            if(lower == upper)
                return incoming[lower] == sought;
            int pivot = (lower + upper)/2;
            if(incoming[pivot] == sought)
                return true;
            if(incoming[pivot] > sought)
                return BinarySearch(incoming, sought, lower, pivot-1);
            else
                return BinarySearch(incoming, sought, pivot+1, upper);
        }

        static List<int> Duplicates(List<int> incoming)
        {
            List<int> rv = new List<int>();
            foreach(int i in incoming)
            {
                if(!rv.Contains(i) && Count(incoming, i) > 1)
                    rv.Add(i);
            }
            return rv;
        }

        static int Count(List<int> incoming, int target){
            int counter = 0;
            foreach(int i in incoming)
                if(i == target)
                    ++counter;
            return counter;
        }

        static bool IsSubset(List<int> incoming1, List<int> incoming2)
        {
            bool oneInTwo = true;
            foreach(int i in incoming1)
                if(!incoming2.Contains(i))
                    oneInTwo = false;
            bool twoInOne = true;
            foreach(int i in incoming2)
                if(!incoming1.Contains(i))
                    twoInOne = false;
            return oneInTwo ^ twoInOne;
        }


        static void InPlaceReverse(List<int> incoming)
        {
            int index = 0;
            while(index < (incoming.Count - index - 1))
            {
                Swap(incoming, index, incoming.Count-index-1);
                ++index;
            }
        }

        static void Swap(List<int> incoming, int a, int b)
        {
            incoming[a] ^= incoming[b];
            incoming[b] ^= incoming[a];
            incoming[a] ^= incoming[b];
        }
    }
}
