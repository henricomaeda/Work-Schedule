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
            this.labTitle = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.lblCreated = new System.Windows.Forms.Label();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(34, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(470, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 81);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(415, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do cliente, empresa, organização ou remetente:";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(34, 551);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 81);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 551);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 81);
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
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(300, 551);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 81);
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
            this.lblJob.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(31, 141);
            this.lblJob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(319, 16);
            this.lblJob.TabIndex = 7;
            this.lblJob.Text = "Trabalho ou projeto a ser desenvolvido:";
            // 
            // txtJob
            // 
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJob.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(34, 160);
            this.txtJob.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(470, 23);
            this.txtJob.TabIndex = 6;
            // 
            // lblJobDetails
            // 
            this.lblJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobDetails.AutoSize = true;
            this.lblJobDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDetails.Location = new System.Drawing.Point(31, 204);
            this.lblJobDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblJobDetails.Name = "lblJobDetails";
            this.lblJobDetails.Size = new System.Drawing.Size(263, 16);
            this.lblJobDetails.TabIndex = 9;
            this.lblJobDetails.Text = "Detalhes do trabalho ou projeto:";
            // 
            // txtJobDetails
            // 
            this.txtJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDetails.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDetails.Location = new System.Drawing.Point(34, 223);
            this.txtJobDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtJobDetails.Name = "txtJobDetails";
            this.txtJobDetails.Size = new System.Drawing.Size(470, 23);
            this.txtJobDetails.TabIndex = 8;
            this.txtJobDetails.Enter += new System.EventHandler(this.JobDetailsEnter);
            this.txtJobDetails.Leave += new System.EventHandler(this.JobDetailsLeave);
            // 
            // lblFinancialDetails
            // 
            this.lblFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinancialDetails.AutoSize = true;
            this.lblFinancialDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialDetails.Location = new System.Drawing.Point(31, 264);
            this.lblFinancialDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancialDetails.Name = "lblFinancialDetails";
            this.lblFinancialDetails.Size = new System.Drawing.Size(175, 16);
            this.lblFinancialDetails.TabIndex = 11;
            this.lblFinancialDetails.Text = "Detalhes financeiros:";
            // 
            // txtFinancialDetails
            // 
            this.txtFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinancialDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinancialDetails.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinancialDetails.Location = new System.Drawing.Point(34, 283);
            this.txtFinancialDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFinancialDetails.Name = "txtFinancialDetails";
            this.txtFinancialDetails.Size = new System.Drawing.Size(470, 23);
            this.txtFinancialDetails.TabIndex = 10;
            this.txtFinancialDetails.Enter += new System.EventHandler(this.FinancialDetailsEnter);
            this.txtFinancialDetails.Leave += new System.EventHandler(this.FinancialDetailsLeave);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(31, 438);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(151, 16);
            this.lblPeriod.TabIndex = 15;
            this.lblPeriod.Text = "Período do evento:";
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(34, 23);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(470, 31);
            this.labTitle.TabIndex = 16;
            this.labTitle.Text = "FORMULÁRIO";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeadline.CustomFormat = "dd/MMM/yyyy";
            this.dtpDeadline.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(34, 398);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(470, 23);
            this.dtpDeadline.TabIndex = 18;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(31, 379);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(199, 16);
            this.lblDeadline.TabIndex = 19;
            this.lblDeadline.Text = "Data de entrega e prazo:";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "Entre meia-noite à meio-dia.",
            "Entre meio-dia à meia-noite.",
            "Nenhum período em específico."});
            this.cmbPeriod.Location = new System.Drawing.Point(34, 457);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(470, 24);
            this.cmbPeriod.TabIndex = 20;
            // 
            // lblCreated
            // 
            this.lblCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(31, 319);
            this.lblCreated.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(271, 16);
            this.lblCreated.TabIndex = 22;
            this.lblCreated.Text = "Data de solicitação ou do evento:";
            // 
            // dtpCreated
            // 
            this.dtpCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreated.CustomFormat = "dd/MMM/yyyy";
            this.dtpCreated.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreated.Location = new System.Drawing.Point(34, 338);
            this.dtpCreated.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(470, 23);
            this.dtpCreated.TabIndex = 21;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Agendado.",
            "Cancelado.",
            "Concluído.",
            "Em andamento."});
            this.cmbStatus.Location = new System.Drawing.Point(34, 512);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(470, 24);
            this.cmbStatus.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(31, 493);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 16);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Estado atual:";
            // 
            // labLine
            // 
            this.labLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labLine.Location = new System.Drawing.Point(34, 54);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(470, 1);
            this.labLine.TabIndex = 28;
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 664);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblFinancialDetails);
            this.Controls.Add(this.txtFinancialDetails);
            this.Controls.Add(this.lblJobDetails);
            this.Controls.Add(this.txtJobDetails);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
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
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label labLine;
    }
}

