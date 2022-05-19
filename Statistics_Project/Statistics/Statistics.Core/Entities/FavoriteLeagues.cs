using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class FavoriteLeagues:BaseEntity

    {
        public FavoriteLeagues()
        {
            this.Favorites = new List<FavoritesEntity>();
        }

        [ForeignKey(nameof(LeagueId))]
        public LeaguesEntity MyLeagues { get; set; }
        public Guid LeagueId { get; set; }
        public ICollection<FavoritesEntity> Favorites { get; set; }

    }
}
