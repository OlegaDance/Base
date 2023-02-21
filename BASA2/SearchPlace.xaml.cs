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
            Goods.DataContext= bd.Products.ToList();
            Goods.ItemsSource = bd.Products.ToList();
        }
       
    }
}
