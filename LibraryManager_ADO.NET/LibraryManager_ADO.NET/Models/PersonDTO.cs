using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class PersonDTO
    {
        private string id;
        private string firstName;
        private string lastName;
        private DateTime? birthday;
        private string sex;
        private string ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private bool status;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime? Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public bool Status { get => status; set => status = value; }

        public PersonDTO() { }
        public PersonDTO(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, bool status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Sex = sex;
            Ssn = ssn;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Status = status;
        }
        public PersonDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString();
            FirstName = dataRow["firstName"].ToString();
            LastName = dataRow["lastName"].ToString();
            Birthday = (DateTime?)dataRow["Birthday"];
            Sex = dataRow["sex"].ToString();
            Ssn = dataRow["ssn"].ToString();
            Address = dataRow["address"].ToString();
            PhoneNumber = dataRow["phoneNumber"].ToString();
            Email = dataRow["email"].ToString();
            Status = (bool)dataRow["status"];
        }
    }
}
