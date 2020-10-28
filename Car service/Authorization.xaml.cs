using System.Windows;

namespace Car_service
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Back_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.IsHitTestVisible = true;
            window.IsEnabled = true;
            this.Close();
        }
    }
}
