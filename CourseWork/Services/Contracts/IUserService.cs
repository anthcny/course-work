using CourseWork.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services.Contracts
{
    public interface IUserService
    {
        void Load();

        Task<List<User>> GetUsers(Expression<Func<User, bool>> predicate = null);

        Task AddUser(User user);

        Task<bool> CheckLoginUser(string login, string pass);

        Task<User> GetUserByLogin(string login);
    }
}
