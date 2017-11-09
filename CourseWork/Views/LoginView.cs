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
    using Services.Contracts;

    public partial class LoginView : UserControl
    {
        private IUserService userService;

        public LoginView(IUserService userService)
        {
            InitializeComponent();

            this.userService = userService;

            this.btnEnter.Click += async (object sender, EventArgs e) => await LoginUser();
            KeyEventHandler enterHandler = async (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    await LoginUser();
            };
            this.txtLogin.KeyDown += enterHandler;
            this.txtPassword.KeyDown += enterHandler;
        }

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
