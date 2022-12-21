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
using resort.Database;

namespace resort.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddHotelWindow.xaml
    /// </summary>
    public partial class AddHotelWindow : Window
    {
        public Hotel hotel;
        public Country SelectedCountry;
        public HotelsWindow hotelsWindow;

        public AddHotelWindow(HotelsWindow hotelsWindow)
        {
            InitializeComponent();
            CmbCountry.ItemsSource = DBRequests.Сountries.GetCountriesOrderByName();
            this.hotelsWindow = hotelsWindow;
            this.hotel = new Hotel();
        }
        private void CmbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCountry = CmbCountry.SelectedItem as Country;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            hotel.Name = TxtName.Text;
            hotel.CountOfStars = Convert.ToInt32(TxtStars.Text);
            hotel.Country = SelectedCountry;

            DBRequests.objDB.Hotel.Add(this.hotel);
            DBRequests.objDB.SaveChanges();

            this.hotelsWindow.UpdateHotelsDataGrid();
            this.Close();
        }
    }
}
