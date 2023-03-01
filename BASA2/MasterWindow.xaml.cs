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
using System.Windows.Shapes;

namespace BASA2
{
    /// <summary>
    /// Логика взаимодействия для MasterWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        public MasterWindow()
        {
            InitializeComponent();

        }
        MainWindow mainWindow = new MainWindow(); 
        
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void ThemToogle_Click(object sender, RoutedEventArgs e)
        {


            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);


            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);



            }
            paletteHelper.SetTheme(theme);
        }
        private void myprofileTxT_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MyProfile();
        }
        private void Button_Click_searchplace(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new SearchPlace();
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
    

