using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class BookItemDTO
    {
        private string bookId;
        private int numberCount;

        public string BookId { get => bookId; set => bookId = value; }
        public int NumberCount { get => numberCount; set => numberCount = value; }

        public BookItemDTO() { }
        public BookItemDTO(string bookId, int numberCount)
        {
            BookId = bookId;
            NumberCount = numberCount;
        }
        public BookItemDTO(DataRow dataRow)
        {
            BookId = dataRow["bookId"].ToString();
            NumberCount = (int)dataRow["numberCount"];
        }
    }
}
