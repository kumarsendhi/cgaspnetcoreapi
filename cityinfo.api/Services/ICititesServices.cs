using cityinfo.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cityinfo.api.Services
{
    public interface ICititesServices
    {
         List<CityDTO> GetCities();
    }
}
