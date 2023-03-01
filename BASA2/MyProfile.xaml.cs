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
using System.Windows.Controls.Primitives;

namespace BASA2
{
    /// <summary>
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Page
    {
        public MyProfile()
        {
            InitializeComponent();
            ListBoxMyProfile.Items.Clear();
            AppContext db = new AppContext();
            ListBoxMyProfile.DataContext = db.Users.ToList();
            ListBoxMyProfile.ItemsSource = db.Users.ToList();
           
        }


        
        private void ListBoxMyProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            ListBoxMyProfile.SelectionChanged += ListBoxMyProfile_SelectionChanged;
            var selectedItem = ListBoxMyProfile.SelectedItem;

          
        }
    }
}
