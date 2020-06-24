using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BookShowDAO
    {
        private static BookShowDAO instance;

        public static BookShowDAO Instance
        {
            get { if (instance == null) instance = new BookShowDAO(); return instance; }
            private set { instance = value; }
        }
        public BookShowDAO() { }
        public List<BookShowDTO> GetListBook()
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id AND dbo.BookItem.BookId = dbo.Book.Id");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
        public BookShowDTO GetBookShowDTOById(string id)
        {
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.BookItem.BookId = dbo.Book.Id AND dbo.Book.Id = '{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new BookShowDTO(item);

            }
            return null;
        }
        public List<BookShowDTO> GetBookShowDTOByIdList(string id)
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.BookItem.BookId = dbo.Book.Id AND dbo.Book.Id = '{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
        public List<BookShowDTO> GetBookShowDTOByName(string name)
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("" +
                "SELECT * FROM	(SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , " +
                                "Publisher.Name AS Publisher, dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, " +
                                "dbo.Book.Status " +
                                "FROM dbo.Book, dbo.BookCategory,dbo.Publisher, dbo.BookItem " +
                                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                                "AND dbo.BookItem.BookId = dbo.Book.Id) AS A " +
                "WHERE dbo.fuConvertToUnsign1(title) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'",name);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
        public List<BookShowDTO> GetListBookStatusTrue()
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.BookItem.BookId = dbo.Book.Id AND dbo.Book.Status = 1");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
        public List<BookShowDTO> GetListBookStatusFalse()
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.BookItem.BookId = dbo.Book.Id AND dbo.Book.Status = 0");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
        public List<BookShowDTO> GetListBookByBookCategoryName(string name)
        {
            List<BookShowDTO> bookShowDTOs = new List<BookShowDTO>();
            string query = string.Format("SELECT dbo.Book.Id,dbo.Book.Title,BookCategory.Name,dbo.Book.Author , Publisher.Name AS Publisher, " +
                "dbo.Book.YearPublisher, dbo.Book.Price, dbo.BookItem.NumberCount, dbo.Book.Status " +
                "FROM dbo.Book, dbo.BookCategory, " +
                "dbo.Publisher, dbo.BookItem " +
                "WHERE dbo.Book.PublisherId = dbo.Publisher.Id AND dbo.Book.BookCategoryId = dbo.BookCategory.Id " +
                "AND dbo.BookItem.BookId = dbo.Book.Id AND dbo.BookCategory.Name = N'{0}'",name);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                BookShowDTO bookShowDTO = new BookShowDTO(item);
                bookShowDTOs.Add(bookShowDTO);
            }
            return bookShowDTOs;
        }
    }
}
