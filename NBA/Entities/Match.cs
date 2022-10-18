using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Match
    {
        public Match (Team home, Team visitors, List<Referee> referees, int rounds, DateTime time)
        {
            this.home = home;
            this.visitors = visitors;
            this.referees = referees;
            this.rounds = rounds;
            this.time = time;
        }

        public Team home { get; set; }
        public Team visitors { get; set; }
        public List<Referee> referees { get; set; }
        public List<Score> ? scores  { get; set; }
        
        public int rounds { get; set; }
        public DateTime time { get; set; }



    }
}
