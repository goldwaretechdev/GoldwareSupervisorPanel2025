

using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;

namespace GoldwareSupervisorPanel2025.Pages.SetSettings
{
    public partial class SetSettingsForm : Form
    {
        private readonly ICommonService _commonService;
        private SetSettingStep1 _setSettingStep1;
        private SetSettingStep2 _setSettingStep2;
        private GetSettingStep1 _getSettingStep1;
        private GetSettingStep2 _getSettingStep2;
        public SetSettingsForm(ICommonService commonService)
        {
            InitializeComponent();
            _commonService = commonService;
            _setSettingStep1 = new SetSettingStep1(_commonService);
            _setSettingStep2 = new SetSettingStep2(_commonService);
            _getSettingStep1 = new GetSettingStep1();
            _getSettingStep2 = new GetSettingStep2();
            LoadSetSettingStep1();
        }
        private void LoadStep(UserControl step)
        {
            panel_load_steps.Controls.Clear();
            step.Dock = DockStyle.Fill;
            panel_load_steps.Controls.Add(step);
        }
        private void LoadSetSettingStep1()
        {
            _setSettingStep1.OnNext += () => LoadSetSettingStep2();
            _getSettingStep1.OnNext += () => LoadGetSettingStep2();
            LoadStep(_setSettingStep1);
        }

        private void LoadSetSettingStep2()
        {
            _setSettingStep2.OnBack += () => LoadSetSettingStep1();
            LoadStep(_setSettingStep2);
        }

        private void LoadGetSettingStep1()
        {
            LoadStep(_setSettingStep1);
        }

        private void LoadGetSettingStep2()
        {
            LoadStep(_getSettingStep2);
        }

        private void btn_set_settings_Click(object sender, EventArgs e)
        {
            LoadStep(_setSettingStep1);
            SelectMenuItem(btn_set_settings);

        }

        private void btn_get_settings_Click(object sender, EventArgs e)
        {
            LoadStep(_getSettingStep1);
            SelectMenuItem(btn_get_settings);
        }

        private void panel_load_steps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectMenuItem(Guna2Button btn)
        {
            btn_get_settings.FillColor = Color.FromArgb(67, 67, 67);
            btn_set_settings.FillColor = Color.FromArgb(67, 67, 67);
            btn_update_fota.FillColor = Color.FromArgb(67, 67, 67);
            btn_programming.FillColor = Color.FromArgb(67, 67, 67);

            btn.FillColor = Color.FromArgb(255, 149, 0);

        }

        private void btn_update_fota_Click(object sender, EventArgs e)
        {
            SelectMenuItem(btn_update_fota);
        }

        private void btn_programming_Click(object sender, EventArgs e)
        {
            SelectMenuItem(btn_programming);
        }
    }
}
