using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Person
    {
        public string Name { get; set; }
        public int GroupNumber { get; set; }

        public Person(String nm, int gn)
        {
            Name = nm;
            GroupNumber = gn;
        }
    }

    class Group
    {
        public int Number { get; set; }
        public string GroupName { get; set; }

        public Group(int n, string gn)
        {
            Number = n;
            GroupName = gn;
        }
    }
}