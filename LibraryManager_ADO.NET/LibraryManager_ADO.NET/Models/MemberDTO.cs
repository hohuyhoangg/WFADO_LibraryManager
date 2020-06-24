using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class MemberDTO : PersonDTO
    {
        private DateTime? registerDate;

        public DateTime? RegisterDate { get => registerDate; set => registerDate = value; }
        public MemberDTO() : base() { }
        public MemberDTO(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? registerDate, bool status) : base(id, firstName, lastName, birthday, sex, ssn, address,
            phoneNumber, email, status)
        {
            RegisterDate = registerDate;
        }
        public MemberDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString();
            FirstName = dataRow["firstName"].ToString();
            LastName = dataRow["lastName"].ToString();
            var BirthdayTemp = dataRow["Birthday"];
            if (BirthdayTemp.ToString() != "")
                this.Birthday = (DateTime?)BirthdayTemp;
            Sex = dataRow["sex"].ToString();
            Ssn = dataRow["ssn"].ToString();
            Address = dataRow["address"].ToString();
            PhoneNumber = dataRow["phoneNumber"].ToString();
            Email = dataRow["email"].ToString();
            var RegisterDateTemp = dataRow["RegisterDate"];
            if (RegisterDateTemp.ToString() != "")
                this.RegisterDate = (DateTime?)RegisterDateTemp;
            Status = (bool)dataRow["status"];
        }
    }
}
