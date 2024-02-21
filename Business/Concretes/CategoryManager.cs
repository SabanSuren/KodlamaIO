using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
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
    public class CategoryManager:ICategoryService
    {
         ICategoryDal _categoryDal;

         public CategoryManager(ICategoryDal categoryDal)
         {
             this._categoryDal = categoryDal;
         }

         public IResult AddCategory(Category category)
        {
           _categoryDal.Add(category);
           return new SuccessResult(Messages.Added);
        }

        public IResult DeleteCategory(Category category)
        {
           _categoryDal.Delete(category);
           return new SuccessResult(Messages.Deleted);
        }

        public IResult UpdateCategory(Category category)
        {
            _categoryDal.Update(category);

            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Category> GetById(int CategoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == CategoryId),Messages.listed);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }
    }
}
