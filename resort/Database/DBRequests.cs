using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resort.Database
{
    public class DBRequests
    {
        public static DemoEntities objDB = new DemoEntities();

        public class Tours
        {
            public static Tour GetTourById(int Id)
            {
                return objDB.Tour.Where(tour => tour.Id == Id).First();
            }

            public static List<Tour> GetToursWithType_In(Type type, List<Tour> tours) {
                return (
                    from t in tours
                    from tt in t.Type
                    where tt.Id == type.Id
                    select t
                    ).ToList();
            }

            public static List<Tour> GetToursWithLikeName_In(string name, List<Tour> tours)
            {
                return tours.Where(
                tour => tour.Name.StartsWith(name) || tour.Name.EndsWith(name)
                ).ToList();
            }

            public static List<Tour> GetToursOrderByName()
            {
                return objDB.Tour.OrderBy(tour => tour.Name).ToList();
            }
        }

        public class Types
        {
            public static List<Type> GetTypesList()
            {
                return objDB.Type.ToList();
            }
        }

        public class Hotels
        {
            public static List<Hotel> GetHotelsListByTens(int num) {
                return objDB.Hotel.OrderBy(hotel => hotel.Name).Skip((num - 1) * 10).Take(10).ToList();
            }

            public static List<Hotel> GetHotelsList()
            {
                return objDB.Hotel.ToList();
            }
        }

        public class Сountries
        {
            public static List<Country> GetCountriesOrderByName() {
                return objDB.Country.OrderBy(country => country.Name).ToList();
            }
        }
    }
}
