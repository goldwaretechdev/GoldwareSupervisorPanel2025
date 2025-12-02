namespace GoldwareSupervisorPanel2025.Pages.controls
{
    partial class SetSettingStep2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ctrl_min = new Guna.UI2.WinForms.Guna2ControlBox();
            ctrl_max = new Guna.UI2.WinForms.Guna2ControlBox();
            btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            SuspendLayout();
            // 
            // ctrl_min
            // 
            ctrl_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrl_min.BackColor = Color.Transparent;
            ctrl_min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            ctrl_min.CustomizableEdges = customizableEdges1;
            ctrl_min.FillColor = Color.Transparent;
            ctrl_min.HoverState.FillColor = Color.FromArgb(213, 218, 223);
            ctrl_min.IconColor = Color.FromArgb(64, 64, 64);
            ctrl_min.Location = new Point(729, 3);
            ctrl_min.Name = "ctrl_min";
            ctrl_min.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ctrl_min.Size = new Size(45, 29);
            ctrl_min.TabIndex = 12;
            // 
            // ctrl_max
            // 
            ctrl_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrl_max.BackColor = Color.Transparent;
            ctrl_max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            ctrl_max.CustomizableEdges = customizableEdges3;
            ctrl_max.FillColor = Color.Transparent;
            ctrl_max.HoverState.FillColor = Color.FromArgb(213, 218, 223);
            ctrl_max.IconColor = Color.FromArgb(64, 64, 64);
            ctrl_max.Location = new Point(780, 3);
            ctrl_max.Name = "ctrl_max";
            ctrl_max.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ctrl_max.Size = new Size(45, 29);
            ctrl_max.TabIndex = 11;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.BackColor = Color.Transparent;
            btn_close.CustomizableEdges = customizableEdges5;
            btn_close.FillColor = Color.Transparent;
            btn_close.HoverState.FillColor = Color.FromArgb(213, 218, 223);
            btn_close.IconColor = Color.FromArgb(64, 64, 64);
            btn_close.Location = new Point(831, 3);
            btn_close.Name = "btn_close";
            btn_close.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_close.Size = new Size(45, 29);
            btn_close.TabIndex = 10;
            // 
            // SetSettingStep2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ctrl_min);
            Controls.Add(ctrl_max);
            Controls.Add(btn_close);
            Name = "SetSettingStep2";
            Size = new Size(880, 720);
            Load += SetSettingStep2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox ctrl_min;
        private Guna.UI2.WinForms.Guna2ControlBox ctrl_max;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
    }
}
