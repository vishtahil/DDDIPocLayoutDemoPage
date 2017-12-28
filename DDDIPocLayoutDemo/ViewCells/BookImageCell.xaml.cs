using System;
using System.Collections.Generic;

using Xamarin.Forms;
using DDDIPocLayoutDemo.ViewModels;
using System.Linq;

namespace DDDIPocLayoutDemo.ViewCells
{
    /// <summary>
    /// Book image cell.
    /// </summary>
    public partial class BookImageCell : ViewCell
    {
        void Handle_BindingContextChanged(object sender, System.EventArgs e)
        {
            var itm = BindingContext as BookImageViewModel;
            if (itm != null && (_lastItem == null || itm != _lastItem))
            {
                _lastItem = itm;
                var imageSource = ImageSource.FromResource("DDDIPocLayoutDemo.Images.Book-icon.png");
                RenderBookList(itm.Books);
            }
        }

        private static BookImageViewModel _lastItem;
        void Handle_SizeChanged(object sender, System.EventArgs e)
        {
            if (this.Height < bookListView.Height)
            {
                this.Height = bookListView.Height;
                this.ForceUpdateSize();
            }
           
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DDDIPocLayoutDemo.ViewCells.BookImageCell"/> class.
        /// </summary>
        public BookImageCell()
        {
            InitializeComponent();
        }

       

       

        /// <summary>
        /// Renders the book list.
        /// </summary>
        public void RenderBookList(List<BookViewModel> bookImages)
        {
            var imageSource = ImageSource.FromResource("DDDIPocLayoutDemo.Images.Book-icon.png");
            foreach(var bookItem in bookImages)
            {
                bookListView.Children.Add(CreateBookView(imageSource,bookItem));
            }
        }

        /// <summary>
        /// Creates the book view.
        /// </summary>
        /// <returns>The book view.</returns>
        /// <param name="source">Source.</param>
        /// <param name="book">Book.</param>
        private StackLayout CreateBookView(ImageSource source, BookViewModel bookItem)
        {
            var stackLayout = new StackLayout();
            var absoluteLayout = new AbsoluteLayout();
            stackLayout.Children.Add(absoluteLayout);
            var img = new Image();
            img.Source = source;
            absoluteLayout.Children.Add(img,
                                        new Rectangle(0, 1, -1, -1), AbsoluteLayoutFlags.PositionProportional);
            var priceLabel = new Label()
            {
                Text = bookItem.Price.ToString(),
                TextColor = Color.Yellow,
                Margin = new Thickness(10, 0, 0, 0),
                FontSize = 19,
            };

            absoluteLayout.Children.Add(priceLabel,
                                        new Rectangle(0, 0.95, -1, -1), AbsoluteLayoutFlags.PositionProportional);

            var bookLabel = new Label()
            {
                Text = bookItem.BookName,
                TextColor = Color.White,
                Margin = new Thickness(10, 0, 0, 0),
                FontSize = 12,
                FontAttributes = FontAttributes.Bold
            };

            absoluteLayout.Children.Add(bookLabel,
                                        new Rectangle(0, 0.65, -1, -1), AbsoluteLayoutFlags.PositionProportional);

            return stackLayout;
        }
    }
}
