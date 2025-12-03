namespace GoldwareSupervisorPanel2025.Pages.Login.control
{
    partial class SelectUnitControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUnitControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            lbl_connection_status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            comb_units = new Guna.UI2.WinForms.Guna2ComboBox();
            btn_enter = new Guna.UI2.WinForms.Guna2Button();
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
            btn_close.TabIndex = 19;
            btn_close.Click += btn_close_Click;
            // 
            // lbl_connection_status
            // 
            lbl_connection_status.BackColor = Color.Transparent;
            lbl_connection_status.Font = new Font("Segoe UI", 10F);
            lbl_connection_status.ForeColor = Color.YellowGreen;
            lbl_connection_status.Location = new Point(28, 101);
            lbl_connection_status.Name = "lbl_connection_status";
            lbl_connection_status.Size = new Size(141, 19);
            lbl_connection_status.TabIndex = 25;
            lbl_connection_status.Text = "connected to server ✔";
            // 
            // lbl_desc
            // 
            lbl_desc.BackColor = Color.Transparent;
            lbl_desc.Font = new Font("Segoe UI", 10F);
            lbl_desc.Location = new Point(28, 76);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(91, 19);
            lbl_desc.TabIndex = 24;
            lbl_desc.Text = "select your unit";
            // 
            // lbl_title
            // 
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_title.Location = new Point(28, 47);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(113, 23);
            lbl_title.TabIndex = 23;
            lbl_title.Text = "Login to panel";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(187, 178);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(91, 89);
            guna2PictureBox1.TabIndex = 22;
            guna2PictureBox1.TabStop = false;
            // 
            // comb_units
            // 
            comb_units.Anchor = AnchorStyles.None;
            comb_units.BackColor = Color.Transparent;
            comb_units.BorderRadius = 10;
            comb_units.CustomizableEdges = customizableEdges5;
            comb_units.DrawMode = DrawMode.OwnerDrawFixed;
            comb_units.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_units.FocusedColor = Color.FromArgb(255, 149, 0);
            comb_units.FocusedState.BorderColor = Color.FromArgb(255, 149, 0);
            comb_units.Font = new Font("Segoe UI", 10F);
            comb_units.ForeColor = Color.Black;
            comb_units.HoverState.BorderColor = Color.FromArgb(255, 149, 0);
            comb_units.ItemHeight = 30;
            comb_units.Items.AddRange(new object[] { "select unit" });
            comb_units.Location = new Point(89, 273);
            comb_units.Name = "comb_units";
            comb_units.ShadowDecoration.CustomizableEdges = customizableEdges6;
            comb_units.Size = new Size(300, 36);
            comb_units.TabIndex = 21;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Transparent;
            btn_enter.BorderRadius = 10;
            btn_enter.CustomizableEdges = customizableEdges7;
            btn_enter.DisabledState.BorderColor = Color.FromArgb(206, 206, 206);
            btn_enter.DisabledState.CustomBorderColor = Color.FromArgb(206, 206, 206);
            btn_enter.DisabledState.FillColor = Color.FromArgb(206, 206, 206);
            btn_enter.DisabledState.ForeColor = Color.White;
            btn_enter.Enabled = false;
            btn_enter.FillColor = Color.FromArgb(255, 149, 0);
            btn_enter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_enter.ForeColor = Color.White;
            btn_enter.Location = new Point(89, 341);
            btn_enter.Name = "btn_enter";
            btn_enter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_enter.Size = new Size(300, 45);
            btn_enter.TabIndex = 20;
            btn_enter.Text = "Enter";
            btn_enter.UseTransparentBackground = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // SelectUnitControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_close);
            Controls.Add(lbl_connection_status);
            Controls.Add(lbl_desc);
            Controls.Add(lbl_title);
            Controls.Add(guna2PictureBox1);
            Controls.Add(comb_units);
            Controls.Add(btn_enter);
            Name = "SelectUnitControl";
            Size = new Size(480, 600);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_connection_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_desc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comb_units;
        private Guna.UI2.WinForms.Guna2Button btn_enter;
    }
}
