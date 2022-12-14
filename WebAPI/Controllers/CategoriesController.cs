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
    public class CategoriesController : ControllerRepositoryBase<Category>
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService) : base(categoryService)
        {
            _categoryService = categoryService;
        }
    }
}
