using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_1_
{
    class Library
    {
        private string libName;
        private string libAddress;
        private Book[] listOfBook;
        private int totalBook;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {
            libName = "AIUB library";
            libAddress = "kuratoli,AIUB";
            listOfBook = new Book[100];

        }
        public Library(string libName, string libAddress, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
        }


    }
}
