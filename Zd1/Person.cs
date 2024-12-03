using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime date { get; set; }
        public Person(string name, string surname, DateTime date)
        {
            Name = name;
            Surname = surname;
            this.date = date;
        }
        public Person()
        {
            Name = "Петя";
            Surname = "Лионов";
            this.date = new DateTime(2000, 1, 1); 
        }
        public override string ToString()
        {
            return Name + Surname + date;
        }

        public virtual string ToShortString()
        {
            return Name + Surname;
        }
    }
}
