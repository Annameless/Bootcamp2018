﻿
using System;

namespace ReflectIt
{
    public class Employee
    {
		public string Name { get; set; }

        public void Speak<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}
