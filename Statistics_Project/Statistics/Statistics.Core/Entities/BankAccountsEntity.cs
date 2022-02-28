using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class BankAccountsEntity : BaseEntity
    {
        public BankAccountsEntity()
        {
            this.BankToUserEntity = new List<BankToUsersEntity>();
        }
        public string CardNumber { get; set; }
        public string CCV { get; set; }
        public string ExpirationDate { get; set; }

        public ICollection<BankToUsersEntity> BankToUserEntity  { get; set; }
    }
}
