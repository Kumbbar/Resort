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

namespace resort
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            Database.ConnectDB.objDB = new Database.DemoEntities();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            /*var user = Database.ConnectDB.objDB.Workers.Where(x => x.login == TxtEmail.Text && x.password == TxtPass.Text).ToList();
            if (user.Count() > 0) {
                var menu = new Windows.MainMenu();
                menu.Show();
                this.Close();
            } 
            else MessageBox.Show("Неверный логин или пароль", "Ошибка");*/
        }
    }
}
