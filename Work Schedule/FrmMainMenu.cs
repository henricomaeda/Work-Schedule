using System;
using System.Drawing;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(22, 27, 34);

            lblTitle.BackColor = Color.FromArgb(22, 27, 34);
            lblTitle.ForeColor = Color.FromArgb(240, 246, 252);

            pnlMainMenu.BackColor = Color.FromArgb(13,17,23);

            btnLeave.BackColor = Color.FromArgb(33, 38, 45);
            btnLeave.ForeColor = Color.FromArgb(201, 209, 217);

            btnQuery.BackColor = Color.FromArgb(33, 38, 45);
            btnQuery.ForeColor = Color.FromArgb(201, 209, 217);

            btnSchedule.BackColor = Color.FromArgb(33, 38, 45);
            btnSchedule.ForeColor = Color.FromArgb(201, 209, 217);
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var message = "Você tem certeza que deseja finalizar?";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, "", buttons, icon);
            if (result == DialogResult.Yes) Application.ExitThread();
            else e.Cancel = true;
        }
    }
}
