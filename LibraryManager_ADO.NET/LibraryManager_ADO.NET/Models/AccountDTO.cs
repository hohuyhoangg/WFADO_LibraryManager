using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class AccountDTO
    {
        private string personId;
        private string username;
        private string password;
        private int acType;

        public string PersonId { get => personId; set => personId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int AcType { get => acType; set => acType = value; }

        public AccountDTO()
        {

        }
        public AccountDTO(string personId, string username, string password, int acType)
        {
            PersonId = personId;
            Username = username;
            Password = password;
            AcType = acType;
        }
        public AccountDTO(DataRow dataRow)
        {
            PersonId = dataRow["personId"].ToString();
            Username = dataRow["Username"].ToString();
            Password = dataRow["Password"].ToString();
            AcType = (int)dataRow["AcType"];
        }
    }
}
