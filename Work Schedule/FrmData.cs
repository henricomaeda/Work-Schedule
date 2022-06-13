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
    public partial class FrmData : Form
    {
        private readonly string period = string.Empty;
        private readonly int id = -1;

        public FrmData(int idRoute)
        {
            InitializeComponent();

            if (idRoute >= 0)
            {
                id = idRoute;
            }

            period = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            JobDetailsLeave(sender, e);
            FinancialDetailsLeave(sender, e);

            dtpCreated.Value = DateTime.Now;
            dtpDeadline.Value = DateTime.Now.AddDays(1);

            if (period == "AM") cmbPeriod.SelectedIndex = 0;
            else if (period == "PM") cmbPeriod.SelectedIndex = 1;
            else cmbPeriod.SelectedIndex = 2;

            cmbStatus.SelectedIndex = 0;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu mainMenu = new FrmMainMenu();
            this.Hide();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string defaultError = "Por favor, preencha os campos necessários.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;

            if (string.IsNullOrWhiteSpace(txtName.Text)) MessageBox.Show(defaultError, "", buttons, icon);
            else if (string.IsNullOrWhiteSpace(txtJob.Text)) MessageBox.Show(defaultError, "", buttons, icon);
            else
            {
                try
                {

                }
                catch
                {

                }
                finally
                {

                }
            }
        }

        private void TextBoxPlaceholder(TextBox textbox, bool placeholder = true)
        {
            if (placeholder)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = "Nenhum.";
                    textbox.ForeColor = Color.Gray;
                }
            }
            else
            {
                if (textbox.Text == "Nenhum.")
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                }
            }
        }

        private void JobDetailsEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtJobDetails, false);
        }

        private void JobDetailsLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtJobDetails);
        }

        private void FinancialDetailsEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtFinancialDetails, false);
        }

        private void FinancialDetailsLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtFinancialDetails);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FrmMainMenu MainMenu = new FrmMainMenu();
            this.Hide();
            MainMenu.ShowDialog();
        }
    }
}
