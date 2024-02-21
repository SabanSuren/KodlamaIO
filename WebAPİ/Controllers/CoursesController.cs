using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
         ICourseService _courseService;

         public CoursesController(ICourseService courseService)
         {
             this._courseService = courseService;
         }

         [HttpGet("GetAll")]

         public IActionResult GetAll()
         {
             var result = _courseService.GetAll();
             if (result.Success)
             {
                 return Ok();
             }

             return BadRequest(result);
         }

         [HttpGet("GetCourseDetail")]

         public IActionResult GetCourseDetail()
         {
             var result = _courseService.GetCourseDetails();

             if (result.Success)
             {
                 return Ok();
             }

             return BadRequest(result);
         }


         [HttpPost("Add")]

         public IActionResult Add([FromBody] Course course)
         {
             var result= _courseService.AddCourse(course);

             if (result.Success)
             {
                 return Ok();
             }

             return BadRequest(result);
         }

         [HttpDelete("Delete")]

         public IActionResult Delete(Course course)
         {
             return Ok(_courseService.DeleteCourse(course));
         }

         [HttpPut("Update")]


         public IActionResult Update(Course course)
         {
             return Ok(_courseService.UpdateCourse(course));
         }
    }
}
