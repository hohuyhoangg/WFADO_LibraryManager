using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BookBorrowDAO
    {
        private static BookBorrowDAO instance;

        public static BookBorrowDAO Instance
        {
            get { if (instance == null) instance = new BookBorrowDAO(); return instance; }
            private set { instance = value; }
        }
        public BookBorrowDAO() { }
        public List<BookBorrowDTO> GetListBookBorrowById(string id)
        {
            List<BookBorrowDTO> bookBorrowDTOs = new List<BookBorrowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price " +
                "FROM dbo.Book, dbo.BookCategory, dbo.Publisher, dbo.Borrow " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.Borrow.BookId = dbo.Book.Id AND dbo.Borrow.MemberId = '{0}' AND dbo.Borrow.Status = 0", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookBorrowDTO bookBorrowDTO = new BookBorrowDTO(item);
                bookBorrowDTOs.Add(bookBorrowDTO);
            }
            return bookBorrowDTOs;
        }
        public bool AddBookBorrow(string id, string memberid)
        {
            string query = string.Format("INSERT INTO dbo.Borrow(BookId,MemberId,BorrowDate,Status) VALUES ('{0}', '{1}', GETDATE(),0)", id, memberid);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public int GetNumberCountBookBorrowById(string id)
        {
            // Đang mượn Status = 0
            string query = string.Format("SELECT * FROM dbo.Borrow WHERE Status = 0 AND BookId = '{0}'", id);
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count;
        }
        public bool DeleteBookBorrow(string id, string memberId,int borrowId,DateTime dateTimeBorrow,int limitDays)
        {
            string query = string.Format("UPDATE dbo.Borrow SET Status = 1 WHERE BookId = '{0}' AND MemberId = '{1}'", id, memberId);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            if(result > 0)
            {
                string query1 = string.Format("INSERT INTO dbo.ReturnBook(BorrowId,ReturnDate) VALUES ( {0} ,GETDATE() )",borrowId);
                DataProvider.Instance.ExcuteNonQuery(query1);
                DateTime dateBorrow = Convert.ToDateTime(dateTimeBorrow);
                DateTime dateReturn = Convert.ToDateTime(DateTime.Now);
                TimeSpan Time = dateReturn - dateTimeBorrow;
                int days = Time.Days;
                if(days > limitDays)
                {
                    int temp = (days - limitDays) * 1000;
                    string query2 = string.Format("INSERT INTO dbo.PayFineInfo(BorrowId, Cash)VALUES({0},{1})",borrowId,temp);
                    DataProvider.Instance.ExcuteNonQuery(query2);
                }
                else
                {
                    int temp = (days - limitDays) * 1000;
                    string query2 = string.Format("INSERT INTO dbo.PayFineInfo(BorrowId, Cash)VALUES({0},0)", borrowId);
                    DataProvider.Instance.ExcuteNonQuery(query2);
                }    
            }
            return result > 0;
        }
    }
}
