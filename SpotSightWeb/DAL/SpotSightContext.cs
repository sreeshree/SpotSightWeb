using SpotSightWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SpotSightWeb.DAL
{
    public class SpotSightContext : DbContext
    {

        public SpotSightContext(): base("SpotSightContext")
        {
        }
        
        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}