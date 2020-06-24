using LibraryManager_ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Controller
{
    public class PublisherDAO
    {
        private static PublisherDAO instance;

        public static PublisherDAO Instance
        {
            get { if (instance == null) instance = new PublisherDAO(); return instance; }
            private set { instance = value; }
        }
        public PublisherDAO() { }
        public List<PublisherDTO> GetListPublisher()
        {
            List<PublisherDTO> publisherDTOs = new List<PublisherDTO>();
            string query = string.Format("SELECT * FROM dbo.Publisher");
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                PublisherDTO publisherDTO = new PublisherDTO(item);
                publisherDTOs.Add(publisherDTO);
            }
            return publisherDTOs;
        }
        public bool AddPublisher(string id , string name, string phoneNumber, string address, string email)
        { 
            string query = string.Format("INSERT INTO dbo.Publisher (Id,Name,PhoneNumber,Address,Email) " +
                "VALUES('{0}', N'{1}','{2}',N'{3}',N'{4}')",id,name,phoneNumber,address,email);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePublisher(string id,string name, string phoneNumber, string address, string email)
        {
            string query = string.Format("UPDATE dbo.Publisher SET Name = N'{0}', PhoneNumber = '{1}' , Address = N'{2}',Email = N'{3}' WHERE Id = '{4}'", 
                name, phoneNumber, address, email,id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<PublisherDTO> SearchPublisherByName(string name)
        {
            List<PublisherDTO> publisherDTOs = new List<PublisherDTO>();
            string query = string.Format("SELECT * FROM dbo.Publisher WHERE dbo.fuConvertToUnsign1(name) " +
                "LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'",name);
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                PublisherDTO publisherDTO = new PublisherDTO(item);
                publisherDTOs.Add(publisherDTO);
            }
            return publisherDTOs;
        }
    }
}
