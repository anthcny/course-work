using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.IoC
{
    using Ninject;

    public class Kernel
    {
        public static IKernel Instance { get; private set; }

        public static bool IsLoaded { get; private set; }

        public static void LoadKernel()
        {
            Instance = new StandardKernel(new AppIocModule());
            IsLoaded = true;
        }
    }
}
