using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyBooks
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Book>();

                var listOfBooks = conn.Table<Book>().ToList();
                booksListView.ItemsSource = listOfBooks;
                //booksListView.BindingContext//
            }
        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NewBookPage());
        }
    }
}
