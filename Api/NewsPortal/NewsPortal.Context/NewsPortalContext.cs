﻿using Microsoft.EntityFrameworkCore;
using NewsPortal.Context.Models;
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
    }
}
