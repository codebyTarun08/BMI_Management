using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMANAGEMENT
{
    internal class Person
    {
        public string Name;
        public double Weight;
        public double Height;

        public Person(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
    }
}
