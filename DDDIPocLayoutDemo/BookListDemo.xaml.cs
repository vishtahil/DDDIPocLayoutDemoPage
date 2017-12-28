using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Xamarin.Forms;
using DDDIPocLayoutDemo.ViewModels;
using Xamarin.Forms.Internals;

namespace DDDIPocLayoutDemo
{
    
    public partial class BookListDemo : ContentPage
    {
        private Random random = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DDDIPocLayoutDemo.BookListDemo"/> class.
        /// </summary>
        public BookListDemo()
        {
            InitializeComponent();
            listView.ItemsSource = GetGroupedItems();
        }

        /// <summary>
        /// Gets the grouped items.
        /// </summary>
        /// <returns>The grouped items.</returns>
        public List<BookTypeGroupViewModel> GetGroupedItems(){
            var groups = new string[] {"Music","Adventure","Animation" };
            var bookGroups = new List<BookTypeGroupViewModel> ();
            groups.ForEach(x=> bookGroups.Add(new BookTypeGroupViewModel(x, x[0].ToString())));

            foreach(var bookGroup in bookGroups){
                var bookImageModel = new BookImageViewModel();
                bookGroup.Add(bookImageModel);
                bookImageModel.Books = GetItems(bookGroup.GroupName);
            }
            return bookGroups;
                           
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <returns>The items.</returns>
        /// <param name="groupName">Group name.</param>
        public List<BookViewModel> GetItems(string groupName)
        {
            var items = new List<BookViewModel>();
          
            for (int i = 1; i < 6; i++)
            {
                items.Add(new BookViewModel()
                {
                    Price = i,
                    BookName = $"{groupName} Book {i}"
                });
            }


            return items;
        }


    }
}
