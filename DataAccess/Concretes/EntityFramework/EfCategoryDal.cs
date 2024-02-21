using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,KodlamaIOContext>,ICategoryDal
    {
    }
}
