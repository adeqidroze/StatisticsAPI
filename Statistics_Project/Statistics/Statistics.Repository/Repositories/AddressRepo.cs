using Microsoft.EntityFrameworkCore;
using Statistics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Repository.Repositories
{
    public class AddressRepo
    {
        private readonly DataContext context;
        private DbSet<AddressEntity> dbSet;

        public AddressRepo(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<AddressEntity>();
        }

        public DbSet<AddressEntity> GetCollection()
        {
            return dbSet;
        }

        public async Task<AddressEntity> FindAsync (Guid id) 
        {
            return await dbSet.Where(A => A.Id == id).Include(A => A.User).FirstOrDefaultAsync();  //.ThenInclude()
        }


        public async Task DeleteAsync(Guid id)
        {
            var address = await FindAsync(id);
            if (context.Entry(address).State == EntityState.Detached)
            {
                dbSet.Attach(address);
            }
            dbSet.Remove(address);
        }     

        public async Task InsertAsync(AddressEntity address) 
        {
           await dbSet.AddAsync(address); 
        }

        public void UpdateAsync(AddressEntity address) 
        {
            dbSet.Attach(address);   
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }

}
