using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Person
    {
        public Person(string name, DateTime birthDay)
        {
            this.name = name;
            this.birthDay = birthDay;
        }

        public string name { get; set; }
        public DateTime birthDay { get; set; }
    }
}
