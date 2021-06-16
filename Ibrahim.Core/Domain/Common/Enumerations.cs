﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Domain.Common
{
    public enum RequestType
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public enum JsonResponseStatus
    {
        Ok = 1,
        Error = 2
    }

    public enum JConfirmMessageType
    {
        Success,
        Error,
        Warning
    }
}
