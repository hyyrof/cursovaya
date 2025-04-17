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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(orders order)
        {
            InitializeComponent();
            _order = order;

        }

        private orders _order;

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var SelAthlete = DGrideAthlete.SelectedItem as customers;
            if (SelAthlete != null)
            {
                App.DataBase.customers.Add(SelAthlete);
                App.DataBase.SaveChanges();
                DGrideAthlete.ItemsSource = App.DataBase.customers.ToList();
                MessageBox.Show("Сохранить");
            }
            else
                MessageBox.Show("Не выбран обьект");
        }
    }
}

