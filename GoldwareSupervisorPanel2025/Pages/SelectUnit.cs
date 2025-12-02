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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoldwareSupervisorPanel2025.Pages
{
    public partial class SelectUnit : Form
    {
        private readonly ICommonService _commonService;
        public SelectUnit(ICommonService common)
        {
            InitializeComponent();
            _commonService = common;
            //todo get data
            comb_units.Items.Add("develop");
            comb_units.Items.Add("production");
            comb_units.SelectedIndexChanged += com_box_units_SelectedIndexChanged;
        }



        private void SelectUnit_Load(object sender, EventArgs e)
        {
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            //todo check
            SetSettings main = new(_commonService);
            main.Show();
            Hide();
        }

        private void com_box_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_units.SelectedIndex != -1)
                btn_enter.Enabled = true;
            else
                btn_enter.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
