using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ClassAdapterImplementation
{
    public class ClassAdapterImplementation
    {
        public class CityFromExternalService
        {
            public string Name { get; set; }
            public string NickName { get; set; }
            public int Inhabitans { get; set; }

            public CityFromExternalService(string name, string nickName, int inhabitans)
            {
                Name = name;
                NickName = nickName;
                Inhabitans = inhabitans;

            }
        }


        /// <summary>
        /// This class represents an external system that provides city information.
        /// </summary>
        public class ExternalSystem
        {
            public CityFromExternalService GetCity()
            {
                return new CityFromExternalService("Warsaw", "Warszawa", 1800000);
            }
        }


        public class City
        {
            public string FullName { get; set; }
            public long Inhabitants { get; set; }

            public City(string fullName, long inhabitants)
            {
                FullName = fullName;
                Inhabitants = inhabitants;
            }
        }

        /// <summary>
        /// Target
        /// </summary>
        public interface ICityAdapter
        {
            City GetCity();
        }

        /// <summary>
        /// Adapter
        /// </summary>
        /// 
        public class CityAdapter : ExternalSystem, ICityAdapter
        {
            public City GetCity()
            {
                var cityFromExternalService = base.GetCity();
                return new City(cityFromExternalService.Name, cityFromExternalService.Inhabitans);
            }
        }
    }
}
