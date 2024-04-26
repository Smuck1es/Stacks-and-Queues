using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

// You would use a link list when you need to remove add and remove lots of elements. Linked lists know info about the next element. 
// Since linked lists keep track of the next element it's easy to delete and add elements than in an array because it doesn't need to keep and index.

// The difference between a stack and queue has to do with how they add and delete. In queues the first element to go in has to be the first to come out.
// In an stack all the other elements must come out before the first one that went in can come out.

// You could use a stack when checking for matching parenthesies.

// You would use an array when you need to know where and element is. Arrays are better at searching for elements than a list.


class StackAndQueues
{
    static void Main()
    {
        ReverseEnteredStack();
        Occurences();
        SequenceProblem();
    }
    static void ReverseEnteredStack()
    {
        Stack<int> Stack = new Stack<int>();

        //User inputs 10 integers into a stack
        Console.WriteLine("Enter 10 integers: ");
        for (int i = 0; i < 10; i++)
        {
            int Entry;

            Console.Write($"Integer {i + 1}: ");
            string EnteredInteger = Console.ReadLine();

            //Test to see if input is an integer
            while(!Int32.TryParse( EnteredInteger, out Entry))
            {
                Console.WriteLine("Not a valid number, try again.");
                EnteredInteger = Console.ReadLine();
            }
            Stack.Push(Entry);
        }
        
        //Outputs users entries in reverse
        Console.WriteLine("\nEntries in reverse: ");
        while (Stack.Count > 0)
        {
            Console.WriteLine(Stack.Pop());
        }
    }

    static void Occurences()
    {
        Dictionary<int,int> InstancesOf = new Dictionary<int,int>();
        int[] Array = {3, 4, 4, 2, 3, 3, 4, 3, 2 };

        // Search array and increment instances of numbers in array
        foreach (int number in Array) 
        {
            // If it already contains that number it increments by 1 else it adds a key and a value of 1
            if (InstancesOf.ContainsKey(number))
            {
                InstancesOf[number]++;
            }
            else 
            {
                InstancesOf.Add(number, 1);
            }
        }
        
        // Prints occurences of each in order of smallest to largest
        Console.WriteLine("Number|Occurences");
        foreach (var Result in InstancesOf.OrderBy(key => key.Key))
        {
           Console.WriteLine(Result.Key + "|" +Result.Value + " times");
        }

    }

    static void SequenceProblem()
    {
        Queue<int> Queue = new Queue<int>();
        int N = 2;

        Queue.Enqueue(N);

        for (int i = 0; i < 50; i++)
        {
            
            int M = Queue.Dequeue();
            Console.WriteLine(M);
    
            Queue.Enqueue(M + 1);
            Queue.Enqueue(2 * M + 1);
            Queue.Enqueue(M + 2);
        }
    }
}


