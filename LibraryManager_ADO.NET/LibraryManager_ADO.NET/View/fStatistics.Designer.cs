namespace LibraryManager_ADO.NET.View
{
    partial class fStatistics
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
            this.txbNUmber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdBook = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBookS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.txbNUmber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIdBook);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbBookName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 0;
            // 
            // txbNUmber
            // 
            this.txbNUmber.Location = new System.Drawing.Point(499, 59);
            this.txbNUmber.Margin = new System.Windows.Forms.Padding(4);
            this.txbNUmber.Multiline = true;
            this.txbNUmber.Name = "txbNUmber";
            this.txbNUmber.Size = new System.Drawing.Size(201, 33);
            this.txbNUmber.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Còn lại:";
            // 
            // txbCount
            // 
            this.txbCount.Location = new System.Drawing.Point(139, 59);
            this.txbCount.Margin = new System.Windows.Forms.Padding(4);
            this.txbCount.Multiline = true;
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(201, 33);
            this.txbCount.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số lượng:";
            // 
            // txbIdBook
            // 
            this.txbIdBook.Location = new System.Drawing.Point(139, 18);
            this.txbIdBook.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdBook.Multiline = true;
            this.txbIdBook.Name = "txbIdBook";
            this.txbIdBook.Size = new System.Drawing.Size(201, 33);
            this.txbIdBook.TabIndex = 17;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(9, 25);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 34);
            this.label41.TabIndex = 16;
            this.label41.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên sách:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(499, 18);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookName.Multiline = true;
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(478, 33);
            this.txbBookName.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.dgvBookS);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 460);
            this.panel2.TabIndex = 1;
            // 
            // dgvBookS
            // 
            this.dgvBookS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column28,
            this.Column1,
            this.Column2});
            this.dgvBookS.Location = new System.Drawing.Point(0, -3);
            this.dgvBookS.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookS.Name = "dgvBookS";
            this.dgvBookS.RowHeadersVisible = false;
            this.dgvBookS.RowHeadersWidth = 51;
            this.dgvBookS.RowTemplate.Height = 24;
            this.dgvBookS.Size = new System.Drawing.Size(1100, 463);
            this.dgvBookS.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã thành viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "Firstname";
            this.Column28.HeaderText = "Họ";
            this.Column28.MinimumWidth = 6;
            this.Column28.Name = "Column28";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Lastname";
            this.Column1.HeaderText = "Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BorrowDate";
            this.Column2.HeaderText = "Ngày mượn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // fStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.fStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdBook;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.TextBox txbNUmber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBookS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}