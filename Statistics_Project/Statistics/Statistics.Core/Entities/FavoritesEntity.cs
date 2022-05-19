using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class FavoritesEntity :BaseEntity

    {
        [ForeignKey(nameof(UserId))]
        public UsersEntity? User { get; set; }
        public string? UserId { get; set; }

        [ForeignKey(nameof(TeamId))] 
        public TeamsEntity FavTeam { get; set; }  
        public Guid TeamId { get; set; }
       
        [ForeignKey(nameof(LeagueId))]
        public FavoriteLeagues FavLeague { get; set; }
        public Guid LeagueId { get; set; }
        
        [ForeignKey(nameof(PositionId))]
        public FavoritePositions FavPosition { get; set; }
        public Guid PositionId { get; set; }
    }
}
