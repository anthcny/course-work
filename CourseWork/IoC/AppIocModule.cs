using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.IoC
{
    using Ninject.Modules;
    using Services.Contracts;
    using Services;
    using Views;

    class AppIocModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<LoginView>().ToSelf();
            Bind<ExcelService>().ToSelf();
        }
    }
}
