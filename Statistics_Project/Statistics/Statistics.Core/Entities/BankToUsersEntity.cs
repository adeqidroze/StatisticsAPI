using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Entities
{
    public class BankToUsersEntity :BaseEntity
    {
        [ForeignKey(nameof(UserId))]
        public UsersEntity User { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey(nameof(BankAccountId))]
        public BankAccountsEntity BankAccount { get; set; }
        public Guid BankAccountId { get; set; }


    }
}
