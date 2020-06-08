using System;

namespace HighScores
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new HighscoreContext())
            {
                var user = new User() { Name = "Herbert" };

                ctx.Users.Add(user);
                //ctx.Entry(user).State = EntityState.Added;// Alternativ
                ctx.SaveChanges();
            }

        }
    }
}
