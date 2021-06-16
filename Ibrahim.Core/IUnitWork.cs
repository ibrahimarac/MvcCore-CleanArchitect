using Ibrahim.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ibrahim.Core
{
    public interface IUnitWork:IDisposable
    {
        ICategoryRepository CategoryRepo { get; }

        IErrorRepository ErrorRepo { get; }

        ICrudLoggerRepository CrudLoggerRepo { get; set; }

        bool Commit();
        Task<bool> CommitAsync();
    }

}
