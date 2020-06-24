using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class BorrowDTO
    {
        private int id;
        private string bookId;
        private string memberId;
        private DateTime? borrowDate;
        private bool status;

        public int Id { get => id; set => id = value; }
        public string BookId { get => bookId; set => bookId = value; }
        public string MemberId { get => memberId; set => memberId = value; }
        public DateTime? BorrowDate { get => borrowDate; set => borrowDate = value; }
        public bool Status { get => status; set => status = value; }
        public BorrowDTO() { }
        public BorrowDTO(int id, string bookId, string memberId, DateTime? borrowDate,  bool status)
        {
            Id = id;
            BookId = bookId;
            MemberId = memberId;
            BorrowDate = borrowDate;
            Status = status;
        }
        public BorrowDTO(DataRow dataRow)
        {
            Id = (int)dataRow["id"];
            BookId = dataRow["BookId"].ToString();
            MemberId = dataRow["MemberId"].ToString();
            var BorrowDateTemp = dataRow["BorrowDate"];
            if (BorrowDateTemp.ToString() != "")
                this.BorrowDate = (DateTime?)BorrowDateTemp;
            Status = (bool)dataRow["status"];
        }
    }
}
