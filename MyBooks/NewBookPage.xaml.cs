using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyBooks
{
    public partial class NewBookPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Book bk = new Book() {
                Name = bookName.Text,
                Author = authorName.Text
            };
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH)) {
                conn.CreateTable<Book>();
                var numberOfRows = conn.Insert(bk);
                if(numberOfRows > 0)
                {
                    DisplayAlert("Success!", "Book successfully inserted.", "Great!");
                }
                else
                {
                    DisplayAlert("Success!", "Book failed to be inserted.", "Dang it!");
                }
            }

        }

        public NewBookPage()
        {
            InitializeComponent();
        }
    }
}
