using System;
using SQLite;

namespace MyBooks
{
    public class Book
    {
        public Book()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

    }
}
