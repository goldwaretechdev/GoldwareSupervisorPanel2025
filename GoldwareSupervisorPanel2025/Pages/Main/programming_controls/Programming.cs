using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Pages.Main.programming_controls
{
    public partial class Programming : UserControl
    {
        public Programming()
        {
            InitializeComponent();
        }

        private void lbl_HT_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtn_HT_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_HT.Checked) 
            txt_HT.Focus();           
        }
        private void rbtn_STM_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_STM.Checked) 
            txt_STM.Focus();           
        }
        private void rbtn_ESP_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_ESP.Checked) 
            txt_ESP.Focus();           
        }
    }
}
