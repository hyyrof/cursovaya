using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        public Menu(customers customer)
        {
            InitializeComponent();
           
            _customer = customer;
        }

        private customers _customer; 

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new orders());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new employees());
        }
    }
}

