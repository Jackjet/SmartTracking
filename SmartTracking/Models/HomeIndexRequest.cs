using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartTracking.Models
{
    public class HomeIndexRequest
    {
        public string Domain { get; set; }

        public string Uri { get; set; }
        
        public string Referrer { get; set; }

        public string ScreenWidth { get; set; }

        public string ScreenHeight { get; set; }

        public string ColorDepth { get; set; }

        public string Lang { get; set; }

        public string Account { get; set; }

        public string Event { get; set; }

        public string Exts { get; set; }

        public HomeIndexRequest()
        {
            Domain = string.Empty;
            Uri = string.Empty;
            Referrer = string.Empty;
            ScreenWidth = string.Empty;
            ScreenHeight = string.Empty;
            ColorDepth = string.Empty;
            Lang = string.Empty;
            Account = string.Empty;
            Event = string.Empty;
            Exts = string.Empty;
        }
    }
}