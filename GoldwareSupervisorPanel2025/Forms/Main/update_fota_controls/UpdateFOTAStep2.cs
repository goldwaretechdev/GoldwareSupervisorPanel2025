using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldwareSupervisorPanel2025.Forms.Main
{
    public partial class UpdateFOTAStep2 : UserControl
    {
        public event Action? OnNext;
        public event Action? OnBack;
        public UpdateFOTAStep2()
        {
            InitializeComponent();
        }

        private void UpdatFOTAStep2_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            OnNext?.Invoke();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
