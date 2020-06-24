namespace LibraryManager_ADO.NET.View.Customer
{
    partial class fLibraryCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBookBorrow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label28 = new System.Windows.Forms.Label();
            this.btnFileExcelBook = new System.Windows.Forms.Button();
            this.tpBookBorrow = new System.Windows.Forms.TabPage();
            this.tcCustomer = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txbRetypePass = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBrithday = new System.Windows.Forms.DateTimePicker();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txbSsn = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.msInfo = new System.Windows.Forms.MenuStrip();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.lbNameLibrary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).BeginInit();
            this.tpBookBorrow.SuspendLayout();
            this.tcCustomer.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dgvBookBorrow);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnFileExcelBook);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 629);
            this.panel1.TabIndex = 3;
            // 
            // dgvBookBorrow
            // 
            this.dgvBookBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBookBorrow.Location = new System.Drawing.Point(3, 89);
            this.dgvBookBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookBorrow.Name = "dgvBookBorrow";
            this.dgvBookBorrow.RowHeadersVisible = false;
            this.dgvBookBorrow.RowHeadersWidth = 51;
            this.dgvBookBorrow.RowTemplate.Height = 24;
            this.dgvBookBorrow.Size = new System.Drawing.Size(1711, 536);
            this.dgvBookBorrow.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Title";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookCategory";
            this.Column3.HeaderText = "Thể loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Author";
            this.Column4.HeaderText = "Tác giả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Publisher";
            this.Column5.HeaderText = "Nhà xuât bản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "YearPublisher";
            this.Column6.HeaderText = "Năm xuất bản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            this.Column7.HeaderText = "Giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(585, 21);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(411, 32);
            this.label28.TabIndex = 41;
            this.label28.Text = "DANH SÁCH SÁCH ĐÃ MƯỢN";
            // 
            // btnFileExcelBook
            // 
            this.btnFileExcelBook.BackColor = System.Drawing.Color.White;
            this.btnFileExcelBook.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.EXCEL;
            this.btnFileExcelBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileExcelBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileExcelBook.Image = global::LibraryManager_ADO.NET.Properties.Resources.EXCEL;
            this.btnFileExcelBook.Location = new System.Drawing.Point(1635, 4);
            this.btnFileExcelBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnFileExcelBook.Name = "btnFileExcelBook";
            this.btnFileExcelBook.Size = new System.Drawing.Size(77, 77);
            this.btnFileExcelBook.TabIndex = 1;
            this.btnFileExcelBook.UseVisualStyleBackColor = false;
            // 
            // tpBookBorrow
            // 
            this.tpBookBorrow.Controls.Add(this.panel1);
            this.tpBookBorrow.Location = new System.Drawing.Point(4, 29);
            this.tpBookBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.tpBookBorrow.Name = "tpBookBorrow";
            this.tpBookBorrow.Padding = new System.Windows.Forms.Padding(4);
            this.tpBookBorrow.Size = new System.Drawing.Size(1719, 629);
            this.tpBookBorrow.TabIndex = 1;
            this.tpBookBorrow.Text = "Quản lí sách";
            this.tpBookBorrow.UseVisualStyleBackColor = true;
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tpBookBorrow);
            this.tcCustomer.Controls.Add(this.tpAccount);
            this.tcCustomer.Location = new System.Drawing.Point(-7, 65);
            this.tcCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(1727, 662);
            this.tcCustomer.TabIndex = 11;
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.Black;
            this.tpAccount.Controls.Add(this.panel10);
            this.tpAccount.Controls.Add(this.panel6);
            this.tpAccount.Location = new System.Drawing.Point(4, 29);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tpAccount.Size = new System.Drawing.Size(1719, 629);
            this.tpAccount.TabIndex = 5;
            this.tpAccount.Text = "Tài khoản";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.btnUpdatePass);
            this.panel10.Controls.Add(this.label39);
            this.panel10.Controls.Add(this.label38);
            this.panel10.Controls.Add(this.label37);
            this.panel10.Controls.Add(this.txbRetypePass);
            this.panel10.Controls.Add(this.txbPassword);
            this.panel10.Controls.Add(this.txbNewPass);
            this.panel10.Controls.Add(this.label27);
            this.panel10.Location = new System.Drawing.Point(1084, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(632, 630);
            this.panel10.TabIndex = 1;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BackColor = System.Drawing.Color.White;
            this.btnUpdatePass.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.changepass;
            this.btnUpdatePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdatePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.Location = new System.Drawing.Point(245, 413);
            this.btnUpdatePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(187, 71);
            this.btnUpdatePass.TabIndex = 62;
            this.btnUpdatePass.UseVisualStyleBackColor = false;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(157, 58);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(336, 35);
            this.label39.TabIndex = 62;
            this.label39.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(73, 302);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(169, 23);
            this.label38.TabIndex = 66;
            this.label38.Text = "Nhập lại mật khẩu:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(73, 115);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(122, 23);
            this.label37.TabIndex = 65;
            this.label37.Text = "Mật khẩu cũ:";
            // 
            // txbRetypePass
            // 
            this.txbRetypePass.Location = new System.Drawing.Point(78, 347);
            this.txbRetypePass.Margin = new System.Windows.Forms.Padding(4);
            this.txbRetypePass.Name = "txbRetypePass";
            this.txbRetypePass.Size = new System.Drawing.Size(447, 27);
            this.txbRetypePass.TabIndex = 64;
            this.txbRetypePass.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(78, 163);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(447, 27);
            this.txbPassword.TabIndex = 62;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(78, 257);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(447, 27);
            this.txbNewPass.TabIndex = 63;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(73, 217);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 23);
            this.label27.TabIndex = 61;
            this.label27.Text = "Mật khẩu mới:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dtpRegisterDate);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txbAddress);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.dtpBrithday);
            this.panel6.Controls.Add(this.cbxSex);
            this.panel6.Controls.Add(this.txbSsn);
            this.panel6.Controls.Add(this.txbPhoneNumber);
            this.panel6.Controls.Add(this.txbEmail);
            this.panel6.Controls.Add(this.txbLastName);
            this.panel6.Controls.Add(this.txbFirstname);
            this.panel6.Controls.Add(this.txbId);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label54);
            this.panel6.Controls.Add(this.label55);
            this.panel6.Controls.Add(this.label56);
            this.panel6.Controls.Add(this.btnChangeAvatar);
            this.panel6.Controls.Add(this.btnUpdateInfo);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1079, 630);
            this.panel6.TabIndex = 0;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dddd, yyyy - MM - dd";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(187, 480);
            this.dtpRegisterDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(421, 27);
            this.dtpRegisterDate.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "Ngày đăng kí:";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(187, 345);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(421, 27);
            this.txbAddress.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 104;
            this.label4.Text = "Địa chỉ:";
            // 
            // dtpBrithday
            // 
            this.dtpBrithday.CustomFormat = "dddd, yyyy - MM - dd";
            this.dtpBrithday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBrithday.Location = new System.Drawing.Point(187, 205);
            this.dtpBrithday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBrithday.Name = "dtpBrithday";
            this.dtpBrithday.Size = new System.Drawing.Size(421, 27);
            this.dtpBrithday.TabIndex = 103;
            this.dtpBrithday.Value = new System.DateTime(2020, 6, 11, 0, 0, 0, 0);
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbxSex.Location = new System.Drawing.Point(187, 250);
            this.cbxSex.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(186, 33);
            this.cbxSex.TabIndex = 102;
            // 
            // txbSsn
            // 
            this.txbSsn.Location = new System.Drawing.Point(187, 295);
            this.txbSsn.Margin = new System.Windows.Forms.Padding(4);
            this.txbSsn.Name = "txbSsn";
            this.txbSsn.Size = new System.Drawing.Size(421, 27);
            this.txbSsn.TabIndex = 101;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(187, 390);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(421, 27);
            this.txbPhoneNumber.TabIndex = 100;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(187, 435);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(421, 27);
            this.txbEmail.TabIndex = 99;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(187, 160);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(421, 27);
            this.txbLastName.TabIndex = 98;
            // 
            // txbFirstname
            // 
            this.txbFirstname.Location = new System.Drawing.Point(187, 115);
            this.txbFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(421, 27);
            this.txbFirstname.TabIndex = 97;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(187, 70);
            this.txbId.Margin = new System.Windows.Forms.Padding(4);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(421, 27);
            this.txbId.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 95;
            this.label5.Text = "Họ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 435);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 94;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 93;
            this.label9.Text = "Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 92;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 91;
            this.label7.Text = "SSN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 90;
            this.label6.Text = "Giới tính:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(33, 205);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(99, 23);
            this.label54.TabIndex = 89;
            this.label54.Text = "Ngày sinh:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(33, 70);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(45, 23);
            this.label55.TabIndex = 88;
            this.label55.Text = "Mã:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(301, 22);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(366, 37);
            this.label56.TabIndex = 87;
            this.label56.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BackColor = System.Drawing.Color.White;
            this.btnChangeAvatar.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.changeavar;
            this.btnChangeAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeAvatar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAvatar.Location = new System.Drawing.Point(850, 499);
            this.btnChangeAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(105, 96);
            this.btnChangeAvatar.TabIndex = 61;
            this.btnChangeAvatar.UseVisualStyleBackColor = false;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.White;
            this.btnUpdateInfo.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.update;
            this.btnUpdateInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(26, 541);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(99, 80);
            this.btnUpdateInfo.TabIndex = 59;
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.avartar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(748, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 300);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(777, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 35);
            this.label11.TabIndex = 57;
            this.label11.Text = "ẢNH ĐẠI DIỆN";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(164, 26);
            this.Logout.Text = "Đăng xuất";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // InfoUsername
            // 
            this.InfoUsername.BackColor = System.Drawing.Color.Transparent;
            this.InfoUsername.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout});
            this.InfoUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoUsername.Name = "InfoUsername";
            this.InfoUsername.Size = new System.Drawing.Size(160, 24);
            this.InfoUsername.Text = "Thông tin tài khoản";
            // 
            // msInfo
            // 
            this.msInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.msInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoUsername});
            this.msInfo.Location = new System.Drawing.Point(3, 0);
            this.msInfo.Name = "msInfo";
            this.msInfo.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.msInfo.Size = new System.Drawing.Size(173, 28);
            this.msInfo.TabIndex = 0;
            this.msInfo.Text = "menuStrip2";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelInfo.Controls.Add(this.msInfo);
            this.panelInfo.Location = new System.Drawing.Point(1241, -2);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(473, 69);
            this.panelInfo.TabIndex = 10;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelName.Controls.Add(this.lbNameLibrary);
            this.panelName.Location = new System.Drawing.Point(0, -2);
            this.panelName.Margin = new System.Windows.Forms.Padding(4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(1239, 69);
            this.panelName.TabIndex = 9;
            // 
            // lbNameLibrary
            // 
            this.lbNameLibrary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameLibrary.ForeColor = System.Drawing.Color.Yellow;
            this.lbNameLibrary.Location = new System.Drawing.Point(233, 22);
            this.lbNameLibrary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameLibrary.Name = "lbNameLibrary";
            this.lbNameLibrary.Size = new System.Drawing.Size(793, 29);
            this.lbNameLibrary.TabIndex = 0;
            this.lbNameLibrary.Text = "THƯ VIỆN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HỒ CHÍ MINH";
            // 
            // fLibraryCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1713, 724);
            this.Controls.Add(this.tcCustomer);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fLibraryCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẠN ĐỌC";
            this.Load += new System.EventHandler(this.fLibraryCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).EndInit();
            this.tpBookBorrow.ResumeLayout(false);
            this.tcCustomer.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msInfo.ResumeLayout(false);
            this.msInfo.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFileExcelBook;
        private System.Windows.Forms.TabPage tpBookBorrow;
        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txbRetypePass;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem InfoUsername;
        private System.Windows.Forms.MenuStrip msInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label lbNameLibrary;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvBookBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBrithday;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txbSsn;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button btnUpdateInfo;
    }
}