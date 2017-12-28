using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamvvm;
using DLToolkit.Forms.Controls;
using System.Windows.Input;


namespace DDDIPocLayoutDemo.ViewModels
{
    public class SimplePageModel : BasePageModel
    {
        public SimplePageModel()
        {
            ColumnCount = 3;

            ItemTappedCommand = new BaseCommand((param) =>
            {

                var item = LastTappedItem as SimpleItem;
                if (item != null)
                    System.Diagnostics.Debug.WriteLine("Tapped {0}", item.Title);

            });

            ScrollToCommand = new BaseCommand((arg) =>
            {
                var page = this.GetCurrentPage() as BookFlowListView;
                page.FlowScrollTo(Items[Items.Count / 2]);
            });

            ChangeColumnCountCommand = new BaseCommand((arg) =>
            {
                ColumnCount++;
            });
        }

        public FlowObservableCollection<object> Items
        {
            get { return GetField<FlowObservableCollection<object>>(); }
            set { SetField(value); }
        }

        public ICommand ScrollToCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public ICommand ChangeColumnCountCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public void ReloadData()
        {
            var exampleData = new List<object>();

            var howMany = 120;

            for (int i = 0; i < howMany; i++)
            {
                exampleData.Add(new SimpleItem() { Title = string.Format("Item nr {0}", i) });
            }

            Items = new FlowObservableCollection<object>(exampleData);
        }

        public int? ColumnCount
        {
            get { return GetField<int?>(); }
            set { SetField(value); }
        }

        public ICommand ItemTappedCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public object LastTappedItem
        {
            get { return GetField<object>(); }
            set { SetField(value); }
        }

        public class SimpleItem : BaseModel
        {
            string title;
            public string Title
            {
                get { return title; }
                set { SetField(ref title, value); }
            }

            public Color Color { get; private set; } = Color.Red;
        };
    }
}
