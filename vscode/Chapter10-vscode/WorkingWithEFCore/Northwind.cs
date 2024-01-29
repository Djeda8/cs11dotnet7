using Microsoft.Data.SqlClient; // To use SqlConnectionStringBuilder.
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client; // To use DbContext, DbContextOptionsBuilder.

namespace Packt.Shared;

// This manages the connection to the database.
public class Northwind : DbContext
{
    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    {
        SqlConnectionStringBuilder builder = new();

        builder.DataSource = "."; // "ServerName\InstanceName" e.g. @".\sqlexpress"
        builder.InitialCatalog = "Northwind";
        builder.IntegratedSecurity = true;
        builder.TrustServerCertificate = true;
        builder.MultipleActiveResultSets = true;
        builder.ConnectTimeout = 3; // Because we want to fail fast. Default is 15 seconds.

        string? connection = builder.ConnectionString;

        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection: {connection}");
        ForegroundColor = previousColor;

        optionsBuilder
            .UseSqlServer(connection);
        // optionsBuilder.LogTo(Console.WriteLine) // Console
        //     .EnableSensitiveDataLogging();
    }
}