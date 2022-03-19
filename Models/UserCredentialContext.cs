using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace AuthorizationAPI.Models
{
    public class UserCredentialContext : DbContext
    {
        public UserCredentialContext() { }
        public UserCredentialContext(DbContextOptions<UserCredentialContext> options)
            : base(options)
        { }

        public virtual DbSet<UserCredentials> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCredentials>().HasData(
                     new UserCredentials { Id = 1, Username = "admin", Password = Crypto.HashPassword("admin"), Address = "Mumbai" },
                     new UserCredentials { Id = 2, Username = "user", Password = Crypto.HashPassword("user"), Address = "Delhi" }

                );
        }


    }
}