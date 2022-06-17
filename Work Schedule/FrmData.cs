using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmData : Form
    {
        private string period = string.Empty;
        private int id = -1;

        public FrmData(int idRoute)
        {
            InitializeComponent();
            period = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);

            if (Data.Darkmode(false, true))
            {
                this.BackColor = Color.FromArgb(22, 27, 34);
                lblTitle.BackColor = Color.FromArgb(22, 27, 34);
                lblTitle.ForeColor = Color.FromArgb(240, 246, 252);
                lblName.BackColor = Color.FromArgb(22, 27, 34);
                lblName.ForeColor = Color.FromArgb(240, 246, 252);
                txtName.BackColor = Color.FromArgb(33, 38, 45);
                txtName.ForeColor = Color.FromArgb(201, 209, 217);
                lblJob.BackColor = Color.FromArgb(22, 27, 34);
                lblJob.ForeColor = Color.FromArgb(240, 246, 252);
                txtJob.BackColor = Color.FromArgb(33, 38, 45);
                txtJob.ForeColor = Color.FromArgb(201, 209, 217);
                lblJobDetails.BackColor = Color.FromArgb(22, 27, 34);
                lblJobDetails.ForeColor = Color.FromArgb(240, 246, 252);
                txtJobDetails.BackColor = Color.FromArgb(33, 38, 45);
                txtJobDetails.ForeColor = Color.FromArgb(201, 209, 217);
                lblFinancialDetails.BackColor = Color.FromArgb(22, 27, 34);
                lblFinancialDetails.ForeColor = Color.FromArgb(240, 246, 252);
                txtFinancialDetails.BackColor = Color.FromArgb(33, 38, 45);
                txtFinancialDetails.ForeColor = Color.FromArgb(201, 209, 217);
                lblCreated.BackColor = Color.FromArgb(22, 27, 34);
                lblCreated.ForeColor = Color.FromArgb(240, 246, 252);
                txtCreated.BackColor = Color.FromArgb(33, 38, 45);
                txtCreated.ForeColor = Color.FromArgb(201, 209, 217);
                lblDeadline.BackColor = Color.FromArgb(22, 27, 34);
                lblDeadline.ForeColor = Color.FromArgb(240, 246, 252);
                txtDeadline.BackColor = Color.FromArgb(33, 38, 45);
                txtDeadline.ForeColor = Color.FromArgb(201, 209, 217);
                lblPeriod.BackColor = Color.FromArgb(22, 27, 34);
                lblPeriod.ForeColor = Color.FromArgb(240, 246, 252);
                txtPeriod.BackColor = Color.FromArgb(33, 38, 45);
                txtPeriod.ForeColor = Color.FromArgb(201, 209, 217);
                lblStatus.BackColor = Color.FromArgb(22, 27, 34);
                lblStatus.ForeColor = Color.FromArgb(240, 246, 252);
                txtStatus.BackColor = Color.FromArgb(33, 38, 45);
                txtStatus.ForeColor = Color.FromArgb(201, 209, 217);
                btnAdd.BackColor = Color.FromArgb(33, 38, 45);
                btnAdd.ForeColor = Color.FromArgb(201, 209, 217);
                btnReturn.BackColor = Color.FromArgb(33, 38, 45);
                btnReturn.ForeColor = Color.FromArgb(201, 209, 217);
                btnUpdate.BackColor = Color.FromArgb(33, 38, 45);
                btnUpdate.ForeColor = Color.FromArgb(201, 209, 217);
            }

            if (idRoute >= 0)
            {
                id = idRoute;

                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;

                txtCreated.Text = Data.created[id];
                txtDeadline.Text = Data.deadline[id];
                txtFinancialDetails.Text = Data.financialDetails[id];
                txtJob.Text = Data.work[id];
                txtJobDetails.Text = Data.details[id];
                txtName.Text = Data.name[id];
                txtPeriod.Text = Data.period[id];
                txtStatus.Text = Data.status[id];
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (period == "AM") period = "Entre meia-noite a meio-dia";
            else period = "Entre meia-dia a meia-noite";

            CreatedLeave(sender, e);
            DeadlineLeave(sender, e);
            FinancialDetailsLeave(sender, e);
            JobDetailsLeave(sender, e);
            PeriodLeave(sender, e);
            StatusLeave(sender, e);
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
            string defaultError = "Por favor, preencha os campos necessários.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;

            if (string.IsNullOrWhiteSpace(txtName.Text)) MessageBox.Show(defaultError, "", buttons, icon);
            else if (string.IsNullOrWhiteSpace(txtJob.Text)) MessageBox.Show(defaultError, "", buttons, icon);
            else
            {
                Data.Update(id, txtName.Text, txtJob.Text, txtJobDetails.Text, txtFinancialDetails.Text, txtCreated.Text, txtDeadline.Text, txtPeriod.Text, txtStatus.Text);
                Data.Save();
                MessageBox.Show("O trabalho foi atualizado com sucesso!", "", buttons, MessageBoxIcon.Information);
                Clear();
            }
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
                Data.Add(txtName.Text, txtJob.Text, txtJobDetails.Text, txtFinancialDetails.Text, txtCreated.Text, txtDeadline.Text, txtPeriod.Text, txtStatus.Text);
                Data.Save();
                MessageBox.Show("O trabalho foi adicionado com sucesso!", "", buttons, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void Clear()
        {
            id = -1;

            txtCreated.Text = DateTime.Today.ToString("dd/MMMM/yyyy");
            txtDeadline.Text = DateTime.Today.AddDays(1).ToString("dd/MMMM/yyyy");
            txtFinancialDetails.Text = "Nenhum";
            txtJobDetails.Text = "Nenhum";
            txtJob.Text = "";
            txtName.Text = "";
            txtPeriod.Text = period;
            txtStatus.Text = "Agendado";

            txtCreated.ForeColor = Color.Gray;
            txtDeadline.ForeColor = Color.Gray;
            txtFinancialDetails.ForeColor = Color.Gray;
            txtJobDetails.ForeColor = Color.Gray;
            txtPeriod.ForeColor = Color.Gray;
            txtStatus.ForeColor = Color.Gray;

            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void TextBoxPlaceholder(TextBox textbox, bool placeholder = true)
        {
            if (placeholder)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    if (textbox == txtCreated) textbox.Text = DateTime.Today.ToString("dd/MMMM/yyyy");
                    else if (textbox == txtDeadline) textbox.Text = DateTime.Today.AddDays(1).ToString("dd/MMMM/yyyy");
                    else if (textbox == txtPeriod) textbox.Text = period;
                    else if (textbox == txtStatus) textbox.Text = "Agendado";
                    else textbox.Text = "Nenhum";
                    textbox.ForeColor = Color.Gray;
                }
            }
            else
            {
                if (textbox.ForeColor == Color.Gray)
                {
                    textbox.Text = "";
                    if (Data.Darkmode(false, true)) textbox.ForeColor = Color.FromArgb(240, 246, 252);
                    else textbox.ForeColor = Color.Black;
                }
            }
        }

        private void CreatedEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtCreated, false);
        }

        private void CreatedLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtCreated);
        }

        private void DeadlineEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtDeadline, false);
        }

        private void DeadlineLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtDeadline);
        }

        private void FinancialDetailsEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtFinancialDetails, false);
        }

        private void FinancialDetailsLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtFinancialDetails);
        }

        private void JobDetailsEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtJobDetails, false);
        }

        private void JobDetailsLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtJobDetails);
        }

        private void PeriodEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtPeriod, false);
        }

        private void PeriodLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtPeriod);
        }

        private void StatusEnter(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtStatus, false);
        }

        private void StatusLeave(object sender, EventArgs e)
        {
            TextBoxPlaceholder(txtStatus);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FrmMainMenu MainMenu = new FrmMainMenu();
            this.Hide();
            MainMenu.ShowDialog();
        }
    }
}
