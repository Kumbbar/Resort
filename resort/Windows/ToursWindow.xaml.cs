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
    public partial class ToursWindow : Window
    {
        private List<Database.Type> _TourTypes = new List<Database.Type>();
        private List<Tour> _Tours = new List<Tour>();
        private Database.Type SelectedType = new Database.Type() { Name = "Все типы" };
        private string TxtFind = "";

        public void UpdateToursList() {
            _Tours = DBRequests.Tours.GetToursOrderByName();
            if (TxtFind != "") {
                _Tours = DBRequests.Tours.GetToursWithLikeName_In(TxtFind, _Tours);
            }
            if (SelectedType.Name != "Все типы") {
                _Tours = DBRequests.Tours.GetToursWithType_In(SelectedType, _Tours);
            }
            ListTours.ItemsSource = _Tours;
        }

        public ToursWindow()
        {
            InitializeComponent();

            _TourTypes.Add(new Database.Type() { Name = "Все типы" });
            _TourTypes.AddRange(DBRequests.Types.GetTypesList());
            CmbxTypes.ItemsSource = _TourTypes;

            _Tours = DBRequests.Tours.GetToursOrderByName(); ;
            ListTours.ItemsSource = _Tours;
        }

        private void CmbxTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Database.Type type = CmbxTypes.SelectedItem as Database.Type;
            SelectedType = type;
            UpdateToursList();
        }

        private void TxtTourName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtFind = TxtTourName.Text;
            UpdateToursList();
        }

        private void ListTours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tour SelectedTour = ListTours.SelectedItem as Tour;
            ListTours.SelectedItem = null;
            if (SelectedTour == null) return;
            TourWindow tourWindow = new TourWindow(SelectedTour, this);
            tourWindow.ShowDialog();
        }

        private void BtnOpenHotels_Click(object sender, RoutedEventArgs e)
        {
            var hotelsWindow = new HotelsWindow();
            hotelsWindow.Show();
        }
    }
}
