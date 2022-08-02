using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Contexts;

public class DditContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Reddit> Reddits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=D:\Code\ddit\server\data\database.db3");
}