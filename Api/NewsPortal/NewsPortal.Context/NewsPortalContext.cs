using Microsoft.EntityFrameworkCore;
using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Context
{
    public class NewsPortalContext: DbContext
    {
        public NewsPortalContext(DbContextOptions<NewsPortalContext> options) : base(options) { }



        public DbSet<User> SystemUsers { get; set; }
        public DbSet<UserRoll>  UserRolls { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Feed>  Feeds { get; set; }
        public DbSet<Rating>  Ratings { get; set; }
        public DbSet<Comments>  Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region Benefits
            modelBuilder.Entity<UserRoll>().HasData(
                new UserRoll { ID = 2, Name = "Reader"},
                new UserRoll { ID = 1, Name = "Admin"}
                );
            #endregion

        }
    }
}
