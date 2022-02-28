using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class AddressEntity : BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Guid UserId { get; set; }
        //[ForeignKey("UserId")]
        [ForeignKey(nameof(UserId))]
        public UsersEntity User { get; set; }
    }
}
