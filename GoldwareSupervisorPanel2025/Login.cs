using GoldwareSupervisorPanel2025.design;
using GoldwareSupervisorPanel2025.Pages;

namespace GoldwareSupervisorPanel2025
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            txt_box_username.TextChanged += text_box_username_TextChanged;
            txt_box_pass.TextChanged += txt_box_pass_TextChanged;


        }

        private void Login_Load(object sender, EventArgs e)
        {
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            //check data
            SelectUnit selectUnit = new SelectUnit(); // create an instance of Form2
            selectUnit.Show();
            this.Hide();
        }

        private void text_box_username_TextChanged(object sender, EventArgs e)
        {
            btn_login.Enabled = !string.IsNullOrEmpty(txt_box_username.Text) &&
                !string.IsNullOrEmpty(txt_box_pass.Text);
        }

        private void txt_box_pass_TextChanged(object sender, EventArgs e)
        {
            btn_login.Enabled = !string.IsNullOrEmpty(txt_box_username.Text) &&
              !string.IsNullOrEmpty(txt_box_pass.Text);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_desc_Click_1(object sender, EventArgs e)
        {

        }
    }
}
