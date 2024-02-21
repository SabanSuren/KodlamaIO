using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Concretes
{
    public class CourseManager:ICourseService
    {
         ICourseDal _courseDal;

         public CourseManager(ICourseDal courseDal)
         {
             this._courseDal = courseDal;
         }

         public IResult AddCourse(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteCourse(Course course)
        {
           _courseDal.Delete(course);
           return new SuccessResult(Messages.Deleted);
        }

        public IResult UpdateCourse(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Course> GetById(int CourseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c => c.CourseId == CourseId),Messages.listed);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll());
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }
    }
}
