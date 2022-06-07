using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class MainMenu : Form
    {
        readonly string period = string.Empty;

        public MainMenu()
        {
            InitializeComponent();
            period = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            dtpCreated.Value = DateTime.Now;
            dtpDeadline.Value = DateTime.Now.AddDays(1);

            if (period == "AM") cmbPeriod.SelectedIndex = 1;
            else if (period == "PM") cmbPeriod.SelectedIndex = 2;
            else cmbPeriod.SelectedIndex = 3;

            cmbStatus.SelectedIndex = 0;
        }
    }
}
