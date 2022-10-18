using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Score
    {
        public Score(Player scorer, DateTime timeOfScore, Team teamOfScore)
        {
            this.scorer = scorer;
            this.timeOfScore = timeOfScore;
            this.teamOfScore = teamOfScore;
        }

        public Player scorer { get; set; }
        public DateTime timeOfScore { get; set; }

        public Team teamOfScore { get; set; }
    }
}
