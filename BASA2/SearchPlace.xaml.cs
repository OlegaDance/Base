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

       // public delegate void RemoveItemDelegate(string item);

        public SearchPlace()
        {
            InitializeComponent();

          
            ProductsContext bd = new ProductsContext();

           // bd.Database.CreateIfNotExists();

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
            // Отримати обраний елемент
            var selectedItem = Goods.SelectedItem;
            // Виконати потрібні дії з отриманою інформацією
            // Наприклад, вивести вміст обраного елементу в TextBox
            SampleText.Text = selectedItem.ToString();



        }

        private void Order_the_goods_Click(object sender, RoutedEventArgs e)
        {

            OrderGoods orderGoods = new OrderGoods();
           
             // Отримуємо значення з TextBox
            int count = int.Parse(TextBoxCountEnter.Text);
            decimal price = decimal.Parse(TextBoxPriceEnter.Text);

            if (!int.TryParse(TextBoxCountEnter.Text, out count))
            {
                MessageBox.Show("Некоректна кількість товару!");
                return;
            }

            if (!decimal.TryParse(TextBoxPriceEnter.Text, out price))
            {
                MessageBox.Show("Некоректна ціна товару!");
                return;
            }

            // Обчислюємо вартість
            decimal total = count * price;

            orderGoods = SetPriceAndCount(total);
           



            // отримання тексту з textBlock1
            string text = SampleText.Text;

            // відкриваємо нове вікно


            // передаємо текст у друге вікно
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
    
