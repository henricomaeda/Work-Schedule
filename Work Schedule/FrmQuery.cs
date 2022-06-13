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
    public partial class FrmQuery : Form
    {
        private readonly int id = -1;

        public FrmQuery()
        {
            InitializeComponent();
            if (Data.Darkmode(false, true))
            {
                this.BackColor = Color.FromArgb(22, 27, 34);
                dgvWorks.BackgroundColor = Color.FromArgb(13, 17, 23);
                btnReturn.BackColor = Color.FromArgb(33, 38, 45);
                btnReturn.ForeColor = Color.FromArgb(201, 209, 217);
                lblSelectedWork.BackColor = Color.FromArgb(22, 27, 34);
                lblSelectedWork.ForeColor = Color.FromArgb(240, 246, 252);
                txtSelectedWork.BackColor = Color.FromArgb(33, 38, 45);
                txtSelectedWork.ForeColor = Color.FromArgb(201, 209, 217);
                btnUpdate.BackColor = Color.FromArgb(33, 38, 45);
                btnUpdate.ForeColor = Color.FromArgb(201, 209, 217);
                btnSchedule.BackColor = Color.FromArgb(33, 38, 45);
                btnSchedule.ForeColor = Color.FromArgb(201, 209, 217);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu mainMenu = new FrmMainMenu();
            this.Hide();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.ShowDialog();
        }

        private void UpdateWork(bool update = true)
        {
            FrmData data;

            if (update)
            {
                data = new FrmData(id);
            }
            else
            {
                data = new FrmData(-1);
            }

            this.Hide();
            data.Closed += (s, args) => this.Close();
            data.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWork();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            UpdateWork(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BtnReturn_Click(null, e);
        }
    }
}
