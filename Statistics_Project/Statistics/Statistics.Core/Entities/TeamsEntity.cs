using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class TeamsEntity : BaseEntity

    {
        public TeamsEntity()
        {
            this.TeamPlayer = new List<PlayerEntity>();
            this.Matches = new List<MatchDuoesEntity>();
            this.Favorites = new List<FavoritesEntity>();
            this.User = new List<UsersEntity>();
        }
        public string TeamName { get; set; }

        [ForeignKey(nameof(CountryId))]
        public CountryEntity Country { get; set; }
        public Guid CountryId { get; set; }

        public ICollection<PlayerEntity>? TeamPlayer { get; set; }
        public ICollection<MatchDuoesEntity> Matches { get; set; }
        public ICollection<FavoritesEntity> Favorites { get; set; }

        public ICollection<UsersEntity> User { get; set; }
    }
}
