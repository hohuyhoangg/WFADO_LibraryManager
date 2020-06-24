using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class LibrarianDAO
    {
        private static LibrarianDAO instance;

        public static LibrarianDAO Instance
        {
            get { if (instance == null) instance = new LibrarianDAO(); return instance; }
            private set { instance = value; }
        }
        public LibrarianDAO() { }

        public LibrarianDTO GetLibrarianById(string Id)
        {
            string query = string.Format("SELECT * FROM dbo.Librarian WHERE Id='{0}'", Id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new LibrarianDTO(item);

            }
            return null;
        }
        public List<LibrarianDTO> GetListLibrarian()
        {
            List<LibrarianDTO> librarianDTOs = new List<LibrarianDTO>();
            string query = string.Format("SELECT * FROM dbo.Librarian");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                LibrarianDTO librarianDTO = new LibrarianDTO(item);
                librarianDTOs.Add(librarianDTO);
            }
            return librarianDTOs;
        }
        public List<LibrarianDTO> GetListLibrarianStatusTrue()
        {
            List<LibrarianDTO> librarianDTOs = new List<LibrarianDTO>();
            string query = string.Format("SELECT * FROM dbo.Librarian WHERE Status = 1");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                LibrarianDTO librarianDTO = new LibrarianDTO(item);
                librarianDTOs.Add(librarianDTO);
            }
            return librarianDTOs;
        }
        public List<LibrarianDTO> GetListLibrarianStatusFalse()
        {
            List<LibrarianDTO> librarianDTOs = new List<LibrarianDTO>();
            string query = string.Format("SELECT * FROM dbo.Librarian WHERE Status = 0");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                LibrarianDTO librarianDTO = new LibrarianDTO(item);
                librarianDTOs.Add(librarianDTO);
            }
            return librarianDTOs;
        }
        public bool UpdateLibrarian(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? startDate, decimal salary)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string startDateTemp = Convert.ToDateTime(startDate).ToString("yyyyMMdd");
            string query = string.Format("UPDATE dbo.Librarian SET FirstName = N'{0}', LastName = N'{1}', Birthday = '{2}', " +
                "Sex = N'{3}',SSN = '{4}', Address = N'{5}', PhoneNumber = '{6}', Email = N'{7}', StartDate = '{8}', Salary = {9} " +
                "WHERE Id = '{10}'", firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, startDateTemp, salary, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool AddLibrarian(string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? startDate, decimal salary)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string startDateTemp = Convert.ToDateTime(startDate).ToString("yyyyMMdd");
            string query = string.Format("INSERT INTO dbo.Librarian (Id,FirstName,LastName,Birthday, Sex,SSN,Address,PhoneNumber," +
                "Email,StartDate,Salary, Status) VALUES('', N'{0}', N'{1}','{2}',N'{3}', '{4}', N'{5}','{6}', N'{7}','{8}',{9}, 1)", 
                firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, startDateTemp, salary);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStatusFalse(string id)
        {
            string query = string.Format("UPDATE dbo.Librarian SET Status = 0 WHERE Id = '{0}'",id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStatusTrue(string id)
        {
            string query = string.Format("UPDATE dbo.Librarian SET Status = 1 WHERE Id = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateLibrarianToMe(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string query = string.Format("UPDATE dbo.Librarian SET FirstName = N'{0}', LastName = N'{1}', Birthday = '{2}', " +
                "Sex = N'{3}',SSN = '{4}', Address = N'{5}', PhoneNumber = '{6}', Email = N'{7}'" +
                "WHERE Id = '{8}'", firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
