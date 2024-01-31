using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

namespace WorkingWithEFCore.AutoGen;

public partial class Northwind : DbContext
{
    public Northwind()
    {
    }

    public Northwind(DbContextOptions<Northwind> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Northwind.db");
            //.LogTo(WriteLine)
            //.EnableSensitiveDataLogging();
            //.UseLazyLoadingProxies();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            //entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.Discontinued).HasDefaultValueSql("0");
            entity.Property(e => e.Cost).HasDefaultValueSql("0");
            entity.Property(e => e.Stock).HasDefaultValueSql("0");
        });

        // example of using Fluent API instead of attributes
        // to limit the length of a category name to 15
        modelBuilder.Entity<Category>()
        .Property(category => category.CategoryName)
        .IsRequired() // NOT NULL
        .HasMaxLength(15);
        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            // added to "fix" the lack of decimal support in SQLite
            modelBuilder.Entity<Product>()
            .Property(product => product.Cost)
            .HasConversion<double>();
        }

        // global filter to remove discontinued products
        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => !p.Discontinued);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
