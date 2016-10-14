﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Ch6_WCFService.StartingHandService;

namespace Ch6_WCFService
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Page_Loaded);
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StartingHandServiceClient service = new StartingHandServiceClient();
            service.GetHandsCompleted += new 
                EventHandler<GetHandsCompletedEventArgs>(service_GetHandsCompleted);
            service.GetHandsAsync();
        }

        void service_GetHandsCompleted(object sender, GetHandsCompletedEventArgs e)
        {
            this.grdData.ItemsSource = e.Result;
        }
    }
}
