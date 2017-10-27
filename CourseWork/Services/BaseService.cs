using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    using Dal;

    class BaseService
    {
        protected T UseDb<T>(Func<CourseWorkDbContext, T> f)
        {
            using (var db = new CourseWorkDbContext())
            {
                return f(db);
            }
        }
    }
}
