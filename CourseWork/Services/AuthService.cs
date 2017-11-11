using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    using Contracts;

    class AuthService: IAuthService
    {
        IUserService UserSrv;

        public AuthService(IUserService userSrv)
        {
            UserSrv = userSrv;
        }

        public bool IsValidUser(string login, string password)
        {
            var task = UserSrv.CheckLoginUser(login, password);
            Task.WaitAll(task);
            return task.Result;
        }
    }
}
