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
    /// Логика взаимодействия для HotelsWindow.xaml
    /// </summary>
    public partial class HotelsWindow : Window
    {
        public int CurrentPage = 1;
        public int MaxPage = Convert.ToInt32(Math.Ceiling(DBRequests.Hotels.GetHotelsList().Count * 1.0 / 10));
        private List<Hotel> _Hotels;

        public void UpdateTxtElelments()
        {
            LbNumPage.Content = $"{CurrentPage} of {MaxPage}";
            TxtNumPage.Text = CurrentPage.ToString();
        }
        public void UpdateHotelsDataGrid() {
            _Hotels = DBRequests.Hotels.GetHotelsListByTens(CurrentPage);
            DtGrHotels.ItemsSource = _Hotels;
        }

        public void UpdateAll() {
            UpdateHotelsDataGrid();
            UpdateTxtElelments();
        }
        public HotelsWindow()
        {
            InitializeComponent();
            UpdateAll();
        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage = 1;
            UpdateAll();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage - 1 < 1) return;
            CurrentPage--;
            UpdateAll();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage + 1 > MaxPage) return;
            CurrentPage++;
            UpdateAll();
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage = MaxPage;
            UpdateAll();
        }

        private void BtnDtGr_Click(object sender, RoutedEventArgs e)
        {
            var SelectedItem = (sender as Button).DataContext as Hotel;
            HotelWindow hotelWindow = new HotelWindow(SelectedItem, this);
            hotelWindow.ShowDialog();
        }

        private void BtnCreateHotel_Click(object sender, RoutedEventArgs e)
        {
            AddHotelWindow addHotelWindow = new AddHotelWindow(this);
            addHotelWindow.ShowDialog();
        }
    }
}
