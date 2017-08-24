using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace spectrolyte.tv.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}