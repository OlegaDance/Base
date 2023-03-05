using MaterialDesignThemes.Wpf;
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
using System.Data.Entity;

namespace BASA2
{
    /// <summary>
    /// Interaction logic for SearchPlace.xaml
    /// </summary>
    public partial class SearchPlace : Page
    {
        public SearchPlace()
        {
            InitializeComponent();

            ProductsContext bd = new ProductsContext();
            Goods.DataContext = bd.Products.ToList();
            Goods.ItemsSource = bd.Products.ToList();
        }

        public void RemoveItem(string item)
        {
            Goods.Items.Remove(item);
        }

        private void Goods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Goods.SelectionChanged += Goods_SelectionChanged;
            var selectedItem = Goods.SelectedItem;
            SampleText.Text = selectedItem.ToString();
        }

        private void Order_the_goods_Click(object sender, RoutedEventArgs e)
        {
            OrderGoods orderGoods = new OrderGoods();
            decimal count = decimal.Parse(TextBoxCountEnter.Text);
            decimal price = decimal.Parse(TextBoxPriceEnter.Text);
            if (!decimal.TryParse(TextBoxCountEnter.Text, out count))
            {
                MessageBox.Show("Некоректна кількість товару!");
                return;
            }
            if (!decimal.TryParse(TextBoxPriceEnter.Text, out price))
            {
                MessageBox.Show("Некоректна ціна товару!");
                return;
            }
           decimal total = count * price;
            orderGoods = SetPriceAndCount(total);
            string text = SampleText.Text;
            orderGoods.SetText(text);
            orderGoods.ShowDialog();
        }
        public OrderGoods  SetPriceAndCount(decimal total)
        {
            OrderGoods orderGoods = new OrderGoods();
            orderGoods.FormulaTextBlockCountAndPrice.Text = total.ToString();
            return orderGoods;
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchBox.Text.ToLower();
            for(int i = 0;i<Goods.Items.Count;i++)
            {
                string itemText = Goods.Items[i].ToString().ToLower();
                if(itemText.Contains(searchTerm))
                {
                    Goods.SelectedIndex= i;
                    break;
                }
            }
        }
    }
}
    
