using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class PositionsEntity:BaseEntity

    {
        public PositionsEntity()
        {
            this.MatchPositions = new List<MatchPositionsEntity>();
            this.FavPositions = new List<FavoritePositions>();
        }
        public string PositionName { get; set; }

        public ICollection<MatchPositionsEntity> MatchPositions { get; set; }
        public ICollection<FavoritePositions> FavPositions { get; set; }
    }
}
