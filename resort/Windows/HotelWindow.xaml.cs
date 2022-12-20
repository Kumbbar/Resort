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
    /// Логика взаимодействия для HotelWindow.xaml
    /// </summary>
    public partial class HotelWindow : Window
    {
        public Hotel hotel;
        public Country SelectedCountry;
        public HotelsWindow hotelsWindow;
        public HotelWindow(Hotel hotel, HotelsWindow hotelsWindow)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.hotelsWindow = hotelsWindow;
            TxtName.Text = hotel.Name;
            TxtStars.Text = Convert.ToString(hotel.CountOfStars);

            CmbCountry.ItemsSource = DBRequests.Сountries.GetCountriesOrderByName();
            SelectedCountry = hotel.Country;
            CmbCountry.SelectedItem = SelectedCountry;
        }

        private void CmbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCountry = CmbCountry.SelectedItem as Country;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            hotel.Name = TxtName.Text;
            hotel.CountOfStars = Convert.ToInt32(TxtStars.Text);
            hotel.Country = SelectedCountry;
            DBRequests.objDB.SaveChanges();
            hotelsWindow.UpdateHotelsDataGrid();
            this.Close();
        }
    }
}
