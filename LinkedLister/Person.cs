﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLister
{
    public enum Gender { Male, Female }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return $"{Id}: {FullName} ({Gender}), {Age} years";
        }
    }

}
