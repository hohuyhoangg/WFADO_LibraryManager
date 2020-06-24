using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class AccountTypeDTO
    {
        private int acId;
        private string type;
        public int AcId { get => acId; set => acId = value; }
        public string Type { get => type; set => type = value; }
        public AccountTypeDTO() { }
        public AccountTypeDTO(int acId, string type)
        {
            AcId = acId;
            Type = type;
        }
        public AccountTypeDTO(DataRow dataRow)
        {
            AcId = (int)dataRow["AcId"];
            Type = dataRow["Type"].ToString();
        }
    }
}
