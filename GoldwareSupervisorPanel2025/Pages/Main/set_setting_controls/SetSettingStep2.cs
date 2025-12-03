using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Pages.Main
{
    public partial class SetSettingStep2 : UserControl
    {
        public event Action? OnBack;
        private readonly ICommonService _commonService;

        public SetSettingStep2(ICommonService common)
        {
            InitializeComponent();
            panel_software_version.BorderRadius = 20;
            _commonService = common;
        }

        private void SetSettingStep2_Load(object sender, EventArgs e)
        {

        }

        private void panel_software_version_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mac_address_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }
    }
}
