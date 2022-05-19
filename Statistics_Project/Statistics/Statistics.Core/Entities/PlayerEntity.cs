using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class PlayerEntity: BaseEntity

    {
     
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string PlayerCountry { get; set; }

        [ForeignKey(nameof(TeamId))]
        public TeamsEntity TeamName { get; set; }
        public Guid TeamId { get; set; }
    }
}
