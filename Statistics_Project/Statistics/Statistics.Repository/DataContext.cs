using Microsoft.EntityFrameworkCore;
using Statistics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DataContext()
        {
                
        }
        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<BankAccountsEntity> BankAccounts { get; set; }
        public DbSet<BankToUsersEntity> BankToUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            builder.Entity<AddressEntity>().HasOne(U => U.User).WithMany(U => U.UserAddresses).HasForeignKey(U => U.UserId);
            builder.Entity<BankToUsersEntity>().HasOne(U => U.User).WithMany(U => U.BankToUser).HasForeignKey(U => U.UserId);
            builder.Entity<BankToUsersEntity>().HasOne(U => U.BankAccount).WithMany(U => U.BankToUserEntity).HasForeignKey(U => U.BankAccountId);
       
        }
    }
}
