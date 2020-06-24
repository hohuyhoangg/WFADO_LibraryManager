using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO instance;

        public static AccountTypeDAO Instance
        {
            get { if (instance == null) instance = new AccountTypeDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountTypeDAO() { }
        public List<AccountTypeDTO> GetListAccountType()
        {
            List<AccountTypeDTO> accountTypeDTOs = new List<AccountTypeDTO>();
            string query = string.Format("SELECT * FROM dbo.AccountType");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                AccountTypeDTO accountTypeDTO = new AccountTypeDTO(item);
                accountTypeDTOs.Add(accountTypeDTO);
            }
            return accountTypeDTOs;
        }
    }
}
