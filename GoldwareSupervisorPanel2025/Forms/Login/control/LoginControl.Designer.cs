namespace GoldwareSupervisorPanel2025.Forms.Login.loginControl
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lbl_forgot_pass = new LinkLabel();
            lbl_connection_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_box_username = new Guna.UI2.WinForms.Guna2TextBox();
            txt_box_pass = new Guna.UI2.WinForms.Guna2TextBox();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Transparent;
            btn_close.CustomizableEdges = customizableEdges1;
            btn_close.FillColor = Color.Transparent;
            btn_close.HoverState.FillColor = Color.FromArgb(213, 218, 223);
            btn_close.IconColor = Color.FromArgb(64, 64, 64);
            btn_close.Location = new Point(432, 3);
            btn_close.Name = "btn_close";
            btn_close.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_close.Size = new Size(45, 29);
            btn_close.TabIndex = 15;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(186, 196);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(91, 89);
            guna2PictureBox1.TabIndex = 23;
            guna2PictureBox1.TabStop = false;
            // 
            // lbl_forgot_pass
            // 
            lbl_forgot_pass.ActiveLinkColor = Color.FromArgb(255, 149, 0);
            lbl_forgot_pass.AutoSize = true;
            lbl_forgot_pass.Cursor = Cursors.Hand;
            lbl_forgot_pass.Font = new Font("Segoe UI", 8F);
            lbl_forgot_pass.LinkColor = Color.Black;
            lbl_forgot_pass.Location = new Point(285, 475);
            lbl_forgot_pass.Name = "lbl_forgot_pass";
            lbl_forgot_pass.Size = new Size(100, 13);
            lbl_forgot_pass.TabIndex = 22;
            lbl_forgot_pass.TabStop = true;
            lbl_forgot_pass.Text = "Forgot password?";
            lbl_forgot_pass.VisitedLinkColor = Color.FromArgb(255, 149, 0);
            // 
            // lbl_connection_status
            // 
            lbl_connection_status.BackColor = Color.Transparent;
            lbl_connection_status.Font = new Font("Segoe UI", 10F);
            lbl_connection_status.ForeColor = Color.YellowGreen;
            lbl_connection_status.Location = new Point(28, 101);
            lbl_connection_status.Name = "lbl_connection_status";
            lbl_connection_status.Size = new Size(141, 19);
            lbl_connection_status.TabIndex = 21;
            lbl_connection_status.Text = "connected to server ✔";
            // 
            // lbl_desc
            // 
            lbl_desc.BackColor = Color.Transparent;
            lbl_desc.Font = new Font("Segoe UI", 10F);
            lbl_desc.Location = new Point(28, 76);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(223, 19);
            lbl_desc.TabIndex = 20;
            lbl_desc.Text = "please enter username and password";
            // 
            // lbl_title
            // 
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_title.Location = new Point(28, 47);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(113, 23);
            lbl_title.TabIndex = 19;
            lbl_title.Text = "Login to panel";
            // 
            // txt_box_username
            // 
            txt_box_username.BorderRadius = 10;
            txt_box_username.CustomizableEdges = customizableEdges5;
            txt_box_username.DefaultText = "";
            txt_box_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_box_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_box_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_box_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_box_username.FocusedState.BorderColor = Color.FromArgb(255, 149, 0);
            txt_box_username.Font = new Font("Segoe UI", 9F);
            txt_box_username.HoverState.BorderColor = Color.FromArgb(255, 149, 0);
            txt_box_username.IconRight = (Image)resources.GetObject("txt_box_username.IconRight");
            txt_box_username.Location = new Point(85, 294);
            txt_box_username.Name = "txt_box_username";
            txt_box_username.PlaceholderText = "username";
            txt_box_username.SelectedText = "";
            txt_box_username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_box_username.Size = new Size(300, 40);
            txt_box_username.TabIndex = 16;
            txt_box_username.TextChanged += txt_box_username_TextChanged;
            // 
            // txt_box_pass
            // 
            txt_box_pass.BorderRadius = 10;
            txt_box_pass.CustomizableEdges = customizableEdges7;
            txt_box_pass.DefaultText = "";
            txt_box_pass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_box_pass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_box_pass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_box_pass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_box_pass.FocusedState.BorderColor = Color.FromArgb(255, 149, 0);
            txt_box_pass.Font = new Font("Segoe UI", 9F);
            txt_box_pass.HoverState.BorderColor = Color.FromArgb(255, 149, 0);
            txt_box_pass.IconRight = (Image)resources.GetObject("txt_box_pass.IconRight");
            txt_box_pass.Location = new Point(85, 349);
            txt_box_pass.Name = "txt_box_pass";
            txt_box_pass.PlaceholderText = "password";
            txt_box_pass.SelectedText = "";
            txt_box_pass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_box_pass.Size = new Size(300, 40);
            txt_box_pass.TabIndex = 17;
            txt_box_pass.TextChanged += txt_box_pass_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BorderRadius = 10;
            btn_login.CustomizableEdges = customizableEdges9;
            btn_login.DisabledState.BorderColor = Color.FromArgb(206, 206, 206);
            btn_login.DisabledState.CustomBorderColor = Color.FromArgb(206, 206, 206);
            btn_login.DisabledState.FillColor = Color.FromArgb(206, 206, 206);
            btn_login.DisabledState.ForeColor = Color.White;
            btn_login.Enabled = false;
            btn_login.FillColor = Color.FromArgb(255, 149, 0);
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(85, 424);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_login.Size = new Size(300, 45);
            btn_login.TabIndex = 18;
            btn_login.Text = "Login";
            btn_login.UseTransparentBackground = true;
            btn_login.Click += btn_login_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_close);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lbl_forgot_pass);
            Controls.Add(lbl_connection_status);
            Controls.Add(lbl_desc);
            Controls.Add(lbl_title);
            Controls.Add(txt_box_username);
            Controls.Add(txt_box_pass);
            Controls.Add(btn_login);
            Name = "LoginControl";
            Size = new Size(480, 600);
            Load += LoginControl_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private LinkLabel lbl_forgot_pass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_connection_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_desc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Guna.UI2.WinForms.Guna2TextBox txt_box_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_box_pass;
        private Guna.UI2.WinForms.Guna2Button btn_login;
    }
}
