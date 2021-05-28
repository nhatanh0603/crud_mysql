using System;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CRUD_MYSQL.Models;

namespace CRUD_MYSQL.Data
{
    public class CRUD_MYSQLContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=demo;uid=root;password=", new MySqlServerVersion(new Version(5, 7, 24)))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
