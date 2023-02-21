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
    /// Interaction logic for AuthWinwowAdmin.xaml
    /// </summary>
    public partial class AuthWinwowAdmin : Window
    {
        public AuthWinwowAdmin()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string namee = TextBoxNameUser.Text;
            string passwordd = TexTBoxPassword.Password;

            if (namee=="Admin"&& passwordd == "111111")
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Упс!!!");
            }
        }
    }
}
