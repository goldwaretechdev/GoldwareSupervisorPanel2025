using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Pages.SetSettings
{ 
    public partial class GetSettingStep1 : UserControl
    {
        public event Action? OnNext;

        public GetSettingStep1()
        {
            InitializeComponent();
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            //todo check connection and items
            OnNext?.Invoke();
        }
    }
}
