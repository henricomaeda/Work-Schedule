using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            FrmQuery Query = new FrmQuery();
            this.Hide();
            Query.ShowDialog();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            FrmData data = new FrmData();
            this.Hide();
            data.ShowDialog();
        }
    }
}
