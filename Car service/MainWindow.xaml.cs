using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;


namespace Car_service
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonDeploy_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }

        }

        private void ButtonCurtail_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        //MainWindow buttons
        private void btMain_Click(object sender, RoutedEventArgs e)
        {
            Service_grid.Visibility = Visibility.Hidden;
            Order_grid.Visibility = Visibility.Hidden;
            Main_grid.Visibility = Visibility.Visible;
        }

        private void btService_Click(object sender, RoutedEventArgs e)
        {
            Service_grid.Visibility = Visibility.Visible;
            Order_grid.Visibility = Visibility.Hidden;
            Main_grid.Visibility = Visibility.Hidden;
        }

        private void btOrder_Click(object sender, RoutedEventArgs e)
        {
            Service_grid.Visibility = Visibility.Hidden;
            Order_grid.Visibility = Visibility.Visible;
            Main_grid.Visibility = Visibility.Hidden;
        }
        //Login/Create account
        private void Login_Reg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Authorization authorization = new Authorization();
            MainWindow window = new MainWindow();
            authorization.Owner = this;
            window.IsHitTestVisible = false;
            this.IsEnabled = false;
            authorization.Show();
        }
    }
}
