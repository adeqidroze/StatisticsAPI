using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class MatchPositionsEntity:BaseEntity

    {
        public string NumberOfPosition { get; set; }

        [ForeignKey(nameof(MatchId))]
        public MatcheEntiry Match { get; set; }
        public Guid MatchId { get; set; }

        [ForeignKey(nameof(PositionId))]
        public PositionsEntity Position  { get; set; }
        public Guid PositionId { get; set; }

    }
}
