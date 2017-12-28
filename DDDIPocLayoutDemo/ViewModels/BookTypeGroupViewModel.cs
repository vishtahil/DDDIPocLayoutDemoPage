using System;
using Xamarin.Forms;
using System.Collections.Generic;
namespace DDDIPocLayoutDemo.ViewModels
{
    /// <summary>
    /// Book type group view model.
    /// </summary>
    public class BookTypeGroupViewModel:List<BookImageViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DDDIPocLayoutDemo.ViewModels.BookTypeGroupViewModel"/> class.
        /// </summary>
        /// <param name="groupName">Group name.</param>
        /// <param name="groupShortName">Group short name.</param>
        public BookTypeGroupViewModel(string groupName,string groupShortName)
        {
            this.GroupName = groupName;
            this.GroupShortName = groupShortName;
        }

        public string GroupName
        {
            get;
            set;
        }

        public string GroupShortName
        {
            get;
            set;
        }
    }
}
