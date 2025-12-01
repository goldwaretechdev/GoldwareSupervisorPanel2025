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
        public SelectUnit()
        {
            InitializeComponent();
            //todo get data
            com_box_units.Items.Add("develop");
            com_box_units.Items.Add("production");

            com_box_units.SelectedIndexChanged += com_box_units_SelectedIndexChanged;
        }



        private void SelectUnit_Load(object sender, EventArgs e)
        {
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            //todo check
            Main main = new();
            main.Show();
            this.Hide();
        }

        private void com_box_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(com_box_units.SelectedIndex!=-1)
                btn_enter.Enabled = true;
            else
                btn_enter.Enabled = false;
        }
    }
}
