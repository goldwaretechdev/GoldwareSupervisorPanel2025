using GoldwareSupervisorPanel2025.Forms;
using GoldwareSupervisorPanel2025.Forms.Login.control;
using GoldwareSupervisorPanel2025.Forms.Login.loginControl;
using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025
{
    public partial class LoginForm : Form
    {
        private readonly ICommonService _commonService;
        private readonly IUserService _userService;
        private readonly IServiceProvider _provider;
        private LoginControl _loginControl;
        public LoginForm(ICommonService commonService,IUserService userService,IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
            _commonService = commonService;
            _userService = userService;
            _loginControl = _provider.GetRequiredService<LoginControl>();
            LoadLogin();

        }

        private void LoadStep(UserControl step)
        {
            panel_load_steps.Controls.Clear();
            panel_load_steps.Controls.Add(step);
        }

        private void LoadLogin()
        {
            _loginControl.OnLogin += () => 
            LoadStep(new SelectUnitControl( _loginControl.Roles,_loginControl.Info,_provider));
            LoadStep(_loginControl);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel_load_steps_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
