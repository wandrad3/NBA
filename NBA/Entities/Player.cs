using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Player: Person
    {

        public Player(string name, DateTime birthDay, string position) : base(name, birthDay) {

            this.position = position;
        }

        public int height {  get; set; }
        public int weight { get; set; }
        public string position { get; set; }

        
    }
}
