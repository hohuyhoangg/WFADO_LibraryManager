using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    class MemberDAO
    {
        private static MemberDAO instance;

        public static MemberDAO Instance
        {
            get { if (instance == null) instance = new MemberDAO(); return instance; }
            private set { instance = value; }
        }
        public MemberDAO() { }
        public List<MemberDTO> GetListMember()
        {
            List<MemberDTO> memberDTOs = new List<MemberDTO>();
            string query = string.Format("SELECT * FROM dbo.Member");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                MemberDTO memberDTO = new MemberDTO(item);
                memberDTOs.Add(memberDTO);
            }
            return memberDTOs;
        }
        public List<MemberDTO> GetListMemberStatusTrue()
        {
            List<MemberDTO> memberDTOs = new List<MemberDTO>();
            string query = string.Format("SELECT * FROM dbo.Member WHERE Status = 1");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                MemberDTO memberDTO = new MemberDTO(item);
                memberDTOs.Add(memberDTO);
            }
            return memberDTOs;
        }
        public List<MemberDTO> GetListMemberStatusFalse()
        {
            List<MemberDTO> memberDTOs = new List<MemberDTO>();
            string query = string.Format("SELECT * FROM dbo.Member WHERE Status = 0");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                MemberDTO memberDTO = new MemberDTO(item);
                memberDTOs.Add(memberDTO);
            }
            return memberDTOs;
        }
        public List<MemberDTO> GetListMemberByYear(int year)
        {
            List<MemberDTO> memberDTOs = new List<MemberDTO>();
            string query = string.Format("SELECT * FROM dbo.Member WHERE YEAR(Birthday) = {0}", year);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                MemberDTO memberDTO = new MemberDTO(item);
                memberDTOs.Add(memberDTO);
            }
            return memberDTOs;
        }
        public bool AddMember(string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? registerDate)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string registerDateTemp = Convert.ToDateTime(registerDate).ToString("yyyyMMdd");
            string query = string.Format("INSERT INTO dbo.Member (Id,FirstName,LastName,Birthday, Sex,SSN,Address,PhoneNumber," +
                "Email,RegisterDate, Status) VALUES('', N'{0}', N'{1}','{2}',N'{3}', '{4}', N'{5}','{6}', N'{7}',GETDATE(), 1)",
                firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, registerDateTemp);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMember(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? registerDate)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string registerDateTemp = Convert.ToDateTime(registerDate).ToString("yyyyMMdd");
            string query = string.Format("UPDATE dbo.Member SET FirstName = N'{0}', LastName = N'{1}', Birthday = '{2}', " +
                "Sex = N'{3}',SSN = '{4}', Address = N'{5}', PhoneNumber = '{6}', Email = N'{7}', RegisterDate = '{8}', Status = 1 " +
                "WHERE Id = '{9}'", firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, registerDateTemp, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStatusFalse(string id)
        {
            string query = string.Format("UPDATE dbo.Member SET Status = 0 WHERE Id = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public MemberDTO GetMembertById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.Member WHERE Id = '{0}'",id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new MemberDTO(item);

            }
            return null;
        }
        public bool UpdateMemberToMe(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email)
        {
            string birthDayTemp = Convert.ToDateTime(birthday).ToString("yyyyMMdd");
            string query = string.Format("UPDATE dbo.Member SET FirstName = N'{0}', LastName = N'{1}', Birthday = '{2}', " +
                "Sex = N'{3}',SSN = '{4}', Address = N'{5}', PhoneNumber = '{6}', Email = N'{7}', Status = 1 " +
                "WHERE Id = '{8}'", firstName, lastName, birthDayTemp, sex, ssn, address, phoneNumber, email, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
