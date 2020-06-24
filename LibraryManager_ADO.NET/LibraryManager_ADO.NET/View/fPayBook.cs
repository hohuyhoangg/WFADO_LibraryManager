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
    public partial class fPayBook : Form
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
        public fPayBook(MemberDTO memberDTO)
        {
            InitializeComponent();
            this.LoginMemberDTO = memberDTO;
        }
        #region Var
        bool flag = false;
        #endregion
        #region Evnets
        private void fPayBook_Load(object sender, EventArgs e)
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
            btnPay.Enabled = false;
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string bookId = txbBookId.Text.ToString();
            string memberId = txbId.Text.ToString();
            BookDTO bookDTO = BookDAO.Instance.GetBookById(bookId);
            BorrowDTO borrowDTO = BorrowDAO.Instance.GetBookBorrowByBookIdAndMemberId(bookId, memberId);
            BookCategoryDTO bookCategoryDTO = BookCategoryDAO.Instance.GetBookCategoryById(bookDTO.BookCategoryId);
            int borrowId = borrowDTO.Id;
            int limitDays = bookCategoryDTO.LimitDays;
            DateTime dateTime = borrowDTO.BorrowDate.Value;
            if (ReturnBook(bookId,memberId,borrowId,dateTime,limitDays))
            {
                LoadListBookBorrow(memberId);
                MessageBox.Show("Đã trả sách thành công!");
            }
            else
            {
                MessageBox.Show("Một số lỗi gì đó!");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbBookId_TextChanged(object sender, EventArgs e)
        {
            string bookId = txbBookId.Text.ToString();
            string memberId = txbId.Text.ToString();
            BookDTO bookDTO = BookDAO.Instance.GetBookById(bookId);
            List<BookBorrowDTO> bookBorrowDTOs = BookBorrowDAO.Instance.GetListBookBorrowById(memberId);
            if (bookDTO != null)
            {
                txbBookName.Text = bookDTO.Title;
                for (int i = 0; i < bookBorrowDTOs.Count; i++)
                {
                    if (String.Compare(bookBorrowDTOs[i].Id, bookId, true) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == true)
                {
                    btnPay.Enabled = true;
                }
            }
            else
            {
                txbBookName.Text = "Sách không tồn tại!";
                flag = false;
                btnPay.Enabled = false;
            }
        }
        #endregion
        #region Methods
        void LoadListBookBorrow(string id)
        {
            List<BookBorrowDTO> bookBorrowDTOs = BookBorrowDAO.Instance.GetListBookBorrowById(id);
            BindingSourceBookBorrow.DataSource = bookBorrowDTOs;
            dgvBookBorrow.DataSource = BindingSourceBookBorrow;
        }
        int GetLimitDayBookCategoryById(string id)
        {
            BookCategoryDTO bookCategoryDTO = BookCategoryDAO.Instance.GetBookCategoryById(id);
            return bookCategoryDTO.LimitDays;

        }
        bool ReturnBook(string bookId, string memberId, int borrowId, DateTime dateTimeBorrow, int limitDays)
        {
            return BookBorrowDAO.Instance.DeleteBookBorrow(bookId, memberId, borrowId, dateTimeBorrow, limitDays);
        }
        #endregion

        
    }
}
