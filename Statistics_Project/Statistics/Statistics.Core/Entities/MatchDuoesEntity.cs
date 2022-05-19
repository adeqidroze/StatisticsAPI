using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class MatchDuoesEntity : BaseEntity

    {

        [ForeignKey(nameof(MatchId))]
        public MatcheEntiry Match { get; set; }
        public Guid MatchId { get; set; }

        [ForeignKey(nameof(TeamId))]
        public TeamsEntity Team { get; set; }
        public Guid TeamId { get; set; }
    }
}
