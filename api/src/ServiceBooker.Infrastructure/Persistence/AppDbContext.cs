using Microsoft.EntityFrameworkCore;

namespace ServiceBooker.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Add DbSet<T> here later (Day 2)
    // public DbSet<Customer> Customers => Set<Customer>();
}

