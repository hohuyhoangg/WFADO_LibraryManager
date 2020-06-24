﻿using LibraryManager_ADO.NET.Controller;
using LibraryManager_ADO.NET.Models;
using LibraryManager_ADO.NET.Utility;
using LibraryManager_ADO.NET.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager_ADO.NET.View
{
    public partial class fLibraryManager : Form
    {
        private LibrarianDTO loginLibrarianDTO;
        public LibrarianDTO LoginLibrarianDTO
        {
            get => loginLibrarianDTO;
            set
            {
                this.loginLibrarianDTO = value;
                ChangeLibrarian(loginLibrarianDTO.Id);
            }
        }
        BindingSource BindingSourceLibrarian = new BindingSource();
        BindingSource BindingSourceBookCategory = new BindingSource();
        BindingSource BindingSourceCustomer = new BindingSource();
        BindingSource BindingSourceAccount = new BindingSource();
        BindingSource BindingSourcePublisher = new BindingSource();
        BindingSource BindingSourceBook = new BindingSource();
        public fLibraryManager(LibrarianDTO librarianDTO)
        {
            InitializeComponent();
            this.LoginLibrarianDTO = librarianDTO;
        }
        private void fLibraryManager_Load(object sender, EventArgs e)
        {
            // Quản lí nhân viên
            LoadFullStaff();
            AddLibrarianBinding();
            //Quản lí sách
            LoadListBook();
            LoadBookCategoryIntoComboBox(cbxBookCategory);
            //Quản lí Thể loại sách
            LoadListBookCategory();
            AddBookCategoryBinding();
            //Quản lí Member
            LoadFullMember();
            AddMemberBinding();
            //Quản lí Account
            LoadFullAccount();
            AddAccountBinding();
            LoadAccountTypeIntoComboBox(cbxTypeAccount);
            //Quản lí Publisher
            LoadFullPublisher();
            AddPublisherBinding();
        }
        #region Var
        string bookID = "";

        #endregion
        #region Events
        private void ChangeNameLibrary_Click(object sender, EventArgs e)
        {

        }
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Quản lí nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //Lọc trạng thái làm việc
        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            id = comboBox.SelectedIndex;
            WorkingStatus(id);
        }
        private void txbStatus_TextChanged(object sender, EventArgs e)
        {
            if (txbStatus.Text.Equals("True"))
            {
                txbStatus.Text = "Đang làm việc";
            }
            else if (txbStatus.Text.Equals("False"))
            {
                txbStatus.Text = "Đã nghỉ làm việc";
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
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
            DateTime? startDate = dtpStartDate.Value;
            decimal salary = Decimal.Parse(txbSalary.Text);
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true && FormatData.Instance.IsSSN(ssn) == true
               && firstName != null && lastName != null &&
               address != null)
            {
                AddLibrarian(firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, startDate, salary);
                LoadFullStaff();
                MessageBox.Show("Đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
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
            DateTime? startDate = dtpStartDate.Value;
            decimal salary = Decimal.Parse(txbSalary.Text);
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true && FormatData.Instance.IsSSN(ssn) == true
               && firstName != null && lastName != null &&
               address != null)
            {
                UpdateLibrarian(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, startDate, salary);
                LoadFullStaff();
                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }

        }
        private void btnComeBack_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            UpdateStatusTrue(id);
            LoadFullStaff();
            MessageBox.Show("Đã cập nhật thành công!");
        }
        private void btnQuitoutLibrarian_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            UpdateStatusFalse(id);
            LoadFullStaff();
            MessageBox.Show("Đã cập nhật thành công!");
        }
        private void btnFileExcelBook_Click(object sender, EventArgs e)
        {

        }
        private void btnSetAdmin_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            UpdateAdmin(id);
            LoadFullAccount();
            MessageBox.Show("Đã cập nhật thành công!");
        }
        /// <summary>
        /// Quản lí sách
        /// </summary>
        /// 
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBook.CurrentCell.RowIndex;
            if (dgvBook.Rows[r].Cells[0].Value == null)
                return;
            bookID = dgvBook.Rows[r].Cells[0].Value.ToString();
            return;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookShowDTO bookShowDTO = BookShowDAO.Instance.GetBookShowDTOById(bookID);
            fBook fBook = new fBook(bookShowDTO);
            fBook.bookAddBook = true;
            fBook.Insert += FBook_Insert;
            fBook.Update += FBook_Update;
            fBook.Delete += FBook_Delete;
            fBook.ShowDialog();
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            BookShowDTO bookShowDTO = BookShowDAO.Instance.GetBookShowDTOById(bookID);
            fBook fBook = new fBook(bookShowDTO);
            fBook.Insert += FBook_Insert;
            fBook.Update += FBook_Update;
            fBook.Delete += FBook_Delete;
            fBook.bookUpdateBook = true;
            if (bookShowDTO != null)
                fBook.ShowDialog();
        }
        private void FBook_Delete(object sender, EventArgs e)
        {
            LoadListBook();
        }
        private void FBook_Update(object sender, EventArgs e)
        {
            LoadListBook();
        }
        private void FBook_Insert(object sender, EventArgs e)
        {
            LoadListBook();
        }
        private void btnBorowBook_Click(object sender, EventArgs e)
        {

            fLoginBook fLoginBook = new fLoginBook();
            fLoginBook.borrowBook = true;
            fLoginBook.ShowDialog();
        }
        private void btnPayBook_Click(object sender, EventArgs e)
        {
            fLoginBook fLoginBook = new fLoginBook();
            fLoginBook.payBook = true;
            fLoginBook.ShowDialog();
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (DeleteBook(bookID) == true)
            {
                LoadListBook();
                MessageBox.Show("Đã xóa thành công!");
            }
            else
                MessageBox.Show("Không thể xóa vì sách còn có người mượn!");
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            BookShowDTO bookShowDTO = BookShowDAO.Instance.GetBookShowDTOById(bookID);
            fStatistics fStatistics = new fStatistics(bookShowDTO);
            if (bookShowDTO != null)
                fStatistics.ShowDialog();
        }
        private void btnAllBook_Click(object sender, EventArgs e)
        {
            LoadListBook();
        }
        private void txbIdBook_TextChanged(object sender, EventArgs e)
        {
            string id = txbIdBook.Text;
            BindingSourceBook.DataSource = SearchBookById(id);
        }
        private void txbBookName_TextChanged(object sender, EventArgs e)
        {
            string name = txbBookName.Text;
            BindingSourceBook.DataSource = SearchBookByName(name);
        }
        private void cbbBookStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            id = comboBox.SelectedIndex;
            BookStatus(id);
        }
        private void cbxBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            id = comboBox.Text;
            GetListBookByBookCategoryName(id);
        }
        /// <summary>
        /// Quản lí chuyên mục sách
        /// </summary>
        private void txbStatusBookCategory_TextChanged(object sender, EventArgs e)
        {
            if (txbStatusBookCategory.Text.Equals("True"))
            {
                txbStatusBookCategory.Text = "Còn sử dụng";
            }
            else if (txbStatusBookCategory.Text.Equals("False"))
            {
                txbStatusBookCategory.Text = "Đã không còn sử dụng";
            }
        }
        private void btnEditBookCategory_Click(object sender, EventArgs e)
        {
            string id = txbIdBookCategory.Text;
            string name = txbNameBookCategoryy.Text;
            if (txbLimitDaysBookCategory.Text.Equals(""))
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            int limitDays = 0;
            if (txbLimitDaysBookCategory.Text.Equals("") == false)
                limitDays = Int32.Parse(txbLimitDaysBookCategory.Text);
            if (txbNameBookCategoryy.Text.Equals("") == false && txbLimitDaysBookCategory.Text.Equals("") == false && limitDays > 0)
            {
                UpdateBookCategory(id, name, limitDays);
                LoadListBookCategory();
                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void btnAddBookCategory_Click(object sender, EventArgs e)
        {

            string id = txbIdBookCategory.Text;
            string name = txbNameBookCategoryy.Text;
            if (txbLimitDaysBookCategory.Text.Equals(""))
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            int limitDays = 0;
            if (txbLimitDaysBookCategory.Text.Equals("") == false)
                limitDays = Int32.Parse(txbLimitDaysBookCategory.Text);
            if (SearchBookCategoryById(id))
            {
                if (txbNameBookCategoryy.Text.Equals("") == false && txbLimitDaysBookCategory.Text.Equals("") == false && limitDays > 0)
                {
                    AddBookCategory(id, name, limitDays);
                    LoadListBookCategory();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Một trong các vấn đề bị lỗi!");
                }
            }
            else
                MessageBox.Show("Mã sách trong thư viện không được trùng nhau!");
        }
        private void btnDeleteBookCategory_Click(object sender, EventArgs e)
        {
            string id = txbIdBookCategory.Text;
            DeleteBookCategory(id);
            LoadListBookCategory();
            MessageBox.Show("Đã chuyển trạng thái thành công!");

        }
        private void btnFileExcelBookCategory_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Quản lí bạn đọc
        /// </summary>
        private void txbStatusCusttomer_TextChanged(object sender, EventArgs e)
        {
            if (txbStatusCusttomer.Text.Equals("True"))
            {
                txbStatusCusttomer.Text = "Còn sử dụng";
            }
            else if (txbStatusCusttomer.Text.Equals("False"))
            {
                txbStatusCusttomer.Text = "Đã khóa";
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string id = txbIdCustomer.Text;
            string firstName = txbFirstNameCustomer.Text;
            string lastName = txbLastNameCustomer.Text;
            DateTime? birthday = dtpBirthdayCustomer.Value;
            int num = cbxSexCustomer.SelectedIndex;
            string sex = "";
            if (num == 0)
                sex = "Nam";
            else if (num == 1)
                sex = "Nữ";
            else
                sex = "Khác";
            string ssn = txbSSNCustomer.Text;
            string address = txbAddressCustomer.Text;
            string phoneNumber = txbPhoneNumberCustomer.Text;
            string email = txbEmailCustomer.Text;
            DateTime? registerDate = dtpRegisterDateCustomer.Value;

            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true && FormatData.Instance.IsSSN(ssn) == true
               && firstName.Equals("") == false && lastName.Equals("") == false &&
               address.Equals("") == false)
            {
                UpdateMember(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, registerDate);
                LoadFullMember();
                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void btnLockCustomer_Click(object sender, EventArgs e)
        {
            string id = txbIdCustomer.Text;
            UpdateStatusMemberFalse(id);
            LoadFullMember();
            MessageBox.Show("Đã khóa tài khoản thành công!");
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txbFirstNameCustomer.Text;
            string lastName = txbLastNameCustomer.Text;
            DateTime? birthday = dtpBirthdayCustomer.Value;
            int num = cbxSexCustomer.SelectedIndex;
            string sex = "";
            if (num == 0)
                sex = "Nam";
            else if (num == 1)
                sex = "Nữ";
            else
                sex = "Khác";
            string ssn = txbSSNCustomer.Text;
            string address = txbAddressCustomer.Text;
            string phoneNumber = txbPhoneNumberCustomer.Text;
            string email = txbEmailCustomer.Text;
            DateTime? registerDate = dtpRegisterDateCustomer.Value;
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true && FormatData.Instance.IsSSN(ssn) == true
               && firstName.Equals("") == false && lastName.Equals("") == false &&
               address.Equals("") == false)
            {
                AddMember(firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, registerDate);
                LoadFullMember();
                MessageBox.Show("Đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void cbxStatusCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            id = comboBox.SelectedIndex;
            MemberStatus(id);
        }
        private void btnFileExcelCustomer_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Quản lí Account
        /// </summary>
        private void btnSetPasswordAccount_Click(object sender, EventArgs e)
        {
            string id = txbIdAccount.Text;
            SetPasswordAccount(id);
            MessageBox.Show("Đã đặt lại mật khẩu thành công!");
        }
        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string id = txbSearchUsernameAccount.Text;
            SearchAccountById(id);
        }
        private void btnLoadFullAccount_Click(object sender, EventArgs e)
        {
            LoadFullAccount();
        }
        private void cbxTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            id = comboBox.SelectedIndex;
            LoadAccountByAcType(id);
        }
        /// <summary>
        /// Quản lí Publisher
        /// </summary>
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            string id = txbIdPublisher.Text;
            string name = txbNamePublisher.Text;
            string phoneNumber = txbPhoneNumberPublisher.Text;
            string address = txbAddressPublisher.Text;
            string email = txbEmailPublisher.Text;
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true
               && name.Equals("") == false && address.Equals("") == false)
            {
                AddPublisher(id, name, phoneNumber, address, email);
                LoadFullPublisher();
                MessageBox.Show("Đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {
            string id = txbIdPublisher.Text;
            string name = txbNamePublisher.Text;
            string phoneNumber = txbPhoneNumberPublisher.Text;
            string address = txbAddressPublisher.Text;
            string email = txbEmailPublisher.Text;
            if (FormatData.Instance.IsEmail(email) == true && FormatData.Instance.IsPhone(phoneNumber) == true
               && name.Equals("") == false && address.Equals("") == false)
            {
                UpdatePublisher(id, name, phoneNumber, address, email);
                LoadFullPublisher();
                MessageBox.Show("Đã cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
            }
        }
        private void txbPublisherSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txbPublisherSearch.Text;
            BindingSourcePublisher.DataSource = SearchPublisherByName(name);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Quản lí nhân viên
        /// </summary>
        /// <param name="id"></param>
        void ChangeLibrarian(string id)
        {
            InfoUsername.Text += " (" + LoginLibrarianDTO.FirstName + " " + LoginLibrarianDTO.LastName + ")";
        }
        void LoadFullStaff()
        {
            List<LibrarianDTO> librarianDTOs = LibrarianDAO.Instance.GetListLibrarian();
            BindingSourceLibrarian.DataSource = librarianDTOs;
            drvStaff.DataSource = BindingSourceLibrarian;
        }
        void WorkingStatusLibrarianTrue()
        {
            List<LibrarianDTO> librarianDTOs = LibrarianDAO.Instance.GetListLibrarianStatusTrue();
            BindingSourceLibrarian.DataSource = librarianDTOs;
            drvStaff.DataSource = BindingSourceLibrarian;
        }
        void WorkingStatusLibrarianFalse()
        {
            List<LibrarianDTO> librarianDTOs = LibrarianDAO.Instance.GetListLibrarianStatusFalse();
            BindingSourceLibrarian.DataSource = librarianDTOs;
            drvStaff.DataSource = BindingSourceLibrarian;
        }
        void WorkingStatus(int id)
        {
            if (id == 0)
            {
                LoadFullStaff();
            }
            else if (id == 1)
            {
                WorkingStatusLibrarianTrue();
            }
            else if (id == 2)
            {
                WorkingStatusLibrarianFalse();
            }
            else
                LoadFullStaff();
        }
        void AddLibrarianBinding()
        {
            txbId.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbFirstname.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txbLastName.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            dtpBrithday.DataBindings.Add(new Binding("Value", drvStaff.DataSource, "Birthday", true, DataSourceUpdateMode.Never));
            cbxSex.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Sex", true, DataSourceUpdateMode.Never));
            txbSsn.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "SSN", true, DataSourceUpdateMode.Never));
            txbAddress.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Email", true, DataSourceUpdateMode.Never));
            dtpStartDate.DataBindings.Add(new Binding("Value", drvStaff.DataSource, "StartDate", true, DataSourceUpdateMode.Never));
            txbSalary.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            txbStatus.DataBindings.Add(new Binding("Text", drvStaff.DataSource, "Status", true, DataSourceUpdateMode.Never));

        }
        void UpdateLibrarian(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? startDate, decimal salary)
        {
            LibrarianDAO.Instance.UpdateLibrarian(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, startDate, salary);
        }
        void AddLibrarian(string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? startDate, decimal salary)
        {
            LibrarianDAO.Instance.AddLibrarian(firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, startDate, salary);
        }
        void UpdateStatusTrue(string id)
        {
            LibrarianDAO.Instance.UpdateStatusTrue(id);
        }
        void UpdateStatusFalse(string id)
        {
            LibrarianDAO.Instance.UpdateStatusFalse(id);
        }
        void UpdateAdmin(string id)
        {
            AccountDAO.Instance.UpdateAdmin(id);
        }
        /// <summary>
        /// Quản lí  sách
        /// </summary>
        /// <param name=""></param>
        /// 
        /// 
        void LoadListBook()
        {
            List<BookShowDTO> bookShowDTOs = BookShowDAO.Instance.GetListBook();
            BindingSourceBook.DataSource = bookShowDTOs;
            dgvBook.DataSource = BindingSourceBook;
        }
        List<BookShowDTO> SearchBookById(string id)
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            bookShowDTOs = BookShowDAO.Instance.GetBookShowDTOByIdList(id);
            return bookShowDTOs;
        }
        List<BookShowDTO> SearchBookByName(string name)
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            bookShowDTOs = BookShowDAO.Instance.GetBookShowDTOByName(name);
            return bookShowDTOs;
        }
        void StatusBookTrue()
        {
            List<BookShowDTO> bookShowDTOs = BookShowDAO.Instance.GetListBookStatusTrue();
            BindingSourceBook.DataSource = bookShowDTOs;
            dgvBook.DataSource = BindingSourceBook;
        }
        void StatusBookFalse()
        {
            List<BookShowDTO> bookShowDTOs = BookShowDAO.Instance.GetListBookStatusFalse();
            BindingSourceBook.DataSource = bookShowDTOs;
            dgvBook.DataSource = BindingSourceBook;
        }
        void BookStatus(int id)
        {
            if (id == 0)
            {
                LoadListBook();
            }
            else if (id == 1)
            {
                StatusBookTrue();
            }
            else if (id == 2)
            {
                StatusBookFalse();
            }
            else
                LoadListBook();
        }
        void LoadBookCategoryIntoComboBox(ComboBox comboBox)
        {
            List<BookCategoryDTO> bookCategoryDTOs = BookCategoryDAO.Instance.GetListBookCategory();
            comboBox.DataSource = bookCategoryDTOs;
            comboBox.DisplayMember = "Name";
        }
        void GetListBookByBookCategoryName(string name)
        {
            List<BookShowDTO> bookShowDTOs = BookShowDAO.Instance.GetListBookByBookCategoryName(name);
            BindingSourceBook.DataSource = bookShowDTOs;
            dgvBook.DataSource = BindingSourceBook;
        }
        bool DeleteBook(string id)
        {
            bool temp = BookDAO.Instance.DeleteBook(id);
            if (temp == true)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Quản lí thể loại sách
        /// </summary>
        /// <param name=""></param>
        /// 
        void LoadListBookCategory()
        {
            List<BookCategoryDTO> bookCategoryDTOs = BookCategoryDAO.Instance.GetListBookCategory();
            BindingSourceBookCategory.DataSource = bookCategoryDTOs;
            dgvBookCategory.DataSource = BindingSourceBookCategory;
        }
        void AddBookCategoryBinding()
        {
            txbIdBookCategory.DataBindings.Add(new Binding("Text", dgvBookCategory.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameBookCategoryy.DataBindings.Add(new Binding("Text", dgvBookCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbLimitDaysBookCategory.DataBindings.Add(new Binding("Text", dgvBookCategory.DataSource, "LimitDays", true, DataSourceUpdateMode.Never));
            txbStatusBookCategory.DataBindings.Add(new Binding("Text", dgvBookCategory.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void UpdateBookCategory(string id, string name, int limitDays)
        {
            BookCategoryDAO.Instance.UpdateBookCategory(id, name, limitDays);
        }
        void AddBookCategory(string id, string name, int limitDays)
        {
            BookCategoryDAO.Instance.AddBookCategory(id, name, limitDays);
        }
        void DeleteBookCategory(string id)
        {
            BookCategoryDAO.Instance.DeleteBookCategory(id);
        }
        bool SearchBookCategoryById(string id)
        {
            if (BookCategoryDAO.Instance.SearchBookCategoryById(id))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Quản lí bạn đọc
        /// </summary>
        /// <param name=""></param>
        /// 
        void LoadFullMember()
        {
            List<MemberDTO> memberDAOs = MemberDAO.Instance.GetListMember();
            BindingSourceCustomer.DataSource = memberDAOs;
            dgvCustomer.DataSource = BindingSourceCustomer;
        }
        void AddMemberBinding()
        {
            txbIdCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbFirstNameCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txbLastNameCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            dtpBirthdayCustomer.DataBindings.Add(new Binding("Value", dgvCustomer.DataSource, "Birthday", true, DataSourceUpdateMode.Never));
            cbxSexCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Sex", true, DataSourceUpdateMode.Never));
            txbSSNCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "SSN", true, DataSourceUpdateMode.Never));
            txbAddressCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbPhoneNumberCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txbEmailCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never));
            dtpRegisterDateCustomer.DataBindings.Add(new Binding("Value", dgvCustomer.DataSource, "RegisterDate", true, DataSourceUpdateMode.Never));
            txbStatusCusttomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "Status", true, DataSourceUpdateMode.Never));

        }
        void StatusMemberTrue()
        {
            List<MemberDTO> memberDTOs = MemberDAO.Instance.GetListMemberStatusTrue();
            BindingSourceCustomer.DataSource = memberDTOs;
            dgvCustomer.DataSource = BindingSourceCustomer;
        }
        void StatusMemberFalse()
        {
            List<MemberDTO> memberDTOs = MemberDAO.Instance.GetListMemberStatusFalse();
            BindingSourceCustomer.DataSource = memberDTOs;
            dgvCustomer.DataSource = BindingSourceCustomer;
        }
        void MemberStatus(int id)
        {
            if (id == 0)
            {
                LoadFullMember();
            }
            else if (id == 1)
            {
                StatusMemberTrue();
            }
            else if (id == 2)
            {
                StatusMemberFalse();
            }
            else
                LoadFullMember();
        }
        void UpdateMember(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? registerDate)
        {
            MemberDAO.Instance.UpdateMember(id, firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, registerDate);
        }
        void AddMember(string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? registerDate)
        {
            MemberDAO.Instance.AddMember(firstName, lastName, birthday, sex, ssn, address, phoneNumber, email, registerDate);
        }
        void UpdateStatusMemberFalse(string id)
        {
            MemberDAO.Instance.UpdateStatusFalse(id);
        }
        /// <summary>
        /// Quản lí Account
        /// </summary>
        /// <param name=""></param>
        /// 
        void LoadFullAccount()
        {
            List<AccountManagerDTO> accountManagerDTOs = AccountManagerDAO.Instance.GetListAccount();
            BindingSourceAccount.DataSource = accountManagerDTOs;
            dgvAccount.DataSource = BindingSourceAccount;
        }
        void AddAccountBinding()
        {
            txbIdAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "PersonId", true, DataSourceUpdateMode.Never));
            txbSearchUsernameAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "PersonId", true, DataSourceUpdateMode.Never));
            txbUsernameAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbTypeAccount.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void SetPasswordAccount(string id)
        {
            AccountDTO accountDTO = AccountDAO.Instance.GetAccountById(id);
            int AcType = accountDTO.AcType;
            if (AcType == 1 || AcType == 2)
            {
                AccountManagerDAO.Instance.SetPasswordAccountLibrarian(id);
            }
            else if (AcType == 3)
            {
                AccountManagerDAO.Instance.SetPasswordAccountMember(id);
            }
        }
        void SearchAccountById(string id)
        {
            List<AccountManagerDTO> accountManagerDTOs = AccountManagerDAO.Instance.GetAccountById(id);
            BindingSourceAccount.DataSource = accountManagerDTOs;
            dgvAccount.DataSource = BindingSourceAccount;
        }
        void LoadAccountTypeIntoComboBox(ComboBox comboBox)
        {
            List<AccountTypeDTO> accountTypeDTOs = AccountTypeDAO.Instance.GetListAccountType();
            comboBox.DataSource = accountTypeDTOs;
            comboBox.DisplayMember = "Type";
        }
        void LoadAccountByAcType(int id)
        {
            List<AccountManagerDTO> accountManagerDTOs = AccountManagerDAO.Instance.GetListAccountByType(id + 1);
            BindingSourceAccount.DataSource = accountManagerDTOs;
            dgvAccount.DataSource = BindingSourceAccount;
        }
        /// <summary>
        /// Quản lí Nhà xuất bản
        /// 
        /// </summary>
        /// <param name=""></param>
        /// 
        void LoadFullPublisher()
        {
            List<PublisherDTO> publisherDTOs = PublisherDAO.Instance.GetListPublisher();
            BindingSourcePublisher.DataSource = publisherDTOs;
            dgvPublisher.DataSource = BindingSourcePublisher;
        }
        void AddPublisherBinding()
        {
            txbIdPublisher.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNamePublisher.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbPhoneNumberPublisher.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txbAddressPublisher.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbEmailPublisher.DataBindings.Add(new Binding("Text", dgvPublisher.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }
        void AddPublisher(string id, string name, string phoneNumber, string address, string email)
        {
            PublisherDAO.Instance.AddPublisher(id, name, phoneNumber, address, email);
        }
        void UpdatePublisher(string id, string name, string phoneNumber, string address, string email)
        {
            PublisherDAO.Instance.UpdatePublisher(id, name, phoneNumber, address, email);
        }
        List<PublisherDTO> SearchPublisherByName(string name)
        {
            List<PublisherDTO> publisherDTOs = new List<PublisherDTO>();
            publisherDTOs = PublisherDAO.Instance.SearchPublisherByName(name);
            return publisherDTOs;
        }
        #endregion

    }
}
