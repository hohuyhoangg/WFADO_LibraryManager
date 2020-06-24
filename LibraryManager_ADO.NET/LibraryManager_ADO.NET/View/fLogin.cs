using LibraryManager_ADO.NET.Controller;
using LibraryManager_ADO.NET.Models;
using LibraryManager_ADO.NET.View;
using LibraryManager_ADO.NET.View.Customer;
using LibraryManager_ADO.NET.View.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager_ADO.NET
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            if (Login(username, password))
            {
                AccountDTO accountDTO = AccountDAO.Instance.GetAccountByUsername(username);
                int AcType = accountDTO.AcType;
                string PersonId = accountDTO.PersonId;
                LibrarianDTO librarianDTO = LibrarianDAO.Instance.GetLibrarianById(PersonId);
                MemberDTO memberDTO = MemberDAO.Instance.GetMembertById(PersonId);
                if (AcType == 1)
                {
                    if (librarianDTO.Status == true)
                    {
                        fLibraryManager manager = new fLibraryManager(librarianDTO);
                        this.Hide();
                        manager.ShowDialog();
                        this.Show();
                        txbPassword.Text = "";
                    }
                    else
                        MessageBox.Show("Tài khoản của bạn đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (AcType == 2)
                {
                    if(librarianDTO.Status == true)
                    {
                        fLibraryStaff staff = new fLibraryStaff(librarianDTO);
                        this.Hide();
                        staff.ShowDialog();
                        this.Show();
                        txbPassword.Text = "";
                    }
                    else
                        MessageBox.Show("Tài khoản của bạn đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fLibraryCustomer customer = new fLibraryCustomer(memberDTO);
                    this.Hide();
                    customer.ShowDialog();
                    this.Show();
                    txbPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (this.txbPassword.UseSystemPasswordChar == true)
            {
                this.txbPassword.UseSystemPasswordChar = false;
                btnPassword.BackgroundImage = Properties.Resources.showPassword;
            }
            else
            {
                this.txbPassword.UseSystemPasswordChar = true;
                btnPassword.BackgroundImage = Properties.Resources.hidePassword;
            }   
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                e.Cancel = true;
        }
        #endregion
        #region Methods 
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        #endregion

        
    }
}
