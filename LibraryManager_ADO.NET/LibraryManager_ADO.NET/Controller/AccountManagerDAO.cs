using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class AccountManagerDAO
    {
        private static AccountManagerDAO instance;

        public static AccountManagerDAO Instance
        {
            get { if (instance == null) instance = new AccountManagerDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountManagerDAO() { }
        public List<AccountManagerDTO> GetListAccount()
        {
            List<AccountManagerDTO> accountManagerDTOs = new List<AccountManagerDTO>();
            string query = string.Format("SELECT PersonId, Username, Type FROM dbo.Account, dbo.AccountType " +
                "WHERE dbo.Account.AcType = dbo.AccountType.ACId");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                AccountManagerDTO accountManagerDTO = new AccountManagerDTO(item);
                accountManagerDTOs.Add(accountManagerDTO);
            }
            return accountManagerDTOs;
        }
        public bool SetPasswordAccountLibrarian(string id)
        {
            string query = string.Format("UPDATE dbo.Account SET Password = '000000' WHERE PersonId = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool SetPasswordAccountMember(string id)
        {
            string query = string.Format("UPDATE dbo.Account SET Password = '00000000' WHERE PersonId = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<AccountManagerDTO> GetAccountById(string id)
        {
            List<AccountManagerDTO> accountManagerDTOs = new List<AccountManagerDTO>();
            string query = string.Format("SELECT * FROM (SELECT PersonId,Username,Type FROM dbo.Account, dbo.AccountType " +
                "WHERE dbo.Account.AcType = dbo.AccountType.ACId) AS A WHERE A.PersonId = '{0}'", id);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                AccountManagerDTO accountManagerDTO = new AccountManagerDTO(item);
                accountManagerDTOs.Add(accountManagerDTO);
            }
            return accountManagerDTOs;
        }
        public List<AccountManagerDTO> GetListAccountByType(int acType)
        {
            List<AccountManagerDTO> accountManagerDTOs = new List<AccountManagerDTO>();
            string query = string.Format("SELECT Account.PersonId , Account.Username,A.Type FROM " +
                "(SELECT PersonId,Username,Type FROM dbo.Account, dbo.AccountType WHERE dbo.Account.AcType = dbo.AccountType.ACId) AS A," +
                "dbo.Account WHERE A.PersonId = dbo.Account.PersonId AND dbo.Account.AcType = '{0}'",acType);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                AccountManagerDTO accountManagerDTO = new AccountManagerDTO(item);
                accountManagerDTOs.Add(accountManagerDTO);
            }
            return accountManagerDTOs;
        }
    }
}
