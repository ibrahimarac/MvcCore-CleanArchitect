﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Domain.Common
{
    public class JsonResponse
    {
        public string Message { get; set; }
        public JsonResponseStatus Status { get; set; }
        public object Result { get; set; }
    }

   
}
