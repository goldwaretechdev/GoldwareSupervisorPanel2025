

using GoldwareSupervisorPanel2025.Forms.Main.programming_controls;
using GoldwareSupervisorPanel2025.Properties.services;
using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace GoldwareSupervisorPanel2025.Forms.Main
{
    public partial class MainForm : Form
    {
        private readonly ICommonService _commonService;
        private readonly ISettingsService _settingsService;
        private readonly IServiceProvider _provider;
        private SetSettingStep1 _setSettingStep1;
        private SetSettingStep2 _setSettingStep2;
        private GetSettingStep1 _getSettingStep1;
        private GetSettingStep2 _getSettingStep2;
        private UpdateFOTAStep1 _updateFOTAStep1;
        private UpdateFOTAStep2 _updateFOTAStep2;
        private UpdateFOTAStep3 _updateFOTAStep3;
        private Programming _programming;
        public MainForm(ICommonService commonService,ISettingsService settingsService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _commonService = commonService;
            _settingsService = settingsService;
            _provider= serviceProvider;
            _setSettingStep1 = _provider.GetRequiredService<SetSettingStep1>();
            _setSettingStep2 = _provider.GetRequiredService<SetSettingStep2>(); ;
            _getSettingStep1 = _provider.GetRequiredService<GetSettingStep1>(); ;
            _getSettingStep2 = new();
            _updateFOTAStep1 = new(_commonService);
            _updateFOTAStep2 = new();
            _updateFOTAStep3 = new();
            _programming = new();
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
            _updateFOTAStep1.OnNext += () => LoadUpdateFOTAStep2();
            _updateFOTAStep2.OnNext += () => LoadUpdateFOTAStep3();
            _updateFOTAStep2.OnBack += () => LoadUpdateFOTAStep1();
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
        
        private void LoadUpdateFOTAStep1()
        {
            LoadStep(_updateFOTAStep1);
        }
         
        private void LoadUpdateFOTAStep2()
        {
            LoadStep(_updateFOTAStep2);
        }
         
        private void LoadUpdateFOTAStep3()
        {
            LoadStep(_updateFOTAStep3);
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
            LoadStep(_updateFOTAStep1);
            SelectMenuItem(btn_update_fota);
        }

        private void btn_programming_Click(object sender, EventArgs e)
        {
            LoadStep(_programming);
            SelectMenuItem(btn_programming);
        }
    }
}
