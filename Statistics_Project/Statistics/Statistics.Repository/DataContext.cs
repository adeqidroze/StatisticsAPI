using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Statistics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Repository
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        //public DataContext()
        //{
                
        //}
        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<BankAccountsEntity> BankAccounts { get; set; }
        public DbSet<BankToUsersEntity> BankToUsers { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<LeaguesEntity> Leagues { get; set; }
        public DbSet<MatchDuoesEntity> TeamsToMatches { get; set; }
        public DbSet<MatcheEntiry> Matches { get; set; }
        public DbSet<MatchPositionsEntity> MatchesToPositions { get; set; }
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<PositionsEntity> Positions { get; set; }
        public DbSet<TeamsEntity> Teams { get; set; }
        public DbSet<FavoritesEntity> Fvavorites { get; set; }
        public DbSet<FavoritePositions> FavoritePositions { get; set; }
        public DbSet<FavoriteLeagues> FavoriteLeagues { get; set; }



        protected override void OnModelCreating(ModelBuilder builder) 
        {
            foreach (var relation in builder.Model.GetEntityTypes().SelectMany(x=>x.GetForeignKeys()))
            {
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(builder);
            builder.Entity<AddressEntity>().HasOne(U => U.User).WithMany(U => U.UserAddresses).HasForeignKey(U => U.UserId);
            builder.Entity<BankToUsersEntity>().HasOne(U => U.User).WithMany(U => U.BankToUser).HasForeignKey(U => U.UserId);
            builder.Entity<BankToUsersEntity>().HasOne(U => U.BankAccount).WithMany(U => U.BankToUserEntity).HasForeignKey(U => U.BankAccountId);
            builder.Entity<MatchPositionsEntity>().HasOne(U => U.Position).WithMany(U => U.MatchPositions).HasForeignKey(U => U.PositionId);
            builder.Entity<MatchPositionsEntity>().HasOne(U => U.Match).WithMany(U => U.MatchToPosition).HasForeignKey(U => U.MatchId);
            builder.Entity<MatchDuoesEntity>().HasOne(U => U.Match).WithMany(U => U.DuosForMatch).HasForeignKey(U => U.MatchId);
            builder.Entity<MatchDuoesEntity>().HasOne(U => U.Team).WithMany(U => U.Matches).HasForeignKey(U => U.TeamId);
            builder.Entity<TeamsEntity>().HasOne(U => U.Country).WithMany(U => U.TeamsCountries).HasForeignKey(U => U.CountryId);
            builder.Entity<PlayerEntity>().HasOne(U => U.TeamName).WithMany(U => U.TeamPlayer).HasForeignKey(U => U.TeamId);
            builder.Entity<MatcheEntiry>().HasOne(U => U.League).WithMany(U => U.Matches).HasForeignKey(U => U.LeagueId);
            builder.Entity<FavoritesEntity>().HasOne(U => U.User).WithMany(U => U.Favorites).HasForeignKey(U => U.UserId);
            //builder.Entity<FavoritePositions>().HasOne(U => U.MyLeagues).WithMany(U => U.FavPositions).HasForeignKey(U => U.PositionId);
            //builder.Entity<FavoriteLeagues>().HasOne(U => U.MyPositions).WithMany(U => U.FavLeagues).HasForeignKey(U => U.LeagueId);



        }
    }
}
