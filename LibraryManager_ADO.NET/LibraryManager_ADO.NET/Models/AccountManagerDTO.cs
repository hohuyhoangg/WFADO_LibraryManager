using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class AccountManagerDTO
    {
        private string personId;
        private string username;
        private string type;

        public string PersonId { get => personId; set => personId = value; }
        public string Username { get => username; set => username = value; }
        public string Type { get => type; set => type = value; }
        public AccountManagerDTO()
        {

        }
        public AccountManagerDTO(string personId, string username, string type)
        {
            PersonId = personId;
            Username = username;
            Type = type;
        }
        public AccountManagerDTO(DataRow dataRow)
        {
            PersonId = dataRow["personId"].ToString();
            Username = dataRow["Username"].ToString();
            Type = dataRow["type"].ToString();
        }
    }
}
