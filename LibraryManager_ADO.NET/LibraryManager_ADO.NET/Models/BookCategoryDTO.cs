using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class BookCategoryDTO
    {
        private string id;
        private string name;
        private int limitDays;
        private bool status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int LimitDays { get => limitDays; set => limitDays = value; }
        public bool Status { get => status; set => status = value; }
        public BookCategoryDTO() { }
        public BookCategoryDTO(string id, string name, int limitDays, bool status)
        {
            Id = id;
            Name = name;
            LimitDays = limitDays;
            Status = status;
        }
        public BookCategoryDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString();
            Name = dataRow["name"].ToString();
            LimitDays = (int)dataRow["limitDays"];
            Status = (bool)dataRow["status"];
        }
    }
}
