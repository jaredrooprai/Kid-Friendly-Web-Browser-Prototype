﻿using System;
using System.Threading;
using System.Windows;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void goToWebsite(object sender, RoutedEventArgs e)
        {

            Browser browserWindow = new Browser();
            browserWindow.Show();
            Close();
        }

        private void progressBarChange(object sender, EventArgs e)
        {
            // 1800 seconds = 30 minutes MAX TIME FOR WEB BROWSER 
            for (int i = 0; i < 50; i++)
            {
                pbStatus.Dispatcher.Invoke(() => pbStatus.Value = i, System.Windows.Threading.DispatcherPriority.Background);
                Thread.Sleep(50);
            }
           
            TimeOut popup = new TimeOut(); //Create new window to the exit page 
            popup.Show();
            Close();
        }

    }
}
