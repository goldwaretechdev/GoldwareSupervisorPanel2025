using GoldwareSupervisorPanel2025.Pages;
using GoldwareSupervisorPanel2025.Pages.Login.control;
using GoldwareSupervisorPanel2025.Pages.Login.loginControl;
using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025
{
    public partial class LoginForm : Form
    {
        private readonly ICommonService _commonService;
        private LoginControl _loginControl;
        private SelectUnitControl _selectUnitControl;
        public LoginForm(ICommonService commonService)
        {
            InitializeComponent();
            _commonService = commonService;
            _loginControl = new(_commonService);
            _selectUnitControl = new(_commonService);

            LoadLogin();

        }

        private void LoadStep(UserControl step)
        {
            panel_load_steps.Controls.Clear();           
            panel_load_steps.Controls.Add(step);
        }

        private void LoadLogin()
        {
            _loginControl.OnLogin += () => LoadStep(_selectUnitControl);
            LoadStep(_loginControl);
        }
       

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
