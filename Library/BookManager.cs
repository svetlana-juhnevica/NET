using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookManager
    {
        SqlConnection _conn;
        public BookManager()
        {
            _conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ur777\OneDrive\Документы\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30");
            _conn.Open();

        }
        public void TakeBook(string title)
        {
            string query = String.Format("UPDATE Books SET Copies = Copies - 1 WHERE LOWER (Title) = '{0}'", title.ToLower());
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public void ReturnBook(string title)
        {
            string query = String.Format("UPDATE Books SET Copies = Copies + 1 WHERE LOWER (Title) = '{0}'", title.ToLower());
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public void RemoveUserBook(string title)
        {
            string query = String.Format("DELETE TOP (1) FROM UserBook WHERE LOWER (Title) = '{0}'", title.ToLower());
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public void GiveUserBook(string title)
        {
            string query = String.Format("INSERT INTO UserBooks(Title) VALUES ('{0}')", title);
            SqlCommand command = new SqlCommand(query, _conn);
            command.ExecuteNonQuery();
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            string query = "SELECT * FROM Books ORDER BY Title ASC";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book()
                {
                    Copies = Convert.ToInt32(reader["Copies"]),
                    Year = Convert.ToInt32(reader["Year"]),
                    Title = Convert.ToString(reader["Title"]),
                });
            }
            reader.Close();
            return books;
        }
        public List<Book> GetAlUserlBooks()
        {
            List<Book> books = new List<Book>();
            string query = "SELECT * FROM UserBooks ORDER BY Title ASC";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book()
                {
                    
                 
                    Title = Convert.ToString(reader["Title"]),
                });
            }
            reader.Close();
            return books;
        }
        public Book GetBook(string title)
        {
            Book result = null;
             string query = String.Format("SELECT * FROM Books WHERE LOWER (Title) = '{0}'", title.ToLower());
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataReader reader = command.ExecuteReader();
            //tikai ja bija ieraksts
            if (reader.Read())
            {
                result = new Book()
                {
                    Copies = Convert.ToInt32(reader["Copies"]),
                    Year = Convert.ToInt32(reader["Year"]),
                    Title = Convert.ToString(reader["Title"]),
                };
            }
            reader.Close();
            return result;
        }
        public Book GetUserBook (string title)
        {
            Book result = null;
            string query = String.Format("SELECT TOP 1 * FROM UserBooks WHERE LOWER (Title) = '{0}'", title.ToLower());
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataReader reader = command.ExecuteReader();
            //tikai ja bija ieraksts
            if (reader.Read())
            {
                result = new Book()
                {
                    
                    Title = Convert.ToString(reader["Title"]),
                };
            }
            reader.Close();
            return result;
        }
        }
    }
    

