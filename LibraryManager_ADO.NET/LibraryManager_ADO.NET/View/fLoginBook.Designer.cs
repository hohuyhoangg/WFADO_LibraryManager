namespace LibraryManager_ADO.NET.View.Admin
{
    partial class fLoginBook
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
            this.pLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pPassword = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txbId = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pPassword.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.panel1);
            this.pLogin.Controls.Add(this.btnExit);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.pPassword);
            this.pLogin.Controls.Add(this.panelUsername);
            this.pLogin.Location = new System.Drawing.Point(8, 2);
            this.pLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(686, 522);
            this.pLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "NHẬP MÃ THÀNH VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(26, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 105);
            this.panel1.TabIndex = 3;
            // 
            // txbStatus
            // 
            this.txbStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbStatus.Location = new System.Drawing.Point(41, 50);
            this.txbStatus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(507, 36);
            this.txbStatus.TabIndex = 1;
            this.txbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình trạng tài khoản:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(371, 449);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 54);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(66, 449);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 54);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Xong";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pPassword
            // 
            this.pPassword.Controls.Add(this.txbDisplayName);
            this.pPassword.Controls.Add(this.labelPassword);
            this.pPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pPassword.Location = new System.Drawing.Point(26, 191);
            this.pPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(639, 105);
            this.pPassword.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbDisplayName.Location = new System.Drawing.Point(41, 50);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbDisplayName.Multiline = true;
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.ReadOnly = true;
            this.txbDisplayName.Size = new System.Drawing.Size(507, 36);
            this.txbDisplayName.TabIndex = 1;
            this.txbDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(33, 11);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 26);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Tên:";
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.txbId);
            this.panelUsername.Controls.Add(this.labelUsername);
            this.panelUsername.Location = new System.Drawing.Point(28, 88);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(638, 96);
            this.panelUsername.TabIndex = 0;
            // 
            // txbId
            // 
            this.txbId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbId.Location = new System.Drawing.Point(38, 54);
            this.txbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbId.Multiline = true;
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(507, 36);
            this.txbId.TabIndex = 1;
            this.txbId.TextChanged += new System.EventHandler(this.txbId_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(32, 16);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 26);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Mã:";
            // 
            // fLoginBook
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(696, 540);
            this.Controls.Add(this.pLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLoginBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬP MÃ THÀNH VIÊN";
            this.Load += new System.EventHandler(this.fLoginBook_Load);
            this.pLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPassword.ResumeLayout(false);
            this.pPassword.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
    }
}