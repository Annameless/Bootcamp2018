using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            PrintDict(primeMinisters);

            Console.WriteLine("\nLook up an item by key [MT]");
            var pm = primeMinisters["MT"];
            Console.WriteLine(pm);

            Console.WriteLine("\nLook up an item by TryGetValue(DC, ..)");
            var found = primeMinisters.TryGetValue("DC", out var prime);
            if(found)
                Console.WriteLine(prime);
            else
                Console.WriteLine("Value with key [DC] not in dictionary");

            Console.WriteLine("\nModify the dictionary: dict[newKey] = new value()");
            primeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            PrintDict(primeMinisters);

            Console.WriteLine("\nModify the dictionary: dict.Add(newKey, newValue)");
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));
            PrintDict(primeMinisters);

            Console.WriteLine("Adding value with key that already exists:");
            Console.WriteLine(" -  will override it if indexer was used");
            primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1990);
            PrintDict(primeMinisters);
            Console.WriteLine(" -  will fail if .Add() was used");

            Console.WriteLine("\nRemove an entry .Remove(JC)");
            primeMinisters.Remove("JC");
            PrintDict(primeMinisters);

            Console.WriteLine("\nComparing Keys: defult comparer in initialiser");
            var pms = new Dictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase){
                {"JC", new PrimeMinister("James Callaghan", 1974)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            Console.WriteLine(pms["tb"]);

            Console.WriteLine("\nComparing Keys: custom EqualityComparer");
            var pms2 = new Dictionary<string, PrimeMinister>(new UncasedStringEqualityComparer()){
                {"JC", new PrimeMinister("James Callaghan", 1974)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            Console.WriteLine(pms2["tb"]);

            Console.WriteLine("\nReadonly Dictionary - can be initialized by another dictionary only");
            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(pms2);
            PrintDict(pmsReadOnly);
            try{
                pmsReadOnly.TryAdd("HP", new PrimeMinister("Harry Potter", 2018));
            }catch{
                Console.WriteLine("Can't alter readonly dictionary"); 
            }

            Console.WriteLine("\nSortedList<key, value> with default comparer - alphabetical by the key");
            var pms4 = new SortedList<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"JC", new PrimeMinister("James Callaghan", 1974)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };
            pms4.Add("JM", new PrimeMinister("John Major", 1990));
            PrintDict(pms4);

            Console.WriteLine("[tb] is " + pms4["tb"]);

            Console.WriteLine("\nSortedList<key, value> with custom IComparer");
            var pms5 = new SortedList<string, PrimeMinister>(new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1974)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };
            pms5.Add("JM", new PrimeMinister("John Major", 1990));
            PrintDict(pms5);

            Console.WriteLine("[tb] is " + pms5["tb"]);

            Console.WriteLine("\nSortedDictionary is the same as SortedList, but differs in implementation(balanced tree). Fater modification");
            var pms6 = new SortedDictionary<string, PrimeMinister>(new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1974)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };
            pms6.Add("JM", new PrimeMinister("John Major", 1990));
            PrintDict(pms6);

            Console.WriteLine("[tb] is " + pms6["tb"]);

            Console.WriteLine("\nKeyedCollection");
            var pms7 = new PrimeMinistersByYearDictionary
            {
                new PrimeMinister("James Callaghan", 1974),
                new PrimeMinister("Margaret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };
            pms7.Add(new PrimeMinister("John Major", 1990));
            foreach (var p in pms7)
                Console.WriteLine(p);
            Console.WriteLine("Tony is " + pms7[1997]);
        }

        static void PrintDict(IDictionary<string, PrimeMinister> primeMinisters){
            foreach (var pm in primeMinisters)
                Console.WriteLine(pm);
        }
    }
}
