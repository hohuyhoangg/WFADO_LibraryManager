using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM dbo.Account WHERE Username = '{0}' AND Password = '{1}'", username, password);
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
        public AccountDTO GetAccountByUsername(string username)
        {
            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + username + "'");
            foreach (DataRow item in dataTable.Rows)
            {
                return new AccountDTO(item);

            }
            return null;
        }
        public AccountDTO GetAccountById(string id)
        {
            string query = string.Format("SELECT * FROM dbo.Account WHERE PersonId = '{0}'",id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new AccountDTO(item);

            }
            return null;
        }
        public bool UpdateAdmin(string id)
        {
            string query = string.Format("UPDATE dbo.Account SET AcType = 1 WHERE PersonId = '{0}'",id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePass(string username, string  newpass)
        {
            string query = string.Format("UPDATE dbo.Account SET Password = '{0}' WHERE Username = '{1}'",newpass,username);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
