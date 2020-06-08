using System;
using System.Collections.Generic;
using System.Text;

namespace HighScores
{
    public class Score
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Points { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}
