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
        //используется в классе наследнике для доступа к контексту БД
        //прокидывается функция в которую передается созданный контекст db
        protected T UseDb<T>(Func<CourseWorkDbContext, T> f)
        {
            //using автоматически вызывает метод db.Dispose() для очистки ресурсов
            //создаем db
            using (var db = new CourseWorkDbContext())
            {
                //прокидываем соданный контекст в ф-ю
                //таким образом инкапсулируем создание контекста БД
                return f(db);
            }
        }
    }
}
