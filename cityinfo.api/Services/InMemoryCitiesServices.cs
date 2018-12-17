using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cityinfo.api.Models;

namespace cityinfo.api.Services
{
    public class InMemoryCitiesServices : ICititesServices
    {

        public InMemoryCitiesServices()
        {
            Cities = new List<CityDTO>
            {
                new CityDTO
                {
                    ID=1,
                    Name="Bangalore",
                    Description="Garden City"
                },
                 new CityDTO
                {
                    ID=2,
                    Name="Madurai",
                    Description="Temple City"
                },
                  new CityDTO
                {
                    ID=3,
                    Name="Tiruchendur",
                    Description="Soul City"
                },

            };
        }

        public List<CityDTO> Cities { get; set;  }

        public List<CityDTO> GetCities()
        {
            return Cities;
        }

        public CityDTO GetCity(int id)
        {
            return Cities.FirstOrDefault(i => i.ID == id);
        }
    }
}
