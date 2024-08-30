using System;

namespace NattA2_1175_002
{
    internal class Book
    {
        //create fields for the Book class
        private int bookId;
        private string bookName;
        private string bookAuthor;
        private string[] location;
        private int[] numberOfCopies;

        //default constructor
        public Book() 
        {
            
        }

        //parameterized constructor
        public Book(int bookId, string bookName, string bookAuthor, string[] location, int[] numberOfCopies) 
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.location = location;
            this.numberOfCopies = numberOfCopies;
        }

        //required properties
        public int BookId 
        { get { return bookId; } 
          set { bookId = value; } 
        }
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
        public string[] Location
        { get { return location; } 
          set { location = value; } 
        }
        public int[] NumberOfCopies 
        { 
            get { return numberOfCopies; } 
            set { numberOfCopies = value; } 
        }
        //ToString() method
        public override string ToString()
        {
            string output = $"Book Id: {BookId} name: {BookName} Author: {BookAuthor}\nLocation\t\tNumber of Books available\n";
            int totalCopies = 0;
            int maxCopies = 0;
            string maxLocation = "";
            for (int i = 0; i < Location.Length; i++)
            {
                output += $"{Location[i],-24}{NumberOfCopies[i]}\n";
                totalCopies += NumberOfCopies[i];
                if (NumberOfCopies[i] > maxCopies)
                {
                    maxCopies = NumberOfCopies[i];
                    maxLocation = Location[i];
                }
            }
            output += $"\n{totalCopies} are the total number of copies\n{maxLocation} has the maximum number of copies\n";
            return output;
        }

    }
}