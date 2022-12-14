using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerRepositoryBase<City>
    {
        private ICityService _cityService;

        public CitiesController(ICityService cityService) : base(cityService)
        {
            _cityService = cityService;
        }
    }
}
