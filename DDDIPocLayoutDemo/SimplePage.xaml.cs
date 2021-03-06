﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamvvm;
using DLToolkit.Forms.Controls;

namespace DLToolkitControlsSamples
{
    public partial class SimplePage : ContentPage, IBasePage<SimplePageModel>
    {
        public SimplePage()
        {
            FlowListView.Init();
            InitializeComponent();
        }

        public void FlowScrollTo(object item)
        {
            flowListView.FlowScrollTo(item, ScrollToPosition.MakeVisible, true);
        }
    }
}