using GoldwareSupervisorPanel2025.Models;
using GoldwareSupervisorPanel2025.Models.Enums;
using GoldwareSupervisorPanel2025.Properties.services;

namespace GoldwareSupervisorPanel2025.Forms.Main
{
    public partial class SetSettingStep1 : UserControl
    {

        private readonly ICommonService _commonService;
        private readonly ISettingsService _settingsService;
        public event Action? OnNext;

        public SetSettingStep1(ICommonService commonService,ISettingsService settingsService)
        {
            InitializeComponent();
            _commonService = commonService;
            _settingsService = settingsService;

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

        private async void SetSettingStep1_Load(object sender, EventArgs e)
        {
            //owners
            var response = await _settingsService.Owners();
            if (!response.Success)
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comb_owner.DataSource = response.Data;
            comb_owner.DisplayMember = "Text";
            comb_owner.ValueMember = "Value";

            comb_device_type.DataSource = Enum.GetValues(typeof(DeviceType))
           .Cast<DeviceType>()
           .Select(e => new SelectListItem
           {
               Value = Convert.ToInt32(e).ToString(),
               Text = e.ToString()
           })
           .ToList();
            comb_device_type.DisplayMember = "Text";
            comb_device_type.ValueMember = "Value";

            comb_category.DataSource = Enum.GetValues(typeof(ProductCategory))
           .Cast<ProductCategory>()
           .Select(e => new SelectListItem
           {
               Value = Convert.ToInt32(e).ToString(),
               Text = e.ToString()
           })
           .ToList();
            comb_category.DisplayMember = "Text";
            comb_category.ValueMember = "Value";
        }

        private void txt_production_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_serial_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_batch_number_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_batch_number.Checked)
            {
                txt_batch_number.Focus();
                btn_generate_batch.Enabled = true;
                btn_generate_serial.Enabled = false;
            }
        }

        private void rbtn_serial_number_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_serial_number.Checked)
            {
                txt_serial_number.Focus();
                btn_generate_batch.Enabled = false;
                btn_generate_serial.Enabled = true;
            }
        }

        private void btn_generate_batch_Click(object sender, EventArgs e)
        {
            txt_batch_number.Text = comb_owner.SelectedText + _commonService.GenerateShortUniqueCode(5);
        }

        private void btn_generate_serial_Click(object sender, EventArgs e)
        {
            txt_serial_number.Text = _commonService.GenerateShortUniqueCode(10);
        }
    }
}
