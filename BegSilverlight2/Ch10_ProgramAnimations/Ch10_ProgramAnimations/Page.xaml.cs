using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Ch10_ProgramAnimations
{
	public partial class Page : UserControl
	{
        private bool Paused;
        public Page()
        {
            // Required to initialize variables
            InitializeComponent();
            this.btnStart.Click += new RoutedEventHandler(btnStart_Click);
            this.btnStop.Click += new RoutedEventHandler(btnStop_Click);
            this.rectangle.MouseLeftButtonUp += 
                new MouseButtonEventHandler(rectangle_MouseLeftButtonUp);
        }

        void rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Paused)
            {
                this.MoveRect.Resume();
                Paused = false;
            }
            else
            {
                this.MoveRect.Pause();
                Paused = true;
            }

        }

        void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.MoveRect.Stop();
        }

        void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.MoveRect.Begin();
        }
	}
}