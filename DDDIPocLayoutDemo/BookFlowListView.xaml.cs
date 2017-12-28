using System;
using System.Collections.Generic;

using Xamarin.Forms;
using DLToolkit.Forms.Controls;
using DDDIPocLayoutDemo.ViewModels;
using Xamvvm;

namespace DDDIPocLayoutDemo
{
    public class ItemModel{
        public string Title
        {
            get;
            set;
        }
    }
    public partial class BookFlowListView : ContentPage
    {


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
                flwList.FlowColumnCount = 5;
            else
                flwList.FlowColumnCount = 3;
            flwList.ForceReload();

        }

        List<ItemModel> Items = new List<ItemModel>();
        public BookFlowListView()
        {
           
            FlowListView.Init(); 
            InitializeComponent();
            flwList.FlowItemsSource = new string[]{"vishal","amit","aniket","gmail","cnn"};

           

        }


    }
}
