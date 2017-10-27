using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Views
{
    using Services;

    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();

            this.btnEnter.Click += async (object sender, EventArgs e) => await LoginUser();
        }

        UserService userService { get { return UserService.Get(); } }

        async Task LoginUser()
        {
            try
            {
                var login = this.txtLogin.Text.Trim();
                var pass = this.txtPassword.Text.Trim();

                var isUserExist = await userService.CheckLoginUser(login, pass);
                if (isUserExist)
                {
                    MainFormService.ShowAppView(
                        await userService.GetUserByLogin(login)
                    );
                }
                else
                {
                    MainFormService.ShowInfo("Не верный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }            
        }

        
    }
}
