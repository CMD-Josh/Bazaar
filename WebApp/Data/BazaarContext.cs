using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class BazaarContext : DbContext
    {
        public BazaarContext (DbContextOptions<BazaarContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.User> User { get; set; } = default!;

        public DbSet<WebApp.Models.Listing>? Listing { get; set; }

        public DbSet<WebApp.Models.Report>? Report { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new { Id = 1, Email = "Foo@Bar.com", Password = "Pass", Type = WebApp.Models.Account.Role.User });

            modelBuilder.Entity<User>().HasData(
                new { Id = 1, UserName = "Scruff", CreationDate = DateTime.Now, Reputation = 0, Avatar = "Pic url", AccountId = 1 });

            modelBuilder.Entity<Listing>().HasData(
                new { Id = 1, Name = "Test Listing Name", Type = WebApp.Models.Listing.ListingType.Continuous, CreationTime = DateTime.Now, AuthorId = 1 });
        }

        public DbSet<WebApp.Models.Account>? Account { get; set; }
    }
}
