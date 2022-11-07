using Microsoft.EntityFrameworkCore;

namespace EasyCation.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {
            
    }
    public DbSet<Account> Accounts { get; set; }
}