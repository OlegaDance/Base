using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Schema;

namespace BASA2
{
    /// <summary>
    /// Interaction logic for OrderGoods.xaml
    /// </summary>
    public partial class OrderGoods : Window
    {

        OrderContext BD;
        public OrderGoods()
        {
            InitializeComponent();
            BD = new OrderContext();


        }

        internal void SetText(string text)
        {
            GoodsTextBlock.Text = text;


        }



       
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            SearchPlace searchPlace = new SearchPlace();

            AdminWindow adminWindow = new AdminWindow();




            string SurnameUser = TextBoxSurnameUser.Text;
            string NameUser = TextBoxNameUser.Text;
            string NumberPhoneUser = TextBoxNumberPhoneUser.Text;
            string CityUser = TextBoxCityUser.Text;
            string StreetUser = TextBoxStreetUser.Text;
            string Goods = GoodsTextBlock.Text;
            string Count = searchPlace.TextBoxCountEnter.Text;



            Order zamovlenna = new Order(SurnameUser, NameUser, NumberPhoneUser, CityUser, StreetUser, Goods, Count);
            BD.Orders.Add(zamovlenna);
            BD.SaveChanges();


          

            

         }

        private void PickupOption_Checked(object sender, RoutedEventArgs e)
        {

            AdminWindow adminWindow = new AdminWindow();
            ListBoxItem listBoxItem = new ListBoxItem();
            listBoxItem.Content = (sender as RadioButton).Content;
            adminWindow.ListBoxPickUpOption.Items.Add(listBoxItem);

        }
    }


}
