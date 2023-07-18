using Microsoft.EntityFrameworkCore;
using SeedData.Models;

namespace SeedData;

public class DataContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConstans.DB_CONNECTIONSTRING);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person { Id = 20, Name = "Ali Karimov" },
            new Person { Id = 22, Name = "Jamol Fozilov" }
        );
        base.OnModelCreating(modelBuilder);
    }

}
