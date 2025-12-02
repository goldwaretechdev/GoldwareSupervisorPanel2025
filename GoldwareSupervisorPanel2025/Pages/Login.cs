using GoldwareSupervisorPanel2025.Pages;
using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;

namespace GoldwareSupervisorPanel2025
{
    public partial class Login : Form
    {
        private readonly ICommonService _commonService;
        public Login(ICommonService commonService)
        {
            InitializeComponent();
            _commonService = commonService;
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

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



        private void btn_login_Click(object sender, EventArgs e)
        {
            //check data
            SelectUnit selectUnit = new SelectUnit(_commonService); // create an instance of Form2
            selectUnit.Show();
            Hide();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_desc_Click_1(object sender, EventArgs e)
        {

        }




       
        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
