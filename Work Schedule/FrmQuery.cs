﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Job_Scheduling
{
    public partial class FrmQuery : Form
    {
        private int id = -1;

        public FrmQuery()
        {
            InitializeComponent();

            if (Data.Darkmode(false, true))
            {
                BackColor = Color.FromArgb(22, 27, 34);
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

                dgvWorks.BackgroundColor = Color.FromArgb(13, 17, 23);
                dgvWorks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 27, 34);
                dgvWorks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 27, 34);
                dgvWorks.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(240, 246, 252);
                dgvWorks.RowsDefaultCellStyle.BackColor = Color.FromArgb(33, 38, 45);
                dgvWorks.RowsDefaultCellStyle.ForeColor = Color.FromArgb(201, 209, 217);
            }
            else
            {
                dgvWorks.BackgroundColor = Color.Gainsboro;
                dgvWorks.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvWorks.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvWorks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvWorks.RowsDefaultCellStyle.BackColor = Color.White;
                dgvWorks.RowsDefaultCellStyle.ForeColor = Color.Black;
            }

            if (Data.id != null)
            {
                dgvWorks.Rows.Clear();

                for (int count = 0; count < Data.id.Length; count++)
                {
                    dgvWorks.Rows.Add(Data.id[count].ToString(), Data.name[count].ToString(), Data.work[count].ToString(), Data.created[count].ToString(), Data.deadline[count].ToString(), Data.status[count].ToString());
                }

                dgvWorks.ClearSelection();
            }

            Select();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainMenu mainMenu = new FrmMainMenu();
            Hide();
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

            Hide();
            data.Closed += (s, args) => Close();
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

        private void DgvWorks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvWorks.ClearSelection();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvWorks.Rows[e.RowIndex];
                txtSelectedWork.Text = row.Cells[1].Value.ToString();
                id = int.Parse(row.Cells[0].Value.ToString());
                btnUpdate.Enabled = true;
            }
        }
    }
}
