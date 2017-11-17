using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    using Contracts;
    using System.DirectoryServices.AccountManagement;

    public class AuthLdapService : IAuthService
    {
        const string DOMAIN = "HOME";
        const string SERVICE_LOGIN = @"HOME\Administrator";
        const string SERVICE_PASS = "!QAZxsw2123";

        public Task<bool> IsValidUser(string login, string password)
        {
            using (var context = new PrincipalContext(ContextType.Domain, DOMAIN, SERVICE_LOGIN, SERVICE_PASS))
            {
                return Task.FromResult(context.ValidateCredentials(login, password));
            }
        }
    }
}
