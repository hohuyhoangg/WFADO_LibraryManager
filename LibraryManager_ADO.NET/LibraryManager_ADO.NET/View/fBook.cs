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

namespace LibraryManager_ADO.NET.View
{
    public partial class fBook : Form
    {
        #region Variables
        string bookCategoryIdTemp;
        bool bookCategoryStatus;
        string publisherTemp;
        public bool bookAddBook = false;
        public bool bookUpdateBook = false;
        #endregion
        private BookShowDTO bookShowDTOLogin;
        public BookShowDTO BookShowDTOLogin
        {
            get => bookShowDTOLogin;
            set
            {
                this.bookShowDTOLogin = value;
            }
        }
        public fBook(BookShowDTO bookShowDTOLogin)
        {
            InitializeComponent();
            this.BookShowDTOLogin = bookShowDTOLogin;
        }

        #region Events
        private void fBook_Load(object sender, EventArgs e)
        {
            this.Show();
            LoadTXB();
            LoadListBookCategoryIntoComboBox(cbxBookCategory);
            LoadListPublisherIntoComboBox(cbbBookPublisher);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private event EventHandler insert;
        public event EventHandler Insert
        {
            add { insert += value; }
            remove { insert = value; }
        }
        private event EventHandler update;
        public event EventHandler Update
        {
            add { update += value; }
            remove { update = value; }
        }
        private event EventHandler delete;
        public event EventHandler Delete
        {
            add { delete += value; }
            remove { delete = value; }
        }
        private void btnResetTXBBook_Click(object sender, EventArgs e)
        {
            ClearFormBook();
        }
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            string bookCategoryId = bookCategoryIdTemp;
            string id = txbBookId.Text;
            string title = txbBookName.Text;
            string author = txbBookAuthor.Text;
            string publisherId = publisherTemp;
            int yearPublisher = 0;
            if (txbBookYear.Text != null)
                yearPublisher = Int32.Parse(txbBookYear.Text.ToString());
            decimal price = 0;
            if (nudBookCount.Text != null)
                price = Decimal.Parse(txbBookPrice.Text.ToString());

            int number = 0;
            if (nudBookCount.Text != null)
                number = Int32.Parse(nudBookCount.Text.ToString());
            int date = DateTime.Now.Year;
            if (id != null && title != null && author != null && yearPublisher > 1800 && yearPublisher < date && number > 0)
            {
                if( bookAddBook == true)
                {
                    AddBook(id, title, author, publisherId, yearPublisher, bookCategoryId, price, number);
                    MessageBox.Show("Đã thêm thành công!");
                    ClearFormBook();
                    if (insert != null)
                    {
                        insert(this, new EventArgs());
                    }
                }
                else if(bookUpdateBook == true)
                {
                    UpdateBook(id, title, author, publisherId, yearPublisher, bookCategoryId, price, number);
                    MessageBox.Show("Đã cập nhật thành công!");
                    if (update != null)
                    {
                        update(this, new EventArgs());
                    }
                    this.Close();
                }
            }
            else
                MessageBox.Show("Một trong các vấn đề bị lỗi!");
        }
        private void cbxBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            BookCategoryDTO bookCategoryDTO = comboBox.SelectedItem as BookCategoryDTO;
            bookCategoryIdTemp = bookCategoryDTO.Id;
            bookCategoryStatus = bookCategoryDTO.Status;
            return;
        }
        private void cbbBookPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            PublisherDTO publisherDTO = comboBox.SelectedItem as PublisherDTO;
            publisherTemp = publisherDTO.Id;
            return;
        }
        #region Method
        void LoadTXB()
        {
            if (bookAddBook == true)
            {
                MessageBox.Show("Bắt đầu thêm sách!");
            }
            else if (bookUpdateBook == true)
            {
                if(BookShowDTOLogin == null)
                {
                    MessageBox.Show("Kho không có sách!");
                }
                if(BookShowDTOLogin != null)
                {
                    txbBookId.Text = BookShowDTOLogin.Id;
                    txbBookName.Text = BookShowDTOLogin.Title;
                    txbBookAuthor.Text = BookShowDTOLogin.Author;
                    cbbBookPublisher.Text = BookShowDTOLogin.Publisher;
                    txbBookYear.Text = BookShowDTOLogin.YearPublisher.ToString();
                    txbBookPrice.Text = BookShowDTOLogin.Price.ToString();
                    nudBookCount.Value = bookShowDTOLogin.NumberCount;
                }
            }
        }
        void LoadListBookCategoryIntoComboBox(ComboBox comboBox)
        {
            List<BookCategoryDTO> bookCategoryDTOs = BookCategoryDAO.Instance.GetListBookCategoryStatusTrue();
            comboBox.DataSource = bookCategoryDTOs;
            comboBox.DisplayMember = "Name";
        }
        void LoadListPublisherIntoComboBox(ComboBox comboBox)
        {
            List<PublisherDTO> publisherDTOs = PublisherDAO.Instance.GetListPublisher();
            comboBox.DataSource = publisherDTOs;
            comboBox.DisplayMember = "Name";
        }
        void AddBook(string id, string title, string author, string publisherId, int yearPublisher, string bookCategoryId, decimal price, int number)
        {
            BookDAO.Instance.AddBook(id, title, author, publisherId, yearPublisher, bookCategoryId, price, number);
        }
        void ClearFormBook()
        {
            txbBookId.Clear();
            txbBookName.Clear();
            txbBookAuthor.Clear();
            txbBookYear.Text = "1990";
            txbBookPrice.Text = "0";
            nudBookCount.Value = 0;
        }
        void UpdateBook(string id, string title, string author, string publisherId, int yearPublisher, string bookCategoryId, decimal price, int number)
        {
            BookDAO.Instance.Update(id, title, author, publisherId, yearPublisher, bookCategoryId, price, number);
        }

        #endregion

        
    }
}
