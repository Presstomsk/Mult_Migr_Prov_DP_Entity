
using EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF.Lib
{
    public class MSDataBase : DbContext
    {


        public DbSet<Game> TabGames { get; set; }

        public MSDataBase() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config_1 = new ConfigurationBuilder()
                .AddJsonFile("appsettings_ms.json")
                .Build();
            var connectionString = config_1.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }


    }

    public class MySQLDataBase : MSDataBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config_2 = new ConfigurationBuilder()
                .AddJsonFile("appsettings_mysql.json")
                .Build();
            var connectionString = config_2.GetConnectionString("DefaultConnection");
            options.UseMySQL(connectionString);
        }
    }
}
