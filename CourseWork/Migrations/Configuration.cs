namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Dal;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseWorkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseWorkDbContext context)
        {
            context.Users.AddOrUpdate(
                u => u.Login,
                new User
                {
                    Login = "root",
                    Password = "root"
                }
            );
        }
    }
}
