using Microsoft.EntityFrameworkCore;
using WeatherAppBot.Entities.Entities;

namespace WeatherAppBot.DataAccess
{
    public class AppDbContext : DbContext
    {
        private static string _connStr = @"
               Server=localhost;
               Database=WeatherGeoDB;
               User Id=SA;
               Password=GlobalLogicDocker001
               ";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connStr);
            /*"Server=.\\SQLEXPRESS;Database=WeatherGeoDB;Trusted_Connection=True"*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<City> Cities { get; set; }
    }
}
