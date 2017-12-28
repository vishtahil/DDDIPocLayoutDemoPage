using System;
using System.Collections.Generic;
namespace DDDIPocLayoutDemo.ViewModels
{
    public class BookImageViewModel
    {
        public BookImageViewModel()
        {
            
        }
       
        public List<BookViewModel> Books
        {
            get;
            set;
        }
    }

    public class BookViewModel{
        public double Price { get; set; }
        public string BookName { get; set; }
    }
}
