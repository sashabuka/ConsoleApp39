// See https://aka.ms/new-console-template for more information
using ConsoleApp39.DbModel;
using Microsoft.EntityFrameworkCore;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }


    public ProductContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Product>().HasKey(x => x.Id);
        modelBuilder.Entity<Product>().Property(x => x.Id).UseIdentityColumn(1,1);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ProductDb;Trust Server Certificate=True;User ID=sa;Password=yourStrong(!)Password;Multi Subnet Failover=true");
    }
}
