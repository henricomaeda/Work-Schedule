using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmMainMenu : Form
    {
        private static bool load = false;

        public FrmMainMenu()
        {
            load = true;
            InitializeComponent();
            Theme(Data.Darkmode(false, true));
            Data.Load();

            Select();
        }

        private void Theme(bool darkmode)
        {
            string darkmode_theme = string.Empty;
            txtDarkmode.Text = darkmode_theme;

            if (darkmode)
            {
                this.BackColor = Color.FromArgb(22, 27, 34);
                btnDarkmode.BackColor = Color.FromArgb(33, 38, 45);
                btnDarkmode.ForeColor = Color.FromArgb(201, 209, 217);
                txtDarkmode.BackColor = Color.FromArgb(33, 38, 45);
                txtDarkmode.ForeColor = Color.FromArgb(201, 209, 217);
                pnlMainMenu.BackColor = Color.FromArgb(13, 17, 23);
                lblTitle.BackColor = Color.FromArgb(22, 27, 34);
                lblTitle.ForeColor = Color.FromArgb(240, 246, 252);
                btnLeave.BackColor = Color.FromArgb(33, 38, 45);
                btnLeave.ForeColor = Color.FromArgb(201, 209, 217);
                btnQuery.BackColor = Color.FromArgb(33, 38, 45);
                btnQuery.ForeColor = Color.FromArgb(201, 209, 217);
                btnSchedule.BackColor = Color.FromArgb(33, 38, 45);
                btnSchedule.ForeColor = Color.FromArgb(201, 209, 217);
                darkmode_theme = "Ativado.";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                btnDarkmode.BackColor = Color.WhiteSmoke;
                btnDarkmode.ForeColor = Color.Black;
                txtDarkmode.BackColor = Color.White;
                txtDarkmode.ForeColor = Color.Black;
                pnlMainMenu.BackColor = Color.Gainsboro;
                lblTitle.BackColor = Color.WhiteSmoke;
                lblTitle.ForeColor = Color.Black;
                btnLeave.BackColor = Color.White;
                btnLeave.ForeColor = Color.Black;
                btnQuery.BackColor = Color.White;
                btnQuery.ForeColor = Color.Black;
                btnSchedule.BackColor = Color.White;
                btnSchedule.ForeColor = Color.Black;
                darkmode_theme = "Desativado.";
            }

            if (!load)
            {
                Enabled = false;
                try
                {
                    Task.Run(() =>
                    {
                        char[] characters = darkmode_theme.ToCharArray();
                        for (int i = 0; i < darkmode_theme.Length; i++)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                txtDarkmode.Text += characters[i];
                            });
                            Thread.Sleep(20);
                        }
                        Invoke((MethodInvoker)delegate
                        {
                            Enabled = true;
                        });
                    });
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtDarkmode.Text = darkmode_theme;
                load = false;
            }
        }

        private void BtnDarkmode_Click(object sender, EventArgs e)
        {
            if (Data.Darkmode(false, true))
            {
                Data.Darkmode(false);
                Theme(false);
            }
            else
            {
                Data.Darkmode(true);
                Theme(true);
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            FrmQuery query = new FrmQuery();
            this.Hide();
            query.Closed += (s, args) => this.Close();
            query.ShowDialog();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            FrmData data = new FrmData(-1);
            this.Hide();
            data.Closed += (s, args) => this.Close();
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
