using cityinfo.api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cityinfo.api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICititesServices _cityServices;
        public CitiesController(ICititesServices cityServices)
        {
            _cityServices = cityServices;
        }

        [Route("GetCities")]
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(_cityServices.GetCities());
        }
    }
}
