namespace Job_Scheduling
{
    partial class FrmQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuery));
            this.dgvWorks = new System.Windows.Forms.DataGridView();
            this.Column_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_08 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSelectedWork = new System.Windows.Forms.TextBox();
            this.lblSelectedWork = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorks
            // 
            this.dgvWorks.AllowUserToAddRows = false;
            this.dgvWorks.AllowUserToDeleteRows = false;
            this.dgvWorks.AllowUserToResizeColumns = false;
            this.dgvWorks.AllowUserToResizeRows = false;
            this.dgvWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvWorks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWorks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvWorks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorks.ColumnHeadersHeight = 50;
            this.dgvWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_00,
            this.Column_01,
            this.Column_02,
            this.Column_05,
            this.Column_06,
            this.Column_08});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvWorks.EnableHeadersVisualStyles = false;
            this.dgvWorks.Location = new System.Drawing.Point(21, 21);
            this.dgvWorks.MultiSelect = false;
            this.dgvWorks.Name = "dgvWorks";
            this.dgvWorks.ReadOnly = true;
            this.dgvWorks.RowHeadersVisible = false;
            this.dgvWorks.RowHeadersWidth = 50;
            this.dgvWorks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWorks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorks.Size = new System.Drawing.Size(881, 447);
            this.dgvWorks.TabIndex = 0;
            this.dgvWorks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWorks_CellClick);
            // 
            // Column_00
            // 
            this.Column_00.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_00.HeaderText = "Identificador";
            this.Column_00.Name = "Column_00";
            this.Column_00.ReadOnly = true;
            this.Column_00.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_00.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_00.Visible = false;
            // 
            // Column_01
            // 
            this.Column_01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_01.HeaderText = "Nome";
            this.Column_01.Name = "Column_01";
            this.Column_01.ReadOnly = true;
            this.Column_01.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_02
            // 
            this.Column_02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_02.HeaderText = "Trabalho";
            this.Column_02.Name = "Column_02";
            this.Column_02.ReadOnly = true;
            this.Column_02.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_05
            // 
            this.Column_05.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_05.HeaderText = "Data";
            this.Column_05.Name = "Column_05";
            this.Column_05.ReadOnly = true;
            this.Column_05.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_05.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_06
            // 
            this.Column_06.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_06.HeaderText = "Prazo";
            this.Column_06.Name = "Column_06";
            this.Column_06.ReadOnly = true;
            this.Column_06.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_06.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_08
            // 
            this.Column_08.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_08.HeaderText = "Estado atual";
            this.Column_08.Name = "Column_08";
            this.Column_08.ReadOnly = true;
            this.Column_08.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_08.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(21, 474);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(143, 81);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Retornar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchedule.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(748, 474);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(154, 81);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Agendar";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(578, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 81);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtSelectedWork
            // 
            this.txtSelectedWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedWork.Enabled = false;
            this.txtSelectedWork.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedWork.Location = new System.Drawing.Point(298, 526);
            this.txtSelectedWork.Name = "txtSelectedWork";
            this.txtSelectedWork.ReadOnly = true;
            this.txtSelectedWork.Size = new System.Drawing.Size(274, 29);
            this.txtSelectedWork.TabIndex = 4;
            this.txtSelectedWork.Text = "Nenhum.";
            // 
            // lblSelectedWork
            // 
            this.lblSelectedWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedWork.Font = new System.Drawing.Font("Arial", 16F);
            this.lblSelectedWork.Location = new System.Drawing.Point(293, 498);
            this.lblSelectedWork.Name = "lblSelectedWork";
            this.lblSelectedWork.Size = new System.Drawing.Size(224, 25);
            this.lblSelectedWork.TabIndex = 5;
            this.lblSelectedWork.Text = "Trabalho selecionado:";
            // 
            // FrmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(928, 578);
            this.Controls.Add(this.lblSelectedWork);
            this.Controls.Add(this.txtSelectedWork);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvWorks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorks;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSelectedWork;
        private System.Windows.Forms.Label lblSelectedWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_00;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_02;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_05;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_06;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_08;
    }
}