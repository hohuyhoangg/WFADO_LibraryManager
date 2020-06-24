using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BookCategoryDAO
    {
        private static BookCategoryDAO instance;

        public static BookCategoryDAO Instance
        {
            get { if (instance == null) instance = new BookCategoryDAO(); return instance; }
            private set { instance = value; }
        }
        public BookCategoryDAO() { }
        public List<BookCategoryDTO> GetListBookCategory()
        {
            List<BookCategoryDTO> bookCategoryDTOs = new List<BookCategoryDTO>();
            string query = string.Format("SELECT * FROM dbo.BookCategory");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookCategoryDTO librarianDTO = new BookCategoryDTO(item);
                bookCategoryDTOs.Add(librarianDTO);
            }
            return bookCategoryDTOs;
        }
        public List<BookCategoryDTO> GetListBookCategoryStatusTrue()
        {
            List<BookCategoryDTO> bookCategoryDTOs = new List<BookCategoryDTO>();
            string query = string.Format("SELECT * FROM dbo.BookCategory WHERE Status = 1");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookCategoryDTO librarianDTO = new BookCategoryDTO(item);
                bookCategoryDTOs.Add(librarianDTO);
            }
            return bookCategoryDTOs;
        }
        public bool UpdateBookCategory(string id, string name, int limitDays)
        {
            string query = string.Format("UPDATE dbo.BookCategory SET Name = N'{0}',LimitDays = {1}, Status = 1 WHERE Id = '{2}'", name, limitDays, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool AddBookCategory(string id, string name, int limitDays)
        {
            string query = string.Format("INSERT INTO dbo.BookCategory (Id,Name,LimitDays,Status) VALUES('{0}',N'{1}',{2},1)", id, name, limitDays);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteBookCategory(string id)
        {
            string query = string.Format("UPDATE dbo.BookCategory SET Status = 0 WHERE Id = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool SearchBookCategoryById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.BookCategory WHERE Id = '{0}'", id);
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
        public BookCategoryDTO GetBookCategoryById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.BookCategory WHERE Id = '{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new BookCategoryDTO(item);

            }
            return null;
        }
    }
}
