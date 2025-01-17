﻿using ChallengeDisneyAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisneyAPI.Context
{
    public class ChallengeContext : DbContext 
    {
        public ChallengeContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Characters> Characters { get; set; } = null!;
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        
    }
}
