using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class LeaguesEntity:BaseEntity

    {
        public LeaguesEntity()
        {
            this.Matches = new List<MatcheEntiry>();
        }
        public string LeagueName { get; set; }
        public DateTime StartDate { get; set; }
        public int DateTime { get; set; }

        public ICollection<MatcheEntiry> Matches { get; set; }
        public ICollection<FavoriteLeagues> FavLeagues { get; set; }
    }
}
