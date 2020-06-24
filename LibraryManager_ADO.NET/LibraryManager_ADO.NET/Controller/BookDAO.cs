using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get { if (instance == null) instance = new BookDAO(); return instance; }
            private set { instance = value; }
        }
        public BookDAO() { }
        public bool AddBook(string id, string title, string author, string publisherId, int yearPublisher, string bookCategoryId, decimal price, int number)
        {
            string query = string.Format("INSERT INTO dbo.Book(Id,Title,Author,PublisherId,YearPublisher,BookCategoryId,Price,Status) " +
                "VALUES ('{0}',N'{1}',N'{2}','{3}',{4},'{5}',{6},1)", id, title, author, publisherId, yearPublisher, bookCategoryId, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            if (result > 0)
            {
                string queryv1 = string.Format("INSERT INTO dbo.BookItem (BookId, NumberCount) VALUES('{0}', {1})", id, number);
                DataProvider.Instance.ExcuteNonQuery(queryv1);
            }
            return result > 0;
        }
        public bool Update(string id, string title, string author, string publisherId, int yearPublisher, string bookCategoryId, decimal price, int number)
        {
            string query = string.Format("UPDATE dbo.Book SET Title = N'{0}' , Author = N'{1}', PublisherId = '{2}', YearPublisher ={3} , " +
                "BookCategoryId = '{4}' ,Price = {5}  WHERE Id = '{6}'", title, author, publisherId, yearPublisher, bookCategoryId, price, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            if (result > 0)
            {
                string queryv1 = string.Format("UPDATE dbo.BookItem SET NumberCount = {0} WHERE BookId = '{1}'", number, id);
                DataProvider.Instance.ExcuteNonQuery(queryv1);
            }
            return result > 0;
        }
        public bool DeleteBook(string id)
        {
            string query = string.Format("SELECT * FROM dbo.Borrow WHERE Status = 1 AND BookId = '{0}'",id);
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            int count = result.Rows.Count;
            if( count == 0)
            {
                string query1 = string.Format("UPDATE dbo.Book SET Status = 0 WHERE Id = '{0}'", id);
                DataProvider.Instance.ExcuteNonQuery(query1);
            }
            return count > 0;
        }
        public BookDTO GetBookById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.Book WHERE Id = '{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new BookDTO(item);

            }
            return null;
        }
    }
}
