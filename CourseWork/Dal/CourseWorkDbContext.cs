using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal //Data Access Layer
{
    public class CourseWorkDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Traffic> Traffics { get; set; }

        public CourseWorkDbContext(): base("DefaultConnection")
        {
        }
    }
}
