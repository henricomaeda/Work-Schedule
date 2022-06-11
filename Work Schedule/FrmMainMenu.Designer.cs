namespace Job_Scheduling
{
    partial class FrmMainMenu
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
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeave.Location = new System.Drawing.Point(21, 19);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(213, 178);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "Sair";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(252, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(213, 178);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Consultar";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Location = new System.Drawing.Point(482, 19);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(213, 178);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Agendar";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMainMenu.Controls.Add(this.picLogo);
            this.pnlMainMenu.Controls.Add(this.grpButtons);
            this.pnlMainMenu.Controls.Add(this.lblTitle);
            this.pnlMainMenu.Location = new System.Drawing.Point(21, 22);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(761, 464);
            this.pnlMainMenu.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.SystemColors.ControlText;
            this.picLogo.Location = new System.Drawing.Point(396, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(343, 203);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // grpButtons
            // 
            this.grpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpButtons.Controls.Add(this.btnSchedule);
            this.grpButtons.Controls.Add(this.btnQuery);
            this.grpButtons.Controls.Add(this.btnLeave);
            this.grpButtons.Location = new System.Drawing.Point(22, 239);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(717, 203);
            this.grpButtons.TabIndex = 1;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "groupBox2";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(23, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 203);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "WORK SCHEDULE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 506);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Schedule";
            this.pnlMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
    }
}