using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services.Contracts
{
    public interface IAuthService
    {
        bool IsValidUser(string login, string password);
    }
}
