using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class UsersEntity : BaseEntity
    {
        public UsersEntity()
        {
            this.UserAddresses = new List<AddressEntity>();
            this.BankToUser = new List<BankToUsersEntity>();
        }


        public String FirstName { get; set; }
        public String LastName { get; set; }       
        public String PersonalId { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }
        public Boolean Gender { get; set; }
    

        public ICollection<AddressEntity>? UserAddresses { get; set; }
        public ICollection<BankToUsersEntity> BankToUser { get; set; }
    }
}
