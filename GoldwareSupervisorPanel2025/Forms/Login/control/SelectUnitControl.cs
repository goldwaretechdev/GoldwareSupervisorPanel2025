using GoldwareSupervisorPanel2025.Forms.Main;
using GoldwareSupervisorPanel2025.Models;
using GoldwareSupervisorPanel2025.Properties.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Forms.Login.control
{
    public partial class SelectUnitControl : UserControl
    {
        private readonly ICommonService _commonService;
        private readonly IUserService _userService;
        private readonly LoginInfo info = new();

        public SelectUnitControl(ICommonService common,IUserService userService,List<RoleDto> roleList,LoginInfo loginInfo)
        {
            InitializeComponent();
            _commonService = common;
            _userService = userService;
            comb_units.DataSource= roleList;
            comb_units.DisplayMember = "Name";
            comb_units.ValueMember = "Id";
            
            info=loginInfo;
            comb_units.SelectedIndexChanged += com_box_units_SelectedIndexChanged;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void com_box_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_units.SelectedIndex != -1)
                btn_enter.Enabled = true;
            else
                btn_enter.Enabled = false;
        }

        private async void btn_enter_Click(object sender, EventArgs e)
        {
            var selected = (RoleDto)comb_units.SelectedItem;
            info.Role = selected.Id;
            var response =await _userService.Token(info);
            if (!response.Success)
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var token = response.Data;
            MainForm main = new(_commonService);
            main.Show();
            ParentForm.Hide();
        }

        private void SelectUnitControl_Load(object sender, EventArgs e)
        {

        }
    }
}
