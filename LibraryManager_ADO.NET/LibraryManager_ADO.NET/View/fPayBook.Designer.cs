namespace LibraryManager_ADO.NET.View.Admin
{
    partial class fPayBook
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
            this.components = new System.ComponentModel.Container();
            this.panelName = new System.Windows.Forms.Panel();
            this.lbNameLibrary = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBookBorrow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBookId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbSex = new System.Windows.Forms.TextBox();
            this.dtpBrithday = new System.Windows.Forms.DateTimePicker();
            this.txbSsn = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.txbFIrstname = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelName.Controls.Add(this.lbNameLibrary);
            this.panelName.Location = new System.Drawing.Point(1, 1);
            this.panelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(1710, 69);
            this.panelName.TabIndex = 3;
            // 
            // lbNameLibrary
            // 
            this.lbNameLibrary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameLibrary.ForeColor = System.Drawing.Color.Yellow;
            this.lbNameLibrary.Location = new System.Drawing.Point(280, 20);
            this.lbNameLibrary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameLibrary.Name = "lbNameLibrary";
            this.lbNameLibrary.Size = new System.Drawing.Size(1068, 29);
            this.lbNameLibrary.TabIndex = 0;
            this.lbNameLibrary.Text = "THƯ VIỆN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HỒ CHÍ MINH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.dgvBookBorrow);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 472);
            this.panel2.TabIndex = 5;
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
            this.dgvBookBorrow.Location = new System.Drawing.Point(0, 50);
            this.dgvBookBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBookBorrow.Name = "dgvBookBorrow";
            this.dgvBookBorrow.RowHeadersVisible = false;
            this.dgvBookBorrow.RowHeadersWidth = 51;
            this.dgvBookBorrow.RowTemplate.Height = 24;
            this.dgvBookBorrow.Size = new System.Drawing.Size(1128, 420);
            this.dgvBookBorrow.TabIndex = 12;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "DANH SÁCH ĐÃ MƯỢN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbBookName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbBookId);
            this.panel1.Location = new System.Drawing.Point(1, 550);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 174);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "THÔNG TIN SÁCH";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.pay;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(1006, 79);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 80);
            this.btnPay.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnPay, "Trả sách");
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên sách:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(146, 130);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBookName.Multiline = true;
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(744, 33);
            this.txbBookName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã sách:";
            // 
            // txbBookId
            // 
            this.txbBookId.Location = new System.Drawing.Point(146, 74);
            this.txbBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBookId.Multiline = true;
            this.txbBookId.Name = "txbBookId";
            this.txbBookId.Size = new System.Drawing.Size(744, 33);
            this.txbBookId.TabIndex = 5;
            this.txbBookId.TextChanged += new System.EventHandler(this.txbBookId_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dtpRegisterDate);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txbAddress);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txbSex);
            this.panel3.Controls.Add(this.dtpBrithday);
            this.panel3.Controls.Add(this.txbSsn);
            this.panel3.Controls.Add(this.txbPhone);
            this.panel3.Controls.Add(this.txbEmail);
            this.panel3.Controls.Add(this.txbLastname);
            this.panel3.Controls.Add(this.txbFIrstname);
            this.panel3.Controls.Add(this.txbId);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(1131, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 649);
            this.panel3.TabIndex = 7;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dddd, dd - MM - yyyy";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(190, 574);
            this.dtpRegisterDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(337, 27);
            this.dtpRegisterDate.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 574);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 23);
            this.label15.TabIndex = 60;
            this.label15.Text = "Ngày đăng kí:";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(190, 416);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(337, 27);
            this.txbAddress.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 420);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 23);
            this.label14.TabIndex = 58;
            this.label14.Text = "Địa chỉ:";
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(190, 316);
            this.txbSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(337, 27);
            this.txbSex.TabIndex = 57;
            // 
            // dtpBrithday
            // 
            this.dtpBrithday.CustomFormat = "dddd, dd - MM - yyyy";
            this.dtpBrithday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBrithday.Location = new System.Drawing.Point(190, 262);
            this.dtpBrithday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBrithday.Name = "dtpBrithday";
            this.dtpBrithday.Size = new System.Drawing.Size(337, 27);
            this.dtpBrithday.TabIndex = 56;
            // 
            // txbSsn
            // 
            this.txbSsn.Location = new System.Drawing.Point(190, 370);
            this.txbSsn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSsn.Name = "txbSsn";
            this.txbSsn.Size = new System.Drawing.Size(337, 27);
            this.txbSsn.TabIndex = 55;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(190, 466);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(337, 27);
            this.txbPhone.TabIndex = 54;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(190, 516);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(337, 27);
            this.txbEmail.TabIndex = 53;
            // 
            // txbLastname
            // 
            this.txbLastname.Location = new System.Drawing.Point(190, 210);
            this.txbLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(337, 27);
            this.txbLastname.TabIndex = 52;
            // 
            // txbFIrstname
            // 
            this.txbFIrstname.Location = new System.Drawing.Point(190, 155);
            this.txbFIrstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFIrstname.Name = "txbFIrstname";
            this.txbFIrstname.Size = new System.Drawing.Size(337, 27);
            this.txbFIrstname.TabIndex = 51;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(190, 99);
            this.txbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(337, 27);
            this.txbId.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 23);
            this.label11.TabIndex = 49;
            this.label11.Text = "Họ, tên đêm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 520);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 48;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 466);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "SSN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ngày sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = "Mã:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(162, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(309, 32);
            this.label13.TabIndex = 20;
            this.label13.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // fPayBook
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1713, 724);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fPayBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRẢ SÁCH";
            this.Load += new System.EventHandler(this.fPayBook_Load);
            this.panelName.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label lbNameLibrary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBookId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbSex;
        private System.Windows.Forms.DateTimePicker dtpBrithday;
        private System.Windows.Forms.TextBox txbSsn;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBookBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txbFIrstname;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}