using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
    public interface ICourseDal:IEntityRepository<Course>
    {
        List<CourseDetailDto> GetCourseDetails();
    }
}
