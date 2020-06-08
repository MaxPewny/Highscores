using System;
using System.Collections.Generic;
using System.Text;

namespace HighScores
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}
