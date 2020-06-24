using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class PublisherDTO
    {
        private string id;
        private string name;
        private string phoneNumber;
        private string address;
        private string email;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public PublisherDTO() { }
        public PublisherDTO(string id, string name, string phoneNumber, string address, string email)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }
        public PublisherDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString(); ;
            Name = dataRow["name"].ToString();
            PhoneNumber = dataRow["phoneNumber"].ToString();
            Address = dataRow["address"].ToString();
            Email = dataRow["email"].ToString();
        }
    }
}
