using System;

namespace NattA2_1175_002
{
    internal class LibraryApp
    {
        static void Main(string[] args)
        {
            //create an array of the Book class that acts as a database of any number of books up to 30
            Book[] books = new Book[30];
            //create variable to receive the input that the user choose from the options from the menu
            string choice = "";
            //create variable to count the number of books
            int bookCount = 0;

            //use do while to display the menu while choice does not equal to "e" using ToLower() to avoid case sensitivity
            do
            {
                Console.WriteLine("\n..................Library Database....................\n");
                Console.WriteLine("Please select an option from the given menu:\n");
                Console.WriteLine("\tAdd a book to the database...........enter 'A'");
                Console.WriteLine("\tSearch a book in the database........enter 'S'");
                Console.WriteLine("\tDisplay all books in the database....enter 'D'");
                Console.WriteLine("\tExit.....enter 'E'");
                Console.Write("Enter your choice here: ");
                choice = Console.ReadLine().ToLower();

                //If a user selects to add a book
                if (choice == "a")
                {
                    //ask the user for a book id
                    int bookId;
                    Console.Write("Enter book id: ");
                    bookId = int.Parse(Console.ReadLine());

                    //check if the database is full (a database can store the number of the books up to 30)
                    if (bookCount >= 30)
                    {
                        Console.WriteLine("Sorry - the array is full -- cannot add a record");
                    }
                    else
                    {
                        //check if the book id already exists in the database
                        bool exist = false;
                        for (int i = 0; i < books.Length; i++)
                        {
                            if (books[i] != null && books[i].BookId == bookId)
                            {
                                Console.WriteLine("Sorry-- book already exists");
                                exist = true;
                            }
                        }
                        //if the book id does not exist in the database, app allows user to input new book
                        if (exist == false)
                        {
                            Console.Write("Enter book name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Enter book author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter the location and number of copies for four locations");
                            string[] location = new string[4];
                            int[] numberOfCopies = new int[4];

                            for (int i = 0; i < location.Length; i++)
                            {
                                Console.Write($"Enter location {i + 1}: ");
                                location[i] = Console.ReadLine();
                                Console.Write("Enter the number of copies: ");
                                numberOfCopies[i] = int.Parse(Console.ReadLine());
                            }
                            Book book = new Book(bookId, bookName, bookAuthor, location, numberOfCopies);
                            books[bookCount] = book;
                            bookCount++;
                            Console.WriteLine("A new book is added");
                            Console.WriteLine($"The number of books are {bookCount}");
                        }
                    }
                }
                else if (choice == "s") //user selects to search 
                {
                    //display a message if the database is empty
                    if (bookCount == 0)
                    {
                        Console.WriteLine("The array is empty");
                    }
                    else //search by book id
                    {
                        Console.Write("Enter book Id to search: ");
                        int bookId = int.Parse(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < books.Length; i++)
                        {
                            if (books[i] != null && books[i].BookId == bookId)
                            {
                                found = true;
                                Console.WriteLine("Found the record");
                                Console.WriteLine(books[i]);
                                break;
                            }
                        }
                        //if the book id does not exist in the database
                        if (found == false)
                        {
                            Console.WriteLine("Book not found");
                        }
                    }
                }
                else if (choice == "d")//user selects to display
                {
                    //display a message if the database is empty
                    if (bookCount == 0)
                    {
                        Console.WriteLine("The array is empty");
                    }
                    else //display book information
                    {
                        for (int i = 0; i < books.Length; i++)
                        {
                            if (books[i] != null)
                            {
                                Console.WriteLine(books[i]);
                            }
                        }
                    }
                }
                else if (choice == "e") //user selects to exit program
                {
                    Console.WriteLine("Goodbye!!");
                }
                else //in case that the user selects other options not available
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            while (choice != "e"); //display menu until the user selects to exit program

            Console.ReadKey();
        }
    }
}