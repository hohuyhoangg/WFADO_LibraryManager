using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class StatisticsDTO
    {
        private string memberId;
        private string firstname;
        private string lastname;
        private DateTime? borrowDate;

        public string MemberId { get => memberId; set => memberId = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime? BorrowDate { get => borrowDate; set => borrowDate = value; }
        public StatisticsDTO()
        {

        }
        public StatisticsDTO(string memberId, string firstname, string lastname, DateTime? borrowDate)
        {
            MemberId = memberId;
            Firstname = firstname;
            Lastname = lastname;
            BorrowDate = borrowDate;
        }
        public StatisticsDTO(DataRow dataRow)
        {
            MemberId = dataRow["MemberId"].ToString();
            Firstname = dataRow["Firstname"].ToString();
            Lastname = dataRow["Lastname"].ToString();
            var BorrowDateTemp = dataRow["borrowDate"];
            if (BorrowDateTemp.ToString() != "")
                this.BorrowDate = (DateTime?)BorrowDateTemp;
        }
    }
}
