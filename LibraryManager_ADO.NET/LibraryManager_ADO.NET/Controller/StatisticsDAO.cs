using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class StatisticsDAO
    {
        private static StatisticsDAO instance;

        public static StatisticsDAO Instance
        {
            get { if (instance == null) instance = new StatisticsDAO(); return instance; }
            private set { instance = value; }
        }
        private StatisticsDAO() { }
        public List<StatisticsDTO> GetListBookBorrow()
        {
            List<StatisticsDTO> statisticsDTOs = new List<StatisticsDTO>();
            string query = string.Format("SELECT MemberId,  FirstName,LastName, BorrowDate FROM dbo.Borrow,dbo.Member " +
                "WHERE dbo.Borrow.MemberId = dbo.Member.Id AND dbo.Borrow.Status = 0");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                StatisticsDTO statisticsDTO = new StatisticsDTO(item);
                statisticsDTOs.Add(statisticsDTO);
            }
            return statisticsDTOs;
        }
    }
}
