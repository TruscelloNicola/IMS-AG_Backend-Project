﻿using DeerDiary_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DeerDiary_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<JournalEntry> JournalEntries { get; set; }
        public virtual DbSet<RandomQuestion> RandomQuestions { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TokenBlacklist> TokenBlacklists { get; set; }

    }
}