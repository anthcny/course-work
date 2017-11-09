using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    using Services;
    using IoC;
    using Dal;

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Kernel.LoadKernel();
            ServiceLocator.GetUserService().Load();

            //MainFormService.ShowLoginView();
            MainFormService.ShowAppView(new User());

            Application.Run(MainFormService.MainForm);            
        }
    }
}
