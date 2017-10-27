using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CourseWork.Services
{
    using Dal;

    class UserService: BaseService
    {
        public static UserService Get()
        {
            return new UserService();
        }

        async public Task<List<User>> GetUsers(Expression<Func<User, bool>> predicate = null)
        {
            return await UseDb(async db => 
                predicate == null
                ? await db.Users.ToListAsync()
                : await db.Users.Where(predicate).ToListAsync());
        }

        async public Task AddUser(User user)
        {
            await UseDb(async db => {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            });
        }

        async public Task<bool> CheckLoginUser(string login, string pass)
        {
            var user = await UseDb(async db => await db.Users.FirstOrDefaultAsync(u => u.Login == login && u.Password == pass));
            return user != null;
        }

        async public Task<User> GetUserByLogin(string login)
        {
            return await UseDb(async db => await db.Users.FirstOrDefaultAsync(u => u.Login == login));
        }
    }
}
