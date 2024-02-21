using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal:EfEntityRepositoryBase<Course,KodlamaIOContext>,ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                var result = from c in context.Courses
                    join ı in context.Instructors
                        on c.InstructorId equals ı.InstructorId
                    select new CourseDetailDto
                    {
                        CourseId = c.CourseId, CourseName = c.Name, Description = c.Description,
                        InstructorName = ı.InstructorName
                    };
                return result.ToList();
            }
        }
    }
}
