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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace BASA2
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        ProductsContext bd;

       
        public AdminWindow()
        {
            InitializeComponent();
            bd = new ProductsContext();

            ListBoxZamovlenna.Items.Clear();
            OrderContext BD = new OrderContext();
            ListBoxZamovlenna.DataContext = BD.Orders.ToList();
            ListBoxZamovlenna.ItemsSource = BD.Orders.ToList();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            string name = ProductNameTextBox.Text;
            string sort = SortTextBox.Text;
            string price= PriceTextBox.Text;
            string count = ProductquantityTextBox.Text;
           

            Product product = new Product(name, sort, price, count);
            bd.Products.Add(product);
            bd.SaveChanges();
        }

        private void BackToAuth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
