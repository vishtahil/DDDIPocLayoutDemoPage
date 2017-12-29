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
        public string GroupName
        {
            get;
            set;
        }
        public string Price { get; set; }
        public string BookName { get; set; }
    }
}
