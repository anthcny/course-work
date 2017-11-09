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
    using Contracts;

    class UserService: BaseService, IUserService
    {
        public static UserService Get()
        {
            return new UserService();
        }

        public void Load()
        {
            UseDb(db => 
            {
                db.Users.Load();
                return 0; //надо для generic метода возвратить чтонибудь кроме (не void)
            });
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
            return await UseDb(async db =>
                await db.Users
                        .AnyAsync(u => u.Login == login && u.Password == pass)
            );
        }

        async public Task<User> GetUserByLogin(string login)
        {
            return await UseDb(async db => await db.Users.FirstOrDefaultAsync(u => u.Login == login));
        }
    }
}
