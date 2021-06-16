using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Domain.Abstractions
{
    public interface IPermanent
    {
        bool? IsActive { get; set; }
    }
}
