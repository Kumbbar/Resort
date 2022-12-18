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
    public partial class MainMenu : Window
    {
        private DemoEntities _DBobj = new DemoEntities();
        private List<Database.Type> _TourTypes = new List<Database.Type>();
        private List<Tour> _Tours = new List<Tour>();
        private Database.Type SelectedType = new Database.Type() { Name = "Все типы" };
        public void UpdateToursListByStored()
        {
            _Tours = _DBobj.Tour.OrderBy(tour => tour.Name).ToList();
            ListTours.ItemsSource = _Tours;
        }
        private void UpdateToursList(List<Tour> _tours) {
            ListTours.ItemsSource = _tours;
        }

        public MainMenu()
        {
            InitializeComponent();

            _TourTypes.Add(new Database.Type() { Name = "Все типы" });
            _TourTypes.AddRange(_DBobj.Type.ToList());

            _Tours = _DBobj.Tour.OrderBy(tour => tour.Name).ToList();


            ListTours.ItemsSource = _Tours;
            CmbxTypes.ItemsSource = _TourTypes;
        }

        private void CmbxTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Database.Type type = CmbxTypes.SelectedItem as Database.Type;
            _Tours = _DBobj.Tour.ToList();
            if(type.Name == "Все типы")
            {
                UpdateToursList(_Tours);
                return;
            }
            _Tours = (
                from t in _Tours
                from tt in t.Type
                where tt.Id == type.Id
                select t
                ).ToList();
            
            UpdateToursList(_Tours);
        }

        private void TxtTourName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string FindtourName = TxtTourName.Text;
            _Tours = _DBobj.Tour.Where(
                tour => tour.Name.StartsWith(FindtourName) || tour.Name.EndsWith(FindtourName)
                ).ToList();
            UpdateToursList(_Tours);
        }

        private void ListTours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tour SelectedTour = ListTours.SelectedItem as Tour;
            if (SelectedTour == null) return;
            TourWindow window = new TourWindow();
            window.SetTour(SelectedTour);
            window.Owner = this;
            window.ShowDialog();
        }
    }
}
