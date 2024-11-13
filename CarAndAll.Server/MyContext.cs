using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyContext : IdentityDbContext<ApplicationUser>{
    protected override void OnConfiguring(DbContextOptionsBuilder b) => b.UseSqlite("Data Source=database.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    // Dbsets komen hier ...
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }


}