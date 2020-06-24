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
    public partial class fBorrowBook : Form
    {
        private MemberDTO loginMemberDTO;
        public MemberDTO LoginMemberDTO
        {
            get => loginMemberDTO;
            set
            {
                this.loginMemberDTO = value;
            }
        }
        BindingSource BindingSourceBookBorrow = new BindingSource();
        public fBorrowBook(MemberDTO memberDTO)
        {
            InitializeComponent();
            this.LoginMemberDTO = memberDTO;
        }
        #region Var
        bool flag = false;
        #endregion
        #region Events
        private void fBorrowBook_Load(object sender, EventArgs e)
        {
            txbId.Text = LoginMemberDTO.Id.ToString();
            txbFIrstname.Text = LoginMemberDTO.FirstName.ToString();
            txbLastname.Text = LoginMemberDTO.LastName.ToString();
            txbSex.Text = LoginMemberDTO.Sex;
            dtpBrithday.Value = LoginMemberDTO.Birthday.Value;
            txbSsn.Text = LoginMemberDTO.Ssn;
            txbAddress.Text = LoginMemberDTO.Address;
            txbEmail.Text = LoginMemberDTO.Email;
            dtpRegisterDate.Value = LoginMemberDTO.RegisterDate.Value;
            txbPhone.Text = LoginMemberDTO.PhoneNumber;
            LoadListBookBorrow(LoginMemberDTO.Id);
            btnBorrow.Enabled = false;
        }
        private void txbBookId_TextChanged(object sender, EventArgs e)
        {
            string id = "";
            id = txbBookId.Text.ToString();
            BookDTO bookDTO = BookDAO.Instance.GetBookById(id);
            if (bookDTO != null)
            {
                txbBookName.Text = bookDTO.Title;
                flag = true;
                btnBorrow.Enabled = true;
            }
            else
            {
                txbBookName.Text = "Sách không tồn tại!";
                flag = false;
                btnBorrow.Enabled = false;
            }
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            string bookId = txbBookId.Text.ToString();
            string memberId = txbId.Text.ToString();
            //Kiểm tra sách còn hay không
            BookItemDTO bookItemDTO = BookItemDAO.Instance.GetBookItemById(bookId);
            int numberCount = bookItemDTO.NumberCount;
            int numberCountBorrow = BookBorrowDAO.Instance.GetNumberCountBookBorrowById(bookId);
            if ((numberCount - numberCountBorrow) > 0)
            {
                int flag1 = 1;
                List<BookBorrowDTO> bookBorrowDTOs = BookBorrowDAO.Instance.GetListBookBorrowById(memberId);
                for (int i = 0; i < bookBorrowDTOs.Count; i++)
                {
                    if (String.Compare(bookBorrowDTOs[i].Id, bookId, true) == 0)
                    {
                        flag1 = 0;
                        MessageBox.Show("Bạn đã mượn sách này!");
                        break;
                    }
                }
                if (flag1 == 1)
                {
                    BorrowBook(bookId, memberId);
                    LoadListBookBorrow(memberId);
                    MessageBox.Show("Đã cho mượn thành công!");
                }
            }
            else
                MessageBox.Show("Sách này đã hết!");
        }
        #endregion

        #region Methods
        void LoadListBookBorrow(string id)
        {
            List<BookBorrowDTO> bookBorrowDTOs = BookBorrowDAO.Instance.GetListBookBorrowById(id);
            BindingSourceBookBorrow.DataSource = bookBorrowDTOs;
            dgvBookBorrow.DataSource = BindingSourceBookBorrow;
        }
        void BorrowBook(string id, string memberId)
        {
            BookBorrowDAO.Instance.AddBookBorrow(id, memberId);
        }
        #endregion
    }
}
