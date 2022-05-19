using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class FavoritePositions:BaseEntity

    {
        public FavoritePositions()
        {
            this.Favorites = new List<FavoritesEntity>();
        }

        [ForeignKey(nameof(PositionId))]
        public PositionsEntity MyPositions { get; set; }
        public Guid PositionId { get; set; }
        public ICollection<FavoritesEntity> Favorites { get; set; }

    }
}
