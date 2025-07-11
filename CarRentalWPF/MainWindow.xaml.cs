using System.Windows;
using System.Windows.Controls;

namespace CarRentalWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Load Dashboard page by default
            MainFrame.Navigate(new DashboardPage());
        }

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DashboardPage());
        }

        private void BookingBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for BookingPage
            MainFrame.Navigate(new PlaceholderPage("Booking"));
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for ReturnPage
            MainFrame.Navigate(new PlaceholderPage("Return"));
        }

        private void TransactionsBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for TransactionsPage
            MainFrame.Navigate(new PlaceholderPage("Transactions"));
        }

        private void VehiclesBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for VehiclesPage
            MainFrame.Navigate(new PlaceholderPage("Vehicles"));
        }

        private void CustomersBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for CustomersPage
            MainFrame.Navigate(new PlaceholderPage("Customers"));
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for UsersPage
            MainFrame.Navigate(new PlaceholderPage("Users"));
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...");
            // Close the app or navigate to login page
            this.Close();
        }
    }
}
