using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    using Services;
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

            MainFormService.ShowLoginView();
            //MainFormService.ShowAppView(new User());
            Application.Run(MainFormService.MainForm);            
        }

        //static void Main()
        //{
        //    var task = Task.Run(async () =>
        //    {
        //        Console.WriteLine("Start");

        //        var userSrv = UserService.Get();
        //        var users = await userSrv.GetUsers();

        //        ShowUsers(users);

        //        await userSrv.AddUser(new User
        //        {
        //            Login = "root",
        //            Password = "root"
        //        });

        //        users = await userSrv.GetUsers();

        //        ShowUsers(users);

        //        Console.ReadLine();
        //    });

        //    Task.WaitAll(task);

        //}

        //static void ShowUsers(List<User> users)
        //{
        //    if (users == null)
        //        return;

        //    if (users.Count > 0)
        //        users.ForEach(u => Console.WriteLine(u.ToString()));
        //    else
        //        Console.WriteLine("no users found");
        //}
    }
}
