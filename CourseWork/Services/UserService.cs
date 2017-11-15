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
    using Faker;

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

        async public Task AddUsers(IEnumerable<User> users)
        {
            await UseDb(async db => {
                db.Users.AddRange(users);
                await db.SaveChangesAsync();
            });
        }

        async public Task<bool> CheckLoginUser(string login, string pass)
        {
            var hash = CryptoService.Get().GetMd5Hash(pass);
            return await UseDb(async db =>
                await db.Users
                        .AnyAsync(u => u.Login == login && u.Password == hash)
            );
        }

        async public Task<User> GetUserByLogin(string login)
        {
            return await UseDb(async db => await db.Users.FirstOrDefaultAsync(u => u.Login == login));
        }

        public async Task<int> GetUsersCountAsync()
        {
            return await UseDb(async db => await db.Users.CountAsync());
        }

        //для грида - получить срез данных на страницу
        //skip - пропустить n записей
        //take - взять n записей
        public async Task<List<User>> SkipTakeUsersAsync(int skip, int take)
        {
            return await UseDb(
                async db => await db.Users
                    .OrderBy(u => u.Id)
                    .Skip(skip)
                    .Take(take)
                    .ToListAsync()
            );
        }
    }
}
