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

namespace GoldwareSupervisorPanel2025.Pages.Main
{
    public partial class SetSettingStep1 : UserControl
    {

        private readonly ICommonService _commonService;
        public event Action? OnNext;

        public SetSettingStep1(ICommonService commonService)
        {
            InitializeComponent();
            _commonService = commonService;

            txt_production_date.Enter += txt_production_date_Enter;
            txt_production_date.Leave += txt_production_date_Leave;
            txt_production_date.MouseEnter += txt_production_date_MouseEnter;
            txt_production_date.MouseLeave += txt_production_date_MouseLeave;
        }




        private void btn_next_Click(object sender, EventArgs e)
        {
            OnNext?.Invoke();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txt_production_date_Enter(object sender, EventArgs e)
        {
            txt_production_date.IconRight = _commonService.TintIcon(txt_production_date.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_production_date_Leave(object sender, EventArgs e)
        {
            txt_production_date.IconRight = _commonService.TintIcon(txt_production_date.IconRight, Color.FromArgb(150, 150, 150));
        }
        private void txt_production_date_MouseEnter(object sender, EventArgs e)
        {
            txt_production_date.IconRight = _commonService.TintIcon(txt_production_date.IconRight, Color.FromArgb(255, 149, 0));
        }
        private void txt_production_date_MouseLeave(object sender, EventArgs e)
        {
            if (!txt_production_date.Focused)
            {
                txt_production_date.IconRight = _commonService.TintIcon(txt_production_date.IconRight, Color.FromArgb(150, 150, 150));
            }
        }

        private void ctrl_min_Click(object sender, EventArgs e)
        {

        }

        private void ctrl_max_Click(object sender, EventArgs e)
        {

        }

        private void SetSettingStep1_Load(object sender, EventArgs e)
        {

        }

        private void txt_production_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
