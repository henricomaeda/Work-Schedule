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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuery));
            this.dgvWorks = new System.Windows.Forms.DataGridView();
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
            this.dgvWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorks.Location = new System.Drawing.Point(21, 21);
            this.dgvWorks.MultiSelect = false;
            this.dgvWorks.Name = "dgvWorks";
            this.dgvWorks.ReadOnly = true;
            this.dgvWorks.Size = new System.Drawing.Size(881, 447);
            this.dgvWorks.TabIndex = 0;
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
    }
}