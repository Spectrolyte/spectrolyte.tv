using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using spectrolyte.tv.Models;

namespace spectrolyte.tv.Controllers
{
    [Route("api/[controller]")]
    public class BlogPostController : Controller
    {
        private readonly BlogPostContext _context;

        public BlogPostController(BlogPostContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public BlogPost Get(int id)
        {
            return _context.BlogPosts.FirstOrDefault(bp => bp.Id == id);
        }

        [HttpGet]
        public IEnumerable<BlogPost> Get() 
        {
            return _context.BlogPosts.AsEnumerable();
        }

        [HttpPost("{content}")]
        public BlogPost Post(string content)
        {
            var bp = new BlogPost 
            {
                Created = DateTime.Now,
                Content = content
            };

            _context.BlogPosts.Add(bp);
            _context.SaveChanges();

            return bp;
        }
    }
}