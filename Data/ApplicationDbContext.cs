using CommunityApp_Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp_Lab3.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<Province>? Provinces { get; set; }
    public DbSet<City>? Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // builder.Entity<City>().Property(m => m.Province).IsRequired();
        // builder.Entity<Province>().Property(p => p.ProvinceCode).HasMaxLength(30);

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
    } 
    
}
