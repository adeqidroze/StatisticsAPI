using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class MatcheEntiry:BaseEntity

    {
        public MatcheEntiry()
        {
            this.DuosForMatch = new List<MatchDuoesEntity>();
            this.MatchToPosition = new List<MatchPositionsEntity>();
        }
        public string MatchStartTime { get; set; }
        public string MatchEndTime { get; set; }

        [ForeignKey(nameof(LeagueId))]
        public LeaguesEntity League { get; set; }
        public Guid LeagueId { get; set; }

        public ICollection<MatchDuoesEntity> DuosForMatch { get; set; }
        public ICollection<MatchPositionsEntity> MatchToPosition { get; set; }
    }
}
