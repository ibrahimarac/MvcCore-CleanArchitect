using Ibrahim.Core.Domain.Entities;
using Ibrahim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ibrahim.Data.Sql.Repositories
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(IlknurContext context):base(context)
        {

        }

    }
}
