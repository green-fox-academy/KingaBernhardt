using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditPage.Models;
using RedditPage.Services;

namespace RedditPage.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private IService postService;
        public PostController(IService postService)
        {
            this.postService = postService;
        }

        [Route("/ListPosts")]
        public IActionResult ListPosts()
        {
            return View(postService.ReadPosts());
        }

        [HttpGet("/AddPost")]
        public IActionResult AddPost()
        {

            return View("Add");
        }

        [HttpPost("/AddPost")]
        public IActionResult AddPost(Post post)
        {
            postService.CreatPost(post);
            return RedirectToAction("ListPosts");
        }
    }
}