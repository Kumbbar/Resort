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
    /// Логика взаимодействия для TourWindow.xaml
    /// </summary>
    public partial class TourWindow : Window
    {
        private DemoEntities _DBobj = new DemoEntities();
        private Tour tour; 
        public TourWindow()
        {
            InitializeComponent();           
            
        }

        public void SetTour(Tour tour) {
            if (tour == null) return;
            this.tour = tour;
            NameLabel.Content = tour.Name;
            TxtName.Text = tour.Name;
            TourImage.Source = new BitmapImage(new Uri(tour.ImgPath, UriKind.Relative));
            TxtDescription.Text = tour.Description;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            tour.Name = TxtName.Text;
            tour.Description = TxtDescription.Text;
            Tour EditTour = ConnectDB.Tours.GetTourById(tour.Id);
            EditTour.Name = TxtName.Text;
            EditTour.Description = TxtDescription.Text;
            _DBobj.SaveChanges();
            this.Close();
        }
    }
}
