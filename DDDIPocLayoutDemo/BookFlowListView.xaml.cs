using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using DLToolkit.Forms.Controls;
using DDDIPocLayoutDemo.ViewModels;
using Xamvvm;
using Xamarin.Forms.Internals;
using System.Collections.ObjectModel;

namespace DDDIPocLayoutDemo
{
    public partial class BookFlowListView : ContentPage
    {

        /// <summary>
        /// onsize allocated
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
                flwList.FlowColumnCount = 5;
            else
                flwList.FlowColumnCount = 3;
            flwList.ForceReload();

        }

        //List<ItemModel> Items = new List<ItemModel>();
        public BookFlowListView()
        {

            FlowListView.Init();
            InitializeComponent();
            var bookPageModel = new BookGalaryPageModel();
            bookPageModel.ReloadData();
            flwList.FlowItemsSource = bookPageModel.Items;
        }

    }
}
