using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TBS.Model;

namespace TBS.Repository
{
    public class TitleDBContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TitleGenre> TitleGenres { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<OtherName> OtherName { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<StoryLine> StoryLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }
}
