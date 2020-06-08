using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace HighScores
{
    class HighscoreInitializer : DropCreateDatabaseAlways<HighscoreContext>
    {
        protected override void Seed(HighscoreContext ctx)
        {
            base.Seed(ctx);
            var user = new User() { Name = "Karl" };
            var user2 = new User() { Name = "Peter" };
            var user3 = new User() { Name = "Heinz" };

            ctx.Users.Add(user);
            ctx.Users.Add(user2);
            ctx.Users.Add(user3);

            var game = new Game { Name = "CoD" };
            var game2 = new Game { Name = "LoL" };
            var game3 = new Game { Name = "CsGo" };

            ctx.Games.Add(game);
            ctx.Games.Add(game2);
            ctx.Games.Add(game3);

            var score = new Score { Name = "Score1", Game = game, User = user, Points = 100 };
            var score2 = new Score { Name = "Score2", Game = game2, User = user2, Points = 11 };
            var score3 = new Score { Name = "Score3", Game = game3, User = user3, Points = 51 };

            ctx.Scores.Add(score);
            ctx.Scores.Add(score2);
            ctx.Scores.Add(score3);

            ctx.SaveChanges();


        }
    }

}
