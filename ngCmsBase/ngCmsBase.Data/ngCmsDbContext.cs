using Microsoft.EntityFrameworkCore;
using ngCmsBase.Core.Domain.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Data
{
    public class ngCmsDbContext : DbContext
    {

        public ngCmsDbContext(DbContextOptions<ngCmsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.UserName)
                .IsRequired();
        }

        public DbSet<User> Users { get; set; }
        
    }
}
