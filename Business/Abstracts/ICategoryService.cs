using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IResult AddCategory(Category category);

        IResult DeleteCategory(Category category);

        IResult UpdateCategory(Category category);

        IDataResult<Category> GetById(int CategoryId);

        IDataResult<List<Category>> GetAll();




    }
}
