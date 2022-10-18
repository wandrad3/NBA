using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Season
    {
        public Season(List<Match> matches, DateTime year)
        {
            this.matches = matches;
            this.year = year;
        }

        public List<Match> matches { get; set; }
        public DateTime year { get; set; }
        public Player ? mostValuablePlayer { get; set; }


        public Player getTallerPlayer(List<Player> players)
        {
            return players.OrderBy(x => x.height).ToList().Last();
            
        }
    }

}
