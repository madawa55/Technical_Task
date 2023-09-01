using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseInMemoryDatabase(databaseName: "UserDb");

        public virtual DbSet<User> Users
        {
            get;
            set;
        }
        
    }
}
