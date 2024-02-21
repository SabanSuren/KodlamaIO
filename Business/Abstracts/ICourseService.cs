using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult AddCourse(Course course);

        IResult DeleteCourse(Course course);

        IResult UpdateCourse(Course course);

        IDataResult<Course>GetById(int CourseId);

        IDataResult<List<Course>> GetAll();

        IDataResult<List<CourseDetailDto>> GetCourseDetails();


    }
}
