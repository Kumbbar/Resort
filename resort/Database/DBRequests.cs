using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resort.Database
{
    public class ConnectDB
    {

        public static DemoEntities objDB = new DemoEntities();


        public class Tours
        {
            public static Tour GetTourById(int Id)
            {
                return objDB.Tour.Where(tour => tour.Id == Id).First();
            }
            public static List<Tour> GetToursOrderByName()
            {
                return objDB.Tour.OrderBy(tour => tour.Name).ToList();
            }
        }

        public static void SaveChangesByRequests() {
            objDB.SaveChanges();
        }
    }
}
