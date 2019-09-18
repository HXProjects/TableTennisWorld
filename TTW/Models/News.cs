using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTW.Models
{
    public class News
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public string ImageLink { get; set; }
        public int Id { get; set; }
    }
}