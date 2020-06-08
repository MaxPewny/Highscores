using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace HighScores
{
    public class HighscoreContext : DbContext
    {
        public HighscoreContext() : base() { }

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }

        static HighscoreContext() 
        {
            Database.SetInitializer<HighscoreContext>(new HighscoreInitializer());
        }
    }
}
