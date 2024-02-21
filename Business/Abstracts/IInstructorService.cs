using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IResult AddInstructor(Instructor instructor);

        IResult DeleteInstructor(Instructor instructor);

        IResult UpdateInstructor(Instructor instructor);

        IDataResult<Instructor> GetById(int InstructorId);

        IDataResult<List<Instructor>> GetAll();
    }
}
