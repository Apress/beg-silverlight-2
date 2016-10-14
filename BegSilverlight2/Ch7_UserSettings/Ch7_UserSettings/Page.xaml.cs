using System;
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
using System.IO.IsolatedStorage;

namespace Ch7_UserSettings
{
    public partial class Page : UserControl
    {
        private IsolatedStorageSettings userSettings = IsolatedStorageSettings.ApplicationSettings;
        
        public Page()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Page_Loaded);
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (userSettings.Contains("name"))
            {
                string name = (string)userSettings["name"];
                txtName.Text = "Welcome, " + name;
            }
            else
            {
                txtName.Text = "Welcome";
            }
        }
    }
}
