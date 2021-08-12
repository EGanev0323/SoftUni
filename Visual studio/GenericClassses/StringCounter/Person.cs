﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCounter
{
    public class Person:IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name=name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
