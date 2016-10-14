using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Ch10_ExampleAnimation
{
	public partial class Page : UserControl
	{
		public Page()
		{
			// Required to initialize variables
			InitializeComponent();
            this.rectangle.MouseLeftButtonUp += new MouseButtonEventHandler(rectangle_MouseLeftButtonUp);
		}

        void rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Storyboard1.Begin();
        }
	}
}