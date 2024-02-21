using Business.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
         ICategoryService _categoryService;

         public CategoriesController(ICategoryService categoryService)
         {
             this._categoryService = categoryService;
         }


    }
}
