using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BookItemDAO
    {
        private static BookItemDAO instance;

        public static BookItemDAO Instance
        {
            get { if (instance == null) instance = new BookItemDAO(); return instance; }
            private set { instance = value; }
        }
        public BookItemDAO() { }

        public BookItemDTO GetBookItemById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.BookItem WHERE BookId ='{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new BookItemDTO(item);

            }
            return null;
        }
    }
}
