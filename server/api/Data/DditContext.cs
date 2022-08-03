using fr.pierrejulien.ddit.api.Models;
using Microsoft.EntityFrameworkCore;

namespace fr.pierrejulien.ddit.api.Data;

public class DditContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Reddit> Reddits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=database.db3");
}