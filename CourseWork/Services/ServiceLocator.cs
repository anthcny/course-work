using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    using Contracts;
    using IoC;
    using Ninject;

    public static class ServiceLocator
    {
        static ServiceLocator()
        {
            if (!Kernel.IsLoaded)
                Kernel.LoadKernel();
        }

        public static IUserService GetUserService()
        {
            return Kernel.Instance.Get<IUserService>();
        }

        public static T Create<T>(string named = null)
        {
            return named == null
                ? Kernel.Instance.Get<T>()
                : Kernel.Instance.Get<T>(named);
        }
    }
}
