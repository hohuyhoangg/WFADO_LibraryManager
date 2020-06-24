using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class BorrowDAO
    {
        private static BorrowDAO instance;

        public static BorrowDAO Instance
        {
            get { if (instance == null) instance = new BorrowDAO(); return instance; }
            private set { instance = value; }
        }
        public BorrowDAO() { }
        public BorrowDTO GetBookBorrowByBookIdAndMemberId(string bookId,string memberId)
        {
            string query = string.Format("SELECT * FROM dbo.Borrow WHERE BookId = '{0}' AND MemberId = '{1}' AND Status = 0 ", bookId,memberId);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new BorrowDTO(item);

            }
            return null;
        }
    }
}
