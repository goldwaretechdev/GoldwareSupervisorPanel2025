using GoldwareSupervisorPanel2025.Models;
using GoldwareSupervisorPanel2025.Properties.services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Forms.Login.loginControl
{
    public partial class LoginControl : UserControl
    {
        private readonly ICommonService _commonService;
        private readonly IUserService _userService;
        private readonly IServiceProvider _provider;
        public event Action? OnLogin;
        public List<RoleDto> Roles = new();
        public LoginInfo Info = new();
        public LoginControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _provider = serviceProvider;

            _commonService = _provider.GetRequiredService<ICommonService>();
            _userService = _provider.GetRequiredService<IUserService>();
            if (_commonService.CheckInternetPing())
            {
                lbl_connection_status.Text = "connected to server ✔";
                lbl_connection_status.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbl_connection_status.Text = "Check Internet Connection!";
                lbl_connection_status.ForeColor = Color.FromArgb(169, 15, 15);
            }

            txt_box_username.TextChanged += text_box_username_TextChanged;
            txt_box_pass.TextChanged += txt_box_pass_TextChanged;
            txt_box_username.Enter += txt_box_username_Enter;
            txt_box_username.Leave += txt_box_username_Leave;
            txt_box_username.MouseEnter += txt_box_username_MouseEnter;
            txt_box_username.MouseLeave += txt_box_username_MouseLeave;

            txt_box_pass.Enter += txt_box_pass_Enter;
            txt_box_pass.Leave += txt_box_pass_Leave;
            txt_box_pass.MouseEnter += txt_box_pass_MouseEnter;
            txt_box_pass.MouseLeave += txt_box_pass_MouseLeave;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txt_box_username.Text;
                var pass = txt_box_pass.Text;
                if (pass.Length<8)
                {
                    MessageBox.Show("رمز عبور حداقل ۸ کاراکتر میباشد!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var response = await _userService.Login(username, pass);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Roles = response.Data;
                Info.UserName = username;
                Info.Password=pass;
                //check data
                OnLogin?.Invoke();
            }catch(Exception ex)
            {
                MessageBox.Show("خطا در ارتباط با سرور!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region txt_username
        private void txt_box_username_Enter(object sender, EventArgs e)
        {
            txt_box_username.IconRight = _commonService.TintIcon(txt_box_username.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_box_username_Leave(object sender, EventArgs e)
        {
            txt_box_username.IconRight = _commonService.TintIcon(txt_box_username.IconRight, Color.FromArgb(150, 150, 150));
        }


        private void txt_box_username_MouseEnter(object sender, EventArgs e)
        {
            txt_box_username.IconRight = _commonService.TintIcon(txt_box_username.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_box_username_MouseLeave(object sender, EventArgs e)
        {
            if (!txt_box_username.Focused)
            {
                txt_box_username.IconRight = _commonService.TintIcon(txt_box_username.IconRight, Color.FromArgb(150, 150, 150));
            }
        }

        private void text_box_username_TextChanged(object sender, EventArgs e)
        {
            btn_login.Enabled = !string.IsNullOrEmpty(txt_box_username.Text) &&
                !string.IsNullOrEmpty(txt_box_pass.Text);
        }
        #endregion

        #region txt_pass

        private void txt_box_pass_Enter(object sender, EventArgs e)
        {
            txt_box_pass.IconRight = _commonService.TintIcon(txt_box_pass.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_box_pass_Leave(object sender, EventArgs e)
        {
            txt_box_pass.IconRight = _commonService.TintIcon(txt_box_pass.IconRight, Color.FromArgb(150, 150, 150));
        }


        private void txt_box_pass_MouseEnter(object sender, EventArgs e)
        {
            txt_box_pass.IconRight = _commonService.TintIcon(txt_box_pass.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_box_pass_MouseLeave(object sender, EventArgs e)
        {
            if (!txt_box_pass.Focused)
            {
                txt_box_pass.IconRight = _commonService.TintIcon(txt_box_pass.IconRight, Color.FromArgb(150, 150, 150));
            }
        }


        private void txt_box_pass_TextChanged(object sender, EventArgs e)
        {
            btn_login.Enabled = !string.IsNullOrEmpty(txt_box_username.Text) &&
              !string.IsNullOrEmpty(txt_box_pass.Text);
        }

        #endregion

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void txt_box_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
