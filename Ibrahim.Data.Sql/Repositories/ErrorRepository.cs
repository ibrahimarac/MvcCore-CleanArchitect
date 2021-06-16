using Ibrahim.Core.Domain.Entities;
using Ibrahim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Data.Sql.Repositories
{
    public class ErrorRepository:Repository<Error>,IErrorRepository
    {
        public ErrorRepository(IlknurContext context):base(context)
        {

        }


    }
}
