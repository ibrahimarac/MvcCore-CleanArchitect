using System;
using System.Collections.Generic;
using System.Text;

namespace Ibrahim.Core.Domain.Dto
{
    public class LogDto : NonTrackableDto
    {
        public string Username { get; set; }
        public string EntityName { get; set; }
        public string Old { get; set; }
        public string New { get; set; }
        public DateTime LogDate { get; set; }
    }
}
