using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager:IInstructorService
    {
         IInstructorDal _instructorDal;

         public InstructorManager(IInstructorDal instructorDal)
         {
             this._instructorDal = instructorDal;
         }

         public IResult AddInstructor(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteInstructor(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult UpdateInstructor(Instructor instructor)
        {
          _instructorDal.Update(instructor);
          return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Instructor> GetById(int InstructorId)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(ı => ı.InstructorId == InstructorId),
                Messages.listed);
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll());
        }
    }
}
