using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    class Book
    {
        int isbn;
        int stock;
        string title;
        double price;

       List<Author> authors = new List<Author>();
        List<Chapter> chapters = new List<Chapter>();

        public int Isbn { get => isbn; set => isbn = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Title { get => title; set => title = value; }
        public double Peice { get => price; set => price = value; }
        internal List<Author> Authors { get => authors; set => authors = value; }
        internal List<Chapter> Chapters { get => chapters; set => chapters = value; }

        public Book(int isbn, string title, double price)
        {
            this.isbn = isbn;
            this.title = title;
            this.price = price;
            stock = 0;
        }

        public void AddStock(int quantity)
        {
            stock += quantity; //stock = stock + quantity
        }

        public string Purchase(int quantity)
        {
            double totalPrice = 0;
            if(stock >= quantity)
            {
                totalPrice = quantity * price;
                stock -= quantity;
                return "The total price for your purchase is " + totalPrice;
            }

            else if (stock > 0)
            {
                return "There are only " + stock + "books left in stock. Do you want to" +
                    "purchase the remaing stock or cancel?";
            }

            else
            {
                return "The book is out of stock.";
            }
        }

        public void AddAuthor(Author author)
        {
            //Since the author is not created withit the book instance,
            //there is an AGGREGATION relationship between Book and Author
            authors.Add(author);
        }

        public void AddChaper(string chapterTitle)
        {
            //compostiton relationship 
            Chapter newchapter = new Chapter(chapterTitle, (chapters.Count + 1));
            chapters.Add(newchapter);

        }
    }
}

