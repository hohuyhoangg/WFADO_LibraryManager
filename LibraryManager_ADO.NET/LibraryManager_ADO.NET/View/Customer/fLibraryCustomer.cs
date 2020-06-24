using LibraryManager_ADO.NET.Controller;
using LibraryManager_ADO.NET.Models;
using LibraryManager_ADO.NET.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager_ADO.NET.View.Customer
{
    public partial class fLibraryCustomer : Form
    {
        private MemberDTO loginMemberDTO;
        public MemberDTO LoginMemberDTO
        {
            get => loginMemberDTO;
            set
            {
                this.loginMemberDTO = value;
                ChangeLibrarian(loginMemberDTO.Id);
            }
        }
        public fLibraryCustomer(MemberDTO memberDTO)
        {
            InitializeComponent();
            this.LoginMemberDTO = memberDTO;
        }
        BindingSource BindingSourceBookBorrow = new BindingSource();
        #region Var
        #endregion
        #region Events
        private void fLibraryCustomer_Load(object sender, EventArgs e)
        {
            string id = LoginMemberDTO.Id;
            LoadListBookBorrow(id);
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            string firstName = txbFirstname.Text;
            string lastName = txbLastName.Text;
            DateTime? birthday = dtpBrithday.Value;
            int num = cbxSex.SelectedIndex;
            string sex = "";
            if (num == 0)
                sex = "Nam";
            else if (num == 1)
                sex = "Nữ";
            else
                sex = "Khác";
            string ssn = txbSsn.Text;
            string address = txbAddress.Text;
            string phoneNumber = txbPhoneNumber.Text;
            string email = txbEmail.Text;
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true && FormatData.Instance.IsSSN(ssn) == true
               && firstName != null && lastName != null &&
               address != null)
            {
                UpdateToMe(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email);
                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            string username = txbId.Text.ToString();
            AccountDTO accountDTO = AccountDAO.Instance.GetAccountByUsername(username);
            string oldpass = txbPassword.Text.ToString();
            string newpass = txbNewPass.Text.ToString();
            string retypepass = txbRetypePass.Text.ToString();
            if (accountDTO.Password.Equals(oldpass))
            {
                if (newpass.Equals(retypepass))
                {
                    if (UpdatePassToMe(username, newpass))
                    {
                        txbPassword.Clear();
                        txbNewPass.Clear();
                        txbRetypePass.Clear();
                        MessageBox.Show("Đã cập nhật mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có một lỗi nào đó. Xin hãy thử lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng mật khẩu cũ!");
            }
        }
        #endregion
        #region Methods
        void ChangeLibrarian(string id)
        {
            InfoUsername.Text += " (" + LoginMemberDTO.FirstName + " " + LoginMemberDTO.LastName + ")";
            txbId.Text = LoginMemberDTO.Id;
            txbFirstname.Text = LoginMemberDTO.FirstName;
            txbLastName.Text = LoginMemberDTO.LastName;
            dtpBrithday.Value = LoginMemberDTO.Birthday.Value;
            cbxSex.Text = LoginMemberDTO.Sex;
            txbSsn.Text = LoginMemberDTO.Ssn;
            txbAddress.Text = LoginMemberDTO.Address;
            txbPhoneNumber.Text = LoginMemberDTO.PhoneNumber;
            txbEmail.Text = LoginMemberDTO.Email;
            dtpRegisterDate.Value = LoginMemberDTO.RegisterDate.Value;
            dtpRegisterDate.Enabled = false;
        }
        void LoadListBookBorrow(string id)
        {
            List<BookBorrowDTO> bookBorrowDTOs = BookBorrowDAO.Instance.GetListBookBorrowById(id);
            BindingSourceBookBorrow.DataSource = bookBorrowDTOs;
            dgvBookBorrow.DataSource = BindingSourceBookBorrow;
        }
        void UpdateToMe(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email)
        {
            MemberDAO.Instance.UpdateMemberToMe(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email);
        }
        bool UpdatePassToMe(string username, string newpass)
        {
            return AccountDAO.Instance.UpdatePass(username, newpass);
        }
        #endregion


    }
}
