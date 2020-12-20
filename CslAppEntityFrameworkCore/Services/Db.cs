using CslAppEntityFrameworkCore.Models;
using CslAppEntityFrameworkCore.Models.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CslAppEntityFrameworkCore.Services
{
    public sealed class Db : DbContext
    {
        public DbSet<People> People { get; set; }
        public DbSet<Address> Address { get; set; }

        //public Db(DbContextOptions<Db> options)
        //    :base(options)
        //{
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = base.db", options =>
            {
                
            });
            optionsBuilder.LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information) ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PeopleMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
        }
    }
}
