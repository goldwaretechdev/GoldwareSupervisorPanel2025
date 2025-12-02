using GoldwareSupervisorPanel2025.Pages.controls;
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

namespace GoldwareSupervisorPanel2025.Pages
{
    public partial class SetSettings : Form
    {
        private readonly ICommonService _commonService;
        public SetSettings(ICommonService commonService)
        {
            InitializeComponent();
            _commonService = commonService;
            LoadStep1();
        }
        private void LoadStep(UserControl step)
        {
            panel_load_steps.Controls.Clear();
            step.Dock = DockStyle.Fill;
            panel_load_steps.Controls.Add(step);
        }
        private void LoadStep1()
        {
            var step1 = new SetSettingStep1(_commonService);
            step1.OnNext += () => LoadStep2();
            LoadStep(step1);
        }

        private void LoadStep2()
        {
            var step2 = new SetSettingStep2();
            step2.OnBack += () => LoadStep1();
            LoadStep(step2);
        }

    }
}
