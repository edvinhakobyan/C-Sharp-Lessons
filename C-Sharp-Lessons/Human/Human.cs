using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public string gender { get; set; }

        public Human()
        {

        }
        public Human(string name):this()
        {
            this.name = name; 
        }
        public Human(string name, string surname) : this(name)
        {
            this.surname = surname;
        }
        public Human(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }
        public Human(string name, string surname, int age, double weight) : this(name, surname, age)
        {
            this.weight = weight;
        }
        public Human(string name, string surname, int age, double weight, string gender) : this(name, surname, age, weight)
        {
            this.gender = gender;
        }
    }
}


