using Xamvvm;

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DDDIPocLayoutDemo.ViewModels
{
    public class BookGalaryPageModel : BasePageModel
    {
        public void ReloadData()
        {
            var list = new ObservableCollection<ItemModel>();

            SetItems(list,"Music",4);
            SetItems(list,"Animation",3);
            SetItems(list,"Adventure",5);

            var sorted = list
                .OrderBy(item => item.Price)
                .GroupBy(item => item.GroupName)
                .Select(itemGroup => new Grouping<string, ItemModel>(itemGroup.Key, itemGroup));

            Items = new ObservableCollection<object>(sorted);
        }

        /// <summary>
        /// items
        /// </summary>
        /// <returns>The items.</returns>
        /// <param name="items">Items.</param>
        /// <param name="groupName">Group name.</param>
        public void  SetItems(ObservableCollection<ItemModel> items, string groupName, int count)
        {
            
            for (int i = 1; i <  count; i++)
            {
                items.Add(new ItemModel()
                {
                    Price = $"{i}.00$",
                    BookName = $"{groupName} Book {i}",
                    GroupName=groupName
                });

            }
        }

        public ObservableCollection<object> Items
        {
            get { return GetField<ObservableCollection<object>>(); }
            set { SetField(value); }
        }

        public class ItemModel : BaseModel
        {
            string price;
            public string Price
            {
                get { return price; }
                set { SetField(ref price, value); }
            }

            string bookName;
            public string BookName
            {
                get { return bookName; }
                set { SetField(ref bookName, value); }
            }

            string groupName;
            public string GroupName
            {
                get { return groupName; }
                set { SetField(ref groupName, value); }
            }

        }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }
    }
}