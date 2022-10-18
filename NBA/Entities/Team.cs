using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Team
    {
        public Team(string name, List<Player> players, Coach coach)
        {
            this.name = name;
            this.players = players;
            this.coach = coach;
        }

        public string name { get; set; }
        public enum region { EAST, WEAST };
        public List<Player> players { get; set; }
        public Coach coach { get; set; }


    }
}
