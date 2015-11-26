using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHook.Models
{
    public class Message
    {
        public string ClientAddress { get; set; }
        public string ContentBody { get; set; }
    }
}