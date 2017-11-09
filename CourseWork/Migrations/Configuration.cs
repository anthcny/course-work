namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Dal;
    using Services;

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
                    Password = CryptoService.Get().GetMd5Hash("root")
                }
            );
        }
    }
}
