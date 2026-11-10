using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Common.Interfaces;

namespace Infrastructure.Data;

public class AppDbContext : DbContext, IApplicationDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}