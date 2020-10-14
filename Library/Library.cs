using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private BookManager _manager;

        public Library()
        {
            _manager = new BookManager();
        }
        public void List()
        {
            var books = _manager.GetAllBooks();
            //ja saraksts "Books" ir tukšs-> izvada attiecigo pazinojumu
            if (books.Count == 0 || books.All(b => b.Copies == 0))
            {
                Console.WriteLine("No books available");
            }
            //citādi, izmantojot foreach() izvada pieejamo grāmatu sarakstu
            else
            {
                Console.WriteLine("Available books: ");
                foreach (var b in books)
                {
                    Console.WriteLine("{0} - {1} ({2})", b.Title, b.Year, b.Copies);
                }
            }
        }
        public void MyList()
        {
            var userBooks = _manager.GetAllUserBooks();
            // ja sraraksts "UserBooks" ir tukšs -> izvada attiecīgo paziņojumu
            if (userBooks.Count == 0)
            {
                Console.WriteLine("You haven't taken any books");
            }
            //2.Citādi, izmantojot foreach() izvada lietotāja grāmatu sarakstu
            else
            {
                Console.WriteLine("Your books: ");
                foreach (var b in userBooks)
                {
                    Console.WriteLine("{0}", b.Title);
                }
            }
        }
        public void Give()
        {
            //1. Vaicā grāmatas nosaukumu
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine().ToLower();
            //2. Pārbauda, vai grāmata ir lietotāja sarakstā
            Book userBook = _manager.GetUserBook(title);
            if (userBook == null)
            {
                Console.WriteLine("You don't have this book!");
            }
            else
            {
                //3. Izņem attiecīgo  gtāmatu no UserBooks
                _manager.RemoveUserBook(title);
                //4. Atrod grāmatu Books sarakstā un palielina eksemplāru skaitu
                _manager.ReturnBook(title);
            }
        }
        public void Take()
        {
            //1. Vaicā gramatas nosaukumu
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine().ToLower();
            //2. Pārbauda, vai grāmata ir bibliotēkas  sarakstā
            Book book = _manager.GetBook(title);
            if (book == null)
            {
                Console.WriteLine("This book is not in our library!");
            }
            else
            {
                //3.Pārbauda, vai grāmata ir pieejama - vai skaits >0
                if (book
                    .Copies == 0)
                {
                    Console.WriteLine("This book is not available!");
                }
                else
                {
                    //4. Grāmatai sarakstā Books, samazina pieejamo eksemplāru skaitu
                    _manager.TakeBook(title);
                    //5.Konkrēto grāmatu pieviemo UserBooks.
                    _manager.GiveUserBook(title);
                }
            }
        }
    }
}
