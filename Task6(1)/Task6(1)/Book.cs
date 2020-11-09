using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1_
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            bookName = "shonchita";
            bookAuthor = "Kazi Nazrul Islam";
            bookId = "112";
            bookType = "poem book";
            bookCopy = 50;
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void AddBookCopy(int bc)
        {
            bookCopy += bc;
        }
    }
}
