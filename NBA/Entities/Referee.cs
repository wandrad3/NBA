using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Referee : Person
    {
        public Referee(string name, DateTime birthDay) : base(name, birthDay) { }
        public int yearsOfExperience;
    
    }
}
