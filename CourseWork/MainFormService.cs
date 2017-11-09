using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    using Views;
    using Dal;
    using IoC;
    using Services;

    static class MainFormService
    {
        private static MainForm mainForm;
        private static User appUser;
        private static CourseWorkDbContext db;

        public static MainForm  MainForm { get { return mainForm;  } }
        public static User AppUser { get { return appUser; } }
        public static CourseWorkDbContext Db { get { return db; } }



        static MainFormService()
        {
            db = new CourseWorkDbContext();
            mainForm = new MainForm();
        }

        public static void LogoutUser()
        {
            appUser = null;
        }

        public static void ShowLoginView()
        {
            SetView(ServiceLocator.Create<LoginView>());
        }

        public static void SetStatusBarText(string text)
        {
            mainForm.SetStatus(text);
        }

        public static void ShowAppView(User user)
        {
            appUser = user;
            SetView(ServiceLocator.Create<AppView>());
            MainForm.WindowState = FormWindowState.Maximized;
        }

        static UserControl StyleControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            return control;
        }

        static void SetView(UserControl view)
        {
            view = StyleControl(view);
            mainForm.HostControl.Clear();
            mainForm.HostControl.Add(view);
        }

        public static void ShowError(string error)
        {
            MessageBox.Show(mainForm, error, "Ошибка");
        }

        public static void ShowInfo(string info)
        {
            MessageBox.Show(mainForm, info, "Информация");
        }
    }
}
