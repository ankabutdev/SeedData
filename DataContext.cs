using Microsoft.EntityFrameworkCore;
using SeedData.Models;

namespace SeedData;

public class DataContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Bus> Buses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConstans.DB_CONNECTIONSTRING);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
            new Car { Id = 1, Name = "BMW", },
            new Car { Id = 2, Name = "Mutsubity" }
        );
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>().HasData(
            new Client { Id = 3, Name = "Ali Karimov", },
            new Client { Id = 4, Name = "Jamol Fozilov" }
        );
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Bus>().HasData(
            new Bus { Id = 5, Name = "Mers", },
            new Bus { Id = 6, Name = "Mers" }
        );
        base.OnModelCreating(modelBuilder);
    }

}
