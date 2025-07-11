using System.Windows.Controls;

namespace CarRentalWPF
{
    public partial class PlaceholderPage : Page
    {
        public PlaceholderPage(string pageName)
        {
            InitializeComponent();
            PlaceholderText.Text = $"{pageName} Page - To be implemented";
        }
    }
}
