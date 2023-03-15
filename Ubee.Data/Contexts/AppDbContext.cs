using Microsoft.EntityFrameworkCore;
using Ubee.Domain.Entities;

namespace Ubee.Data.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server=localhost; Database=UbeeDb; User Id=postgres; password=jama1226";
        optionsBuilder.UseNpgsql(path);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Info> Infos { get; set; }
}
