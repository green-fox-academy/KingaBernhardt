using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedditPage.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        public IActionResult ListPost()
        {
            return View("ListPosts");
        }

        public IActionResult GetPost()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            return View();
        }
    }
}