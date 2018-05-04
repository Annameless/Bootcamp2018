using System;
using System.Collections.Generic;

namespace LinkedListStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            var p = new LinkedList<string>();
            var jfkNode = p.AddLast("JFK");
            p.AddLast("Lyndon B Johnson");
            p.AddLast("Richard Nixon");
            p.AddLast("Jimmy Carter");

            p.AddAfter(p.Find("Richard Nixon"), "Gerald Ford");

            p.Remove(jfkNode);
            p.AddFirst("John F Kennedy");

            foreach (string president in p)
                Console.WriteLine(president);

            Console.WriteLine("\nStack");
            var stack = new Stack<string>();
            stack.Push("Programming");
            stack.Push("The Philosophy");
            stack.Push("Heat");
            stack.Push("Harry Potter");

            Console.WriteLine("ALL BOOKS:");
            foreach (string title in stack)
                Console.WriteLine(title);

            Console.WriteLine("\nPop takes an element out of the stack (removes it)");
            var topItem = stack.Pop();
            Console.WriteLine("Top item is " + topItem);

            Console.WriteLine("ALL BOOKS after popping:");
            foreach (string title in stack)
                Console.WriteLine(title);

            Console.WriteLine("\nUse peek to see what is the top element is without removing it");
            topItem = stack.Peek();
            Console.WriteLine("Top item is " + topItem);

            Console.WriteLine("ALL BOOKS after peeking:");
            foreach (string title in stack)
                Console.WriteLine(title);

            Console.WriteLine("\nQueue");
            var tasks = new Queue<string>();
            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finish the C# Collections Pluralsight course");
            tasks.Enqueue("Buy some chocolate");
            tasks.Enqueue("Buy some more chocolate");

            Console.WriteLine("ALL TASKS:");
            foreach (string title in tasks)
                Console.WriteLine(title);

            Console.WriteLine("\nDequeue takes an element out of the queue (removes it)");
            var first = tasks.Dequeue();
            Console.WriteLine("First item is " + first);

            Console.WriteLine("ALL Tasks after dequeue:");
            foreach (string t in tasks)
                Console.WriteLine(t);

            Console.WriteLine("\nUse peek to see what is the first element is without removing it");
            first = tasks.Peek();
            Console.WriteLine("First item is " + first);

            Console.WriteLine("ALL Tasks after peeking:");
            foreach (string t in tasks)
                Console.WriteLine(t);
        }
    }
}
