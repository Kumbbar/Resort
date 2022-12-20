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
using resort.Windows;

namespace resort.Windows
{
    /// <summary>
    /// Логика взаимодействия для TourWindow.xaml
    /// </summary>
    public partial class TourWindow : Window
    {
        public ToursWindow menu;
        public Tour tour;
        public TourWindow(Tour tour, ToursWindow menu)
        {
            InitializeComponent();
            this.menu = menu;

            if (tour == null) return;
            this.tour = tour;

            NameLabel.Content = tour.Name;
            TxtName.Text = tour.Name;
            TourImage.Source = new BitmapImage(new Uri(tour.ImgPath, UriKind.Relative));
            TxtDescription.Text = tour.Description;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Tour EditTour = DBRequests.Tours.GetTourById(tour.Id);

            EditTour.Name = TxtName.Text;
            EditTour.Description = TxtDescription.Text;

            DBRequests.objDB.SaveChanges();
            menu.UpdateToursList();
            this.Close();
        }
    }
}
