using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Statistics.Core.Entities
{
    public class UsersEntity : IdentityUser
    {
        public UsersEntity()
        {
            this.UserAddresses = new List<AddressEntity>();
            this.BankToUser = new List<BankToUsersEntity>();
            this.Favorites = new List<FavoritesEntity>();
        }


        public String FirstName { get; set; }
        public String LastName { get; set; }       
        public String PersonalId { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public Boolean Gender { get; set; }

        [ForeignKey(nameof(FavouriteTeamId))]
        public TeamsEntity FavoriteTeam { get; set; }
        public Guid FavouriteTeamId { get; set; }


        public ICollection<AddressEntity>? UserAddresses { get; set; }
        public ICollection<BankToUsersEntity> BankToUser { get; set; }
        public ICollection<FavoritesEntity> Favorites { get; set; }


    }
}
