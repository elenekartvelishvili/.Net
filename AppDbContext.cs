using Lecture_7_1.Entities;
using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;

namespace Lecture_7_1.Context;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(
            "Server=DESKTOP-7450GMH;Database=DotNet;Trusted_Connection=True;TrustServerCertificate=True");
}