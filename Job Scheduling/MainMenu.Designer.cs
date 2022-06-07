namespace Job_Scheduling
{
    partial class MainMenu
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
            this.dgvBloco_01 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.labJobDetails = new System.Windows.Forms.Label();
            this.txtJobDetails = new System.Windows.Forms.TextBox();
            this.labFinancialDetails = new System.Windows.Forms.Label();
            this.txtFinancialDetails = new System.Windows.Forms.TextBox();
            this.labPeriod = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.labDeadline = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.labCreated = new System.Windows.Forms.Label();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.Trabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloco_01)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBloco_01
            // 
            this.dgvBloco_01.AllowUserToAddRows = false;
            this.dgvBloco_01.AllowUserToDeleteRows = false;
            this.dgvBloco_01.AllowUserToResizeColumns = false;
            this.dgvBloco_01.AllowUserToResizeRows = false;
            this.dgvBloco_01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBloco_01.ColumnHeadersHeight = 40;
            this.dgvBloco_01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBloco_01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trabalho,
            this.Prazo,
            this.Status});
            this.dgvBloco_01.Location = new System.Drawing.Point(464, 22);
            this.dgvBloco_01.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvBloco_01.MultiSelect = false;
            this.dgvBloco_01.Name = "dgvBloco_01";
            this.dgvBloco_01.ReadOnly = true;
            this.dgvBloco_01.RowHeadersVisible = false;
            this.dgvBloco_01.Size = new System.Drawing.Size(436, 610);
            this.dgvBloco_01.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(27, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 23);
            this.txtName.TabIndex = 1;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(24, 91);
            this.labName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(415, 16);
            this.labName.TabIndex = 2;
            this.labName.Text = "Nome do cliente, empresa, organização ou remetente:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(27, 552);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 80);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(163, 552);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 80);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(309, 552);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 80);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Adicionar";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // labJob
            // 
            this.labJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labJob.AutoSize = true;
            this.labJob.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJob.Location = new System.Drawing.Point(24, 151);
            this.labJob.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labJob.Name = "labJob";
            this.labJob.Size = new System.Drawing.Size(319, 16);
            this.labJob.TabIndex = 7;
            this.labJob.Text = "Trabalho ou projeto a ser desenvolvido:";
            // 
            // txtJob
            // 
            this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJob.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(27, 170);
            this.txtJob.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(416, 23);
            this.txtJob.TabIndex = 6;
            // 
            // labJobDetails
            // 
            this.labJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labJobDetails.AutoSize = true;
            this.labJobDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJobDetails.Location = new System.Drawing.Point(24, 214);
            this.labJobDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labJobDetails.Name = "labJobDetails";
            this.labJobDetails.Size = new System.Drawing.Size(263, 16);
            this.labJobDetails.TabIndex = 9;
            this.labJobDetails.Text = "Detalhes do trabalho ou projeto:";
            // 
            // txtJobDetails
            // 
            this.txtJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJobDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDetails.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDetails.Location = new System.Drawing.Point(27, 233);
            this.txtJobDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtJobDetails.Name = "txtJobDetails";
            this.txtJobDetails.Size = new System.Drawing.Size(416, 23);
            this.txtJobDetails.TabIndex = 8;
            // 
            // labFinancialDetails
            // 
            this.labFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labFinancialDetails.AutoSize = true;
            this.labFinancialDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinancialDetails.Location = new System.Drawing.Point(24, 274);
            this.labFinancialDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFinancialDetails.Name = "labFinancialDetails";
            this.labFinancialDetails.Size = new System.Drawing.Size(175, 16);
            this.labFinancialDetails.TabIndex = 11;
            this.labFinancialDetails.Text = "Detalhes financeiros:";
            // 
            // txtFinancialDetails
            // 
            this.txtFinancialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFinancialDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinancialDetails.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinancialDetails.Location = new System.Drawing.Point(27, 293);
            this.txtFinancialDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFinancialDetails.Name = "txtFinancialDetails";
            this.txtFinancialDetails.Size = new System.Drawing.Size(416, 23);
            this.txtFinancialDetails.TabIndex = 10;
            // 
            // labPeriod
            // 
            this.labPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labPeriod.AutoSize = true;
            this.labPeriod.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeriod.Location = new System.Drawing.Point(24, 448);
            this.labPeriod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(151, 16);
            this.labPeriod.TabIndex = 15;
            this.labPeriod.Text = "Período do evento:";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(21, 29);
            this.labTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(238, 31);
            this.labTitle.TabIndex = 16;
            this.labTitle.Text = "Job Scheduling";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDeadline.CustomFormat = "dd/MMM/yyyy";
            this.dtpDeadline.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(27, 408);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(416, 23);
            this.dtpDeadline.TabIndex = 18;
            // 
            // labDeadline
            // 
            this.labDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labDeadline.AutoSize = true;
            this.labDeadline.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeadline.Location = new System.Drawing.Point(24, 389);
            this.labDeadline.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDeadline.Name = "labDeadline";
            this.labDeadline.Size = new System.Drawing.Size(199, 16);
            this.labDeadline.TabIndex = 19;
            this.labDeadline.Text = "Data de entrega e prazo:";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "Ambos os períodos (AM e PM).",
            "Entre meia-noite à meio-dia (AM).",
            "Entre meio-dia à meia-noite (PM).",
            "Nenhum período em específico."});
            this.cmbPeriod.Location = new System.Drawing.Point(27, 467);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(416, 24);
            this.cmbPeriod.TabIndex = 20;
            // 
            // labCreated
            // 
            this.labCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labCreated.AutoSize = true;
            this.labCreated.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCreated.Location = new System.Drawing.Point(24, 329);
            this.labCreated.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labCreated.Name = "labCreated";
            this.labCreated.Size = new System.Drawing.Size(271, 16);
            this.labCreated.TabIndex = 22;
            this.labCreated.Text = "Data de solicitação ou do evento:";
            // 
            // dtpCreated
            // 
            this.dtpCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCreated.CustomFormat = "dd/MMM/yyyy";
            this.dtpCreated.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreated.Location = new System.Drawing.Point(27, 348);
            this.dtpCreated.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(416, 23);
            this.dtpCreated.TabIndex = 21;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Agendado.",
            "Cancelado.",
            "Concluído.",
            "Em andamento."});
            this.cmbStatus.Location = new System.Drawing.Point(27, 522);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(416, 24);
            this.cmbStatus.TabIndex = 24;
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatus.Location = new System.Drawing.Point(24, 503);
            this.labStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(111, 16);
            this.labStatus.TabIndex = 23;
            this.labStatus.Text = "Estado atual:";
            // 
            // labLine
            // 
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labLine.Location = new System.Drawing.Point(27, 62);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(416, 1);
            this.labLine.TabIndex = 28;
            // 
            // Trabalho
            // 
            this.Trabalho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trabalho.HeaderText = "Trabalho";
            this.Trabalho.Name = "Trabalho";
            this.Trabalho.ReadOnly = true;
            this.Trabalho.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Trabalho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Prazo
            // 
            this.Prazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prazo.HeaderText = "Data de entrega";
            this.Prazo.Name = "Prazo";
            this.Prazo.ReadOnly = true;
            this.Prazo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prazo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Estado atual";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 655);
            this.Controls.Add(this.labLine);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labCreated);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.labDeadline);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.labFinancialDetails);
            this.Controls.Add(this.txtFinancialDetails);
            this.Controls.Add(this.labJobDetails);
            this.Controls.Add(this.txtJobDetails);
            this.Controls.Add(this.labJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvBloco_01);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Scheduling";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloco_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBloco_01;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label labJobDetails;
        private System.Windows.Forms.TextBox txtJobDetails;
        private System.Windows.Forms.Label labFinancialDetails;
        private System.Windows.Forms.TextBox txtFinancialDetails;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label labDeadline;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Label labCreated;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

