using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class BookShowDTO
    {
        private string id;
        private string title;
        private string bookCategory;
        private string author;
        private string publisher;
        private int yearPublisher;
        private decimal price;
        private int numberCount;
        private bool status;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string BookCategory { get => bookCategory; set => bookCategory = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int YearPublisher { get => yearPublisher; set => yearPublisher = value; }
        public decimal Price { get => price; set => price = value; }
        public bool Status { get => status; set => status = value; }
        public int NumberCount { get => numberCount; set => numberCount = value; }

        public BookShowDTO() { }
        public BookShowDTO(string id, string title, string bookCategory, string author, string publisher, int yearPublisher, decimal price,
            int numberCount, bool status)
        {
            Id = id;
            Title = title;
            BookCategory = bookCategory;
            Author = author;
            Publisher = publisher;
            YearPublisher = yearPublisher;
            Price = price;
            NumberCount = numberCount;
            Status = status;
        }
        public BookShowDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString();
            Title = dataRow["title"].ToString();
            BookCategory = dataRow["Name"].ToString();
            Author = dataRow["author"].ToString();
            Publisher = dataRow["publisher"].ToString();
            YearPublisher = (int)dataRow["yearPublisher"];
            var PriceTemp = dataRow["price"];
            if (PriceTemp.ToString() != "")
                this.Price = (decimal)dataRow["price"];
            NumberCount = (int)dataRow["numberCount"];
            Status = (bool)dataRow["status"];
        }
    }
}
