using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class LibrarianDTO : PersonDTO
    {
        private DateTime? startDate;
        private decimal salary;

        public DateTime? StartDate { get => startDate; set => startDate = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public LibrarianDTO() : base() { }
        public LibrarianDTO(string id, string firstName, string lastName, DateTime? birthday, string sex, string ssn, string address,
            string phoneNumber, string email, DateTime? startDate, decimal salary, bool status) : base(id, firstName, lastName, birthday, sex, ssn, address,
            phoneNumber, email, status)
        {
            StartDate = startDate;
            Salary = salary;
        }
        public LibrarianDTO(DataRow dataRow)
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
            //StartDate = (DateTime?)dataRow["StartDate"];
            var StartDateTemp = dataRow["StartDate"];
            if (BirthdayTemp.ToString() != "")
                this.StartDate = (DateTime?)StartDateTemp;
            var SalaryTemp = dataRow["salary"];
            if (SalaryTemp.ToString() != "")
                this.Salary = (decimal)dataRow["salary"];
            Status = (bool)dataRow["status"];
        }
    }
}
