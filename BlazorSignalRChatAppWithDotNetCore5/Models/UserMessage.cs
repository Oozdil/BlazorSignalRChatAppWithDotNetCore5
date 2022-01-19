﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalRChatAppWithDotNetCore5.Models
{
    public class UserMessage
    {
        public string  Username { get; set; }
        public string  Message { get; set; }
        public bool  CurrentUser { get; set; }
        public DateTime  DateSend { get; set; }
    }
}
