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

namespace resort.Windows
{
    public partial class MainMenu : Window
    {
        private Database.DemoEntities DBobj = new Database.DemoEntities();
        public MainMenu()
        {
            InitializeComponent();
            Database.ConnectDB.objDB = new Database.DemoEntities();

            ListTours.ItemsSource = DBobj.Tour.OrderBy(tour => tour.Name).ToList();
        }
    }
}
