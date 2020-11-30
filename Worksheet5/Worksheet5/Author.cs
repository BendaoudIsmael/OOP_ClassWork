using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    class Author : Person
    {
        int registrationNumber;

        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

        public Author(string name, string surname, int id, int registrationNumber):
            base(id, name, surname)
        {
            this.registrationNumber = registrationNumber;
        }

        public string PublishBook(Book bookToPublish)
        {
            string listOfAuthors = "";
            int authorCountr = 1;

            foreach (Author author in bookToPublish.Authors)
            {
                listOfAuthors += "Author " + authorCountr + "Name: " + author.Name + " Surname: ";
            }

            return "Book published\nTitle: " + bookToPublish.Title + "\nISBN: "
                + bookToPublish.Isbn + "\nChapters: " + 
                bookToPublish.Chapters.Count
        }
    }
}
