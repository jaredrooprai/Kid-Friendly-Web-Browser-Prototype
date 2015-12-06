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
        private bool catGrid1;
        private bool catGrid2;
        private bool catGrid3;
        private int page;

        public MainWindow()
        {
            InitializeComponent();
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
            catGrid1 = true;
            catGrid2 = false;
            catGrid3 = false;
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;

            CategoryGrid1.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            CategoryGrid2.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            CategoryGrid3.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);


        }

        private void goToWebsite(object sender, object EventArgs ) 
        {
            // add code for browser user control
        }


        private void favourite(object sender, object EventArgs)
        {
            // add code for favourites 
        }



        private void progressBarChange(object sender, EventArgs e)
        {
            // 1800 seconds = 30 minutes MAX TIME FOR WEB BROWSER 
            for (int i = 0; i < 200; i++)
            {
                pbStatus.Dispatcher.Invoke(() => pbStatus.Value = i, System.Windows.Threading.DispatcherPriority.Background);
                Thread.Sleep(200);
            }
        }

    

        private void games_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
            catGrid1 = true;
            catGrid2 = false;
            catGrid3 = false;
        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid2());
            catGrid1 = false;
            catGrid2 = true;
            catGrid3 = false;
        }



        private void learn_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid3());
            catGrid1 = false;
            catGrid2 = false;
            catGrid3 = true;
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
            page++;
            if (page == 1)
            {
                leftArrow.Visibility = Visibility.Hidden;
            }
            else if (page == 2)
            {
                leftArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }
            
            if (catGrid1)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid2());
                catGrid1 = false;
                catGrid2 = true;
                catGrid3 = false;
            }

            else if (catGrid2)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid3());
                catGrid1 = false;
                catGrid2 = false;
                catGrid3 = true;
            }

            else
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid1());
                catGrid1 = true;
                catGrid2 = false;
                catGrid3 = false;
            }
        }

        private void leftArrow_Click(object sender, RoutedEventArgs e)
        {

            page--;
            if (page == 1)
            {
                leftArrow.Visibility = Visibility.Hidden;
                rightArrow.Visibility = Visibility.Visible;
            }
            else if (page == 2)
            {
                leftArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }

            if (catGrid3)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid2());
                catGrid1 = false;
                catGrid2 = true;
                catGrid3 = false;
            }

            else if (catGrid2)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid1());
                catGrid1 = true;
                catGrid2 = false;
                catGrid3 = false;
            }

            else
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid3());
                catGrid1 = false;
                catGrid2 = false;
                catGrid3 = true;
            }
        }
    }
}
