using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace BASA2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
          

        }

      
      
        public bool IsDarkTheme { get; set; }
        public static System.Windows.Media.Color ControlLightColor { get; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void ThemToogle_Click(object sender, RoutedEventArgs e)
        {


            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
                LabelName.Foreground = Brushes.Black;
                LabelName1.Foreground = Brushes.Black;
                LabelName2.Foreground = Brushes.Black;
                LabelName3.Foreground = Brushes.Black;
                LabelName4.Foreground = Brushes.Black;

            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
                LabelName.Foreground = Brushes.White;
                LabelName1.Foreground = Brushes.White;
                LabelName2.Foreground = Brushes.White;
                LabelName3.Foreground = Brushes.White;
                LabelName4.Foreground = Brushes.White;


            }
            paletteHelper.SetTheme(theme);
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
       


        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string name = TextBoxNameUser.Text;
            string password = TexTBoxPassword.Password;

           

            if (name.Length < 4)
            {
                TextBoxNameUser.ToolTip = "Мінімум 4 символи";
                TextBoxNameUser.Background = Brushes.IndianRed;
            }
            else if (password.Length < 6)
            {
                TexTBoxPassword.ToolTip = "Мінімум 6 символів";
                TexTBoxPassword.Background = Brushes.IndianRed;
            }
            else
            {
                TextBoxNameUser.ToolTip = "";
                TextBoxNameUser.Background = Brushes.Transparent;

                TexTBoxPassword.ToolTip = "";
                TexTBoxPassword.Background = Brushes.Transparent;


                User AuthUser = null;
              

                using (AppContext db = new AppContext())
                {
                    AuthUser = db.Users.Where(b => b.Name == name && b.Password == password).FirstOrDefault();
                }
              
                if (AuthUser != null)
                {
                     
                    
                    MasterWindow masterWindow = new MasterWindow();
                    masterWindow.Show();
                    Hide();

                    
                      }
               
                else
                {
                    MessageBox.Show("Щось пішло не так!");
                }


    }
        }
       
        private void Button_add_new_account_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Hide();
        }

        private void btn_Admin_Click(object sender, RoutedEventArgs e)
        {
            AuthWinwowAdmin authWinwowAdmin = new AuthWinwowAdmin();
            authWinwowAdmin.Show();
            Hide();

        }
       
        public void TextBoxNameUser_TextChanged(object sender, TextChangedEventArgs e)
        {

            MyProfile myProfile = new MyProfile();
            myProfile.TextBlockNameUserProfile.Text = TextBoxNameUser.Text;

            //MasterWindow masterWindow = new MasterWindow();
            //masterWindow.TextBlockNameProfileUser.Text = TextBoxNameUser.Text;


        }

      
    }
}
