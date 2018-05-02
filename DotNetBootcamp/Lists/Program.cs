using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>{
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush",
                "Barack Obama"
            };

            foreach (string president in presidents)
                Console.WriteLine(president);
            
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);

            Console.WriteLine("\nAdd president");
            presidents.Add("Donald Trump");

            foreach (string president in presidents)
                Console.WriteLine(president);

            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);

            Console.WriteLine("\nRemove president");
            presidents.RemoveAt(5);

            foreach (string president in presidents)
                Console.WriteLine(president);

            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);

            Console.WriteLine("\nList as readonly");
            try{
                TryToRemoveFromList(presidents.AsReadOnly());
            }catch(Exception ex){
                Console.WriteLine("Can't alter read only list: " + ex.Message); 
            }

            Console.WriteLine("\nCollection<T> designed for inheritance. Don't allow empty strings in list");
            var lst = new NonBlankStringList
            {
                "Item added at index 0",
				"Item added at index 1"
            };
            try{
                lst[0] = "   ";
            }catch(ArgumentException ex){
                Console.WriteLine("When try to add '    ' item to the list: " + ex.Message);
            }
            lst.Insert(2, "Item inserted at index 2");

            foreach (string item in lst)
                Console.WriteLine(item);

            Console.WriteLine("\nObservableCollection  - list that provides change notifications");
            var p = new ObservableCollection<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush"
            };

            p.CollectionChanged += OnCollectionChanged;

            p.Add("Bill Clinton");
            p.Remove("Jimmy Carter");

            foreach (string president in p)
                Console.WriteLine(president);
        }

        static void TryToRemoveFromList(IList<string> l){
            l.RemoveAt(2);
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs eventArgs){
            Console.WriteLine("Collection has changed by action: " + eventArgs.Action);
        }
    }
}
