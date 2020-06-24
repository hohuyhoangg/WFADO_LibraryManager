using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager_ADO.NET.Models
{
    public class BookDTO
    {
        private string id;
        private string title;
        private string publisherId;
        private int yearPublisher;
        private string bookCategoryId;
        private decimal price;
        private bool status;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublisherId { get => publisherId; set => publisherId = value; }
        public int YearPublisher { get => yearPublisher; set => yearPublisher = value; }
        public string BookCategoryId { get => bookCategoryId; set => bookCategoryId = value; }
        public decimal Price { get => price; set => price = value; }
        public bool Status { get => status; set => status = value; }

        public BookDTO() { }
        public BookDTO(string id, string title, string publisherId , int yearPublisher, string bookCategoryId ,decimal price, bool status)
        {
            Id = id;
            Title = title;
            PublisherId = publisherId;
            YearPublisher = yearPublisher;
            BookCategoryId = bookCategoryId;
            Price = price;
        }
        public BookDTO(DataRow dataRow)
        {
            Id = dataRow["id"].ToString();
            Title = dataRow["title"].ToString();
            PublisherId = dataRow["publisherId"].ToString();
            var YearPublisherTemp = dataRow["yearPublisher"];
            if (YearPublisherTemp.ToString() != "")
                YearPublisher = (int)dataRow["yearPublisher"];
            BookCategoryId = dataRow["bookCategoryId"].ToString();
            var PriceTemp = dataRow["price"];
            if (PriceTemp.ToString() != "")
                this.Price = (decimal)dataRow["price"];
            Status = (bool)dataRow["status"];
        }
    }
}
