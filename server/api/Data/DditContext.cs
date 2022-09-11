using fr.pierrejulien.ddit.api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace fr.pierrejulien.ddit.api.Data;

public class DditContext : IdentityDbContext
{
    public DbSet<RedditModel> Reddits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=database.db3");
}