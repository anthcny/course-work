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

        public async Task<bool> IsValidUser(string login, string password)
        {
            return await UserSrv.CheckLoginUser(login, password);
        }
    }
}
