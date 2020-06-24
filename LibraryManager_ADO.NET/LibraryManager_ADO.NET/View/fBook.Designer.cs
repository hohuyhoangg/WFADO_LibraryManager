namespace LibraryManager_ADO.NET.View
{
    partial class fBook
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
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txbBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBookPublisher = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudBookCount = new System.Windows.Forms.NumericUpDown();
            this.txbBookYear = new System.Windows.Forms.TextBox();
            this.cbxBookCategory = new System.Windows.Forms.ComboBox();
            this.txbBookPrice = new System.Windows.Forms.TextBox();
            this.txbBookAuthor = new System.Windows.Forms.TextBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.btnResetTXBBook = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.Controls.Add(this.txbBookId);
            this.panelUsername.Controls.Add(this.label2);
            this.panelUsername.Controls.Add(this.cbbBookPublisher);
            this.panelUsername.Controls.Add(this.btnExit);
            this.panelUsername.Controls.Add(this.nudBookCount);
            this.panelUsername.Controls.Add(this.txbBookYear);
            this.panelUsername.Controls.Add(this.cbxBookCategory);
            this.panelUsername.Controls.Add(this.txbBookPrice);
            this.panelUsername.Controls.Add(this.txbBookAuthor);
            this.panelUsername.Controls.Add(this.txbBookName);
            this.panelUsername.Controls.Add(this.btnResetTXBBook);
            this.panelUsername.Controls.Add(this.btnSaveBook);
            this.panelUsername.Controls.Add(this.label11);
            this.panelUsername.Controls.Add(this.label10);
            this.panelUsername.Controls.Add(this.label9);
            this.panelUsername.Controls.Add(this.label8);
            this.panelUsername.Controls.Add(this.label6);
            this.panelUsername.Controls.Add(this.label5);
            this.panelUsername.Controls.Add(this.label4);
            this.panelUsername.Controls.Add(this.label1);
            this.panelUsername.Location = new System.Drawing.Point(5, 1);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(892, 769);
            this.panelUsername.TabIndex = 4;
            // 
            // txbBookId
            // 
            this.txbBookId.Location = new System.Drawing.Point(209, 165);
            this.txbBookId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbBookId.Name = "txbBookId";
            this.txbBookId.Size = new System.Drawing.Size(637, 30);
            this.txbBookId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã:";
            // 
            // cbbBookPublisher
            // 
            this.cbbBookPublisher.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBookPublisher.FormattingEnabled = true;
            this.cbbBookPublisher.Location = new System.Drawing.Point(212, 375);
            this.cbbBookPublisher.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbbBookPublisher.Name = "cbbBookPublisher";
            this.cbbBookPublisher.Size = new System.Drawing.Size(637, 27);
            this.cbbBookPublisher.TabIndex = 26;
            this.cbbBookPublisher.SelectedIndexChanged += new System.EventHandler(this.cbbBookPublisher_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(326, 662);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 80);
            this.btnExit.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnExit, "Hủy");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudBookCount
            // 
            this.nudBookCount.Location = new System.Drawing.Point(209, 590);
            this.nudBookCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nudBookCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBookCount.Name = "nudBookCount";
            this.nudBookCount.Size = new System.Drawing.Size(173, 30);
            this.nudBookCount.TabIndex = 24;
            // 
            // txbBookYear
            // 
            this.txbBookYear.Location = new System.Drawing.Point(212, 449);
            this.txbBookYear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbBookYear.Name = "txbBookYear";
            this.txbBookYear.Size = new System.Drawing.Size(637, 30);
            this.txbBookYear.TabIndex = 23;
            this.txbBookYear.Text = "1990";
            // 
            // cbxBookCategory
            // 
            this.cbxBookCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBookCategory.FormattingEnabled = true;
            this.cbxBookCategory.Location = new System.Drawing.Point(209, 94);
            this.cbxBookCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxBookCategory.Name = "cbxBookCategory";
            this.cbxBookCategory.Size = new System.Drawing.Size(637, 27);
            this.cbxBookCategory.TabIndex = 20;
            this.cbxBookCategory.SelectedIndexChanged += new System.EventHandler(this.cbxBookCategory_SelectedIndexChanged);
            // 
            // txbBookPrice
            // 
            this.txbBookPrice.Location = new System.Drawing.Point(212, 515);
            this.txbBookPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbBookPrice.Name = "txbBookPrice";
            this.txbBookPrice.Size = new System.Drawing.Size(637, 30);
            this.txbBookPrice.TabIndex = 15;
            this.txbBookPrice.Text = "0";
            // 
            // txbBookAuthor
            // 
            this.txbBookAuthor.Location = new System.Drawing.Point(212, 308);
            this.txbBookAuthor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbBookAuthor.Name = "txbBookAuthor";
            this.txbBookAuthor.Size = new System.Drawing.Size(637, 30);
            this.txbBookAuthor.TabIndex = 14;
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(212, 239);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(637, 30);
            this.txbBookName.TabIndex = 13;
            // 
            // btnResetTXBBook
            // 
            this.btnResetTXBBook.BackColor = System.Drawing.Color.White;
            this.btnResetTXBBook.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.empty;
            this.btnResetTXBBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetTXBBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTXBBook.Location = new System.Drawing.Point(189, 662);
            this.btnResetTXBBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnResetTXBBook.Name = "btnResetTXBBook";
            this.btnResetTXBBook.Size = new System.Drawing.Size(94, 80);
            this.btnResetTXBBook.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnResetTXBBook, "Nhập lại");
            this.btnResetTXBBook.UseVisualStyleBackColor = false;
            this.btnResetTXBBook.Click += new System.EventHandler(this.btnResetTXBBook_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.White;
            this.btnSaveBook.BackgroundImage = global::LibraryManager_ADO.NET.Properties.Resources.save;
            this.btnSaveBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBook.Location = new System.Drawing.Point(46, 662);
            this.btnSaveBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(94, 80);
            this.btnSaveBook.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSaveBook, "Lưu");
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 520);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Giá tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên tác giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 590);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhà xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Năm xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // fBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 768);
            this.Controls.Add(this.panelUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SÁCH";
            this.Load += new System.EventHandler(this.fBook_Load);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txbBookPrice;
        private System.Windows.Forms.TextBox txbBookAuthor;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Button btnResetTXBBook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudBookCount;
        private System.Windows.Forms.TextBox txbBookYear;
        private System.Windows.Forms.ComboBox cbxBookCategory;
        private System.Windows.Forms.ComboBox cbbBookPublisher;
        private System.Windows.Forms.TextBox txbBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}