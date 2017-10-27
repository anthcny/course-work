namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Dal;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseWork.Dal.CourseWorkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseWorkDbContext context)
        {
            //  This method will be called after migrating to the latest version.

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
