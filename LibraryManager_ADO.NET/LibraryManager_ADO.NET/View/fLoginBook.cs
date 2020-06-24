using LibraryManager_ADO.NET.Controller;
using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager_ADO.NET.View.Admin
{
    public partial class fLoginBook : Form
    {
        public bool borrowBook = false;
        public bool payBook = false;
        public fLoginBook()
        {
            InitializeComponent();
        }
        #region Events
        private void fLoginBook_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            if (borrowBook == true)
            {
                string id = "";
                id = txbId.Text.ToString();
                MemberDTO memberDTO = MemberDAO.Instance.GetMembertById(id);
                fBorrowBook fBorrowBook = new fBorrowBook(memberDTO);
                fBorrowBook.ShowDialog();
            }
            else if (payBook == true)
            {
                string id = "";
                id = txbId.Text.ToString();
                MemberDTO memberDTO = MemberDAO.Instance.GetMembertById(id);
                fPayBook fPayBook = new fPayBook(memberDTO);
                fPayBook.ShowDialog();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbId_TextChanged(object sender, EventArgs e)
        {
            string id = "";
            id = txbId.Text.ToString();
            MemberDTO memberDTO = MemberDAO.Instance.GetMembertById(id);
            if (memberDTO != null)
            {
                txbDisplayName.Text = memberDTO.FirstName + " " + memberDTO.LastName;

                if (memberDTO.Status == true)
                {
                    txbStatus.Text = "Bình thường";
                    btnLogin.Enabled = true;
                }
                else
                    txbStatus.Text = "Đã bị khóa!";
            }
            else
            {
                txbDisplayName.Text = "";
                txbStatus.Text = "";
            }  
            
        }
        #endregion

        #region Methods
        #endregion


    }
}
