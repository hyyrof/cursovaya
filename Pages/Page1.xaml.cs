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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            DGrideAthlete.ItemsSource = App.DataBase.customers.ToList();
        }

        private void DGrideAthlete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var SelAthlete = DGrideAthlete.SelectedItem as customers;
            if (SelAthlete != null)
            {
                NavigationService.Navigate(new Menu(SelAthlete));
            }
            else
                MessageBox.Show("Ничего не выбрано");
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var SelAthlete = DGrideAthlete.SelectedItem as customers;
            if (SelAthlete != null)
            {
                App.DataBase.customers.Remove(SelAthlete);
                App.DataBase.SaveChanges();
            }
            else
                MessageBox.Show("Ничего не выбрано");
            DGrideAthlete.ItemsSource = App.DataBase.customers.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(new orders()));
        }
    }
}

