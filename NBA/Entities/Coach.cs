using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Coach : Person
    {
        public Coach(string name, DateTime birthDay) : base(name, birthDay) { }
        public int yearsOfExperience { get; set; }

    }
}
