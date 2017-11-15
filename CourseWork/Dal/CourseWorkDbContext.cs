using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal //Data Access Layer
{
    //контекст инкапсулирует работу с БД
    
    public class CourseWorkDbContext: DbContext
    {
        //таблица юзеров (набор строк сущностей User)
        public DbSet<User> Users { get; set; }

        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Traffic> Traffics { get; set; }

        public DbSet<Cargo> Cargoes { get; set; }

        //создание контекста -  в бахзовый класс передается имя подключения
        //имя подключения прописано в конфиге
        public CourseWorkDbContext(): base("DefaultConnection")
        {
        }
    }
}
