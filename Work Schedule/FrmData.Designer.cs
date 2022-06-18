namespace Job_Scheduling
{
    partial class FrmData
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJobDetails = new System.Windows.Forms.Label();
            this.txtJobDetails = new System.Windows.Forms.TextBox();
            this.lblFinancialDetails = new System.Windows.Forms.Label();
            this.txtFinancialDetails = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(38, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(652, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(384, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do cliente, empresa, organização ou remetente:";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 16F);
            this.btnReturn.Location = new System.Drawing.Point(37, 603);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 80);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Retornar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 16F);
            this.btnUpdate.Location = new System.Drawing.Point(335, 603);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 80);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F);
            this.btnAdd.Location = new System.Drawing.Point(491, 603);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 80);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblJob
            // 
            this.lblJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(35, 158);
            this.lblJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(279, 18);
            this.lblJob.TabIndex = 7;
            this.lblJob.Text = "Trabalho ou projeto a ser desenvolvido:";
            // 
            // txtJob
            // 
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(38, 179);
            this.txtJob.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(652, 26);
            this.txtJob.TabIndex = 6;
            // 
            // lblJobDetails
            // 
            this.lblJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobDetails.AutoSize = true;
            this.lblJobDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDetails.Location = new System.Drawing.Point(35, 224);
            this.lblJobDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJobDetails.Name = "lblJobDetails";
            this.lblJobDetails.Size = new System.Drawing.Size(229, 18);
            this.lblJobDetails.TabIndex = 9;
            this.lblJobDetails.Text = "Detalhes do trabalho ou projeto:";
            // 
            // txtJobDetails
            // 
            this.txtJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDetails.Location = new System.Drawing.Point(38, 245);
            this.txtJobDetails.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtJobDetails.Name = "txtJobDetails";
            this.txtJobDetails.Size = new System.Drawing.Size(652, 26);
            this.txtJobDetails.TabIndex = 8;
            this.txtJobDetails.Enter += new System.EventHandler(this.JobDetailsEnter);
            this.txtJobDetails.Leave += new System.EventHandler(this.JobDetailsLeave);
            // 
            // lblFinancialDetails
            // 
            this.lblFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinancialDetails.AutoSize = true;
            this.lblFinancialDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialDetails.Location = new System.Drawing.Point(35, 289);
            this.lblFinancialDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinancialDetails.Name = "lblFinancialDetails";
            this.lblFinancialDetails.Size = new System.Drawing.Size(154, 18);
            this.lblFinancialDetails.TabIndex = 11;
            this.lblFinancialDetails.Text = "Detalhes financeiros:";
            // 
            // txtFinancialDetails
            // 
            this.txtFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinancialDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinancialDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinancialDetails.Location = new System.Drawing.Point(38, 310);
            this.txtFinancialDetails.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtFinancialDetails.Name = "txtFinancialDetails";
            this.txtFinancialDetails.Size = new System.Drawing.Size(652, 26);
            this.txtFinancialDetails.TabIndex = 10;
            this.txtFinancialDetails.Enter += new System.EventHandler(this.FinancialDetailsEnter);
            this.txtFinancialDetails.Leave += new System.EventHandler(this.FinancialDetailsLeave);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(35, 485);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(139, 18);
            this.lblPeriod.TabIndex = 15;
            this.lblPeriod.Text = "Período do evento:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(652, 35);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "FORMULÁRIO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(35, 419);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(181, 18);
            this.lblDeadline.TabIndex = 19;
            this.lblDeadline.Text = "Data de entrega e prazo:";
            // 
            // lblCreated
            // 
            this.lblCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(35, 354);
            this.lblCreated.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(240, 18);
            this.lblCreated.TabIndex = 22;
            this.lblCreated.Text = "Data de solicitação ou do evento:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 550);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 18);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Estado atual:";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine.Location = new System.Drawing.Point(38, 61);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(652, 1);
            this.lblLine.TabIndex = 28;
            // 
            // txtCreated
            // 
            this.txtCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreated.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreated.Location = new System.Drawing.Point(38, 375);
            this.txtCreated.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(652, 26);
            this.txtCreated.TabIndex = 29;
            this.txtCreated.Enter += new System.EventHandler(this.CreatedEnter);
            this.txtCreated.Leave += new System.EventHandler(this.CreatedLeave);
            // 
            // txtDeadline
            // 
            this.txtDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeadline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeadline.Location = new System.Drawing.Point(38, 441);
            this.txtDeadline.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(652, 26);
            this.txtDeadline.TabIndex = 30;
            this.txtDeadline.Enter += new System.EventHandler(this.DeadlineEnter);
            this.txtDeadline.Leave += new System.EventHandler(this.DeadlineLeave);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.Location = new System.Drawing.Point(38, 506);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(652, 26);
            this.txtPeriod.TabIndex = 31;
            this.txtPeriod.Enter += new System.EventHandler(this.PeriodEnter);
            this.txtPeriod.Leave += new System.EventHandler(this.PeriodLeave);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(38, 571);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(652, 26);
            this.txtStatus.TabIndex = 32;
            this.txtStatus.Enter += new System.EventHandler(this.StatusEnter);
            this.txtStatus.Leave += new System.EventHandler(this.StatusLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 16F);
            this.btnDelete.Location = new System.Drawing.Point(181, 603);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 80);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 714);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.txtCreated);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblFinancialDetails);
            this.Controls.Add(this.txtFinancialDetails);
            this.Controls.Add(this.lblJobDetails);
            this.Controls.Add(this.txtJobDetails);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "FrmData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Schedule";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJobDetails;
        private System.Windows.Forms.TextBox txtJobDetails;
        private System.Windows.Forms.Label lblFinancialDetails;
        private System.Windows.Forms.TextBox txtFinancialDetails;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnDelete;
    }
}

