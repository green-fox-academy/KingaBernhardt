﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditPage.Models;
using RedditPage.Services;
using RedditPage.ViewModel;

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
            return View(new RedditViewModel()
            { Posts=postService.ReadPosts(),
              Users =postService.ReadUsers()
            });
        }

        [HttpPost("{id}/Increase")]
        public IActionResult Increase(int id)
        {
            postService.IncreaseVote(id);
            return RedirectToAction("ListPosts");
        }

        [HttpPost("{id}/Decrease")]
        public IActionResult Decrease(int id)
        {
            postService.DecreaseVote(id);
            return RedirectToAction("ListPosts");
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

        [HttpPost("GetPost")]
        public IActionResult GetPost(string title)
        {
            return View("ListPosts", postService.SearchPost(title));
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("Login")]
        public IActionResult Login(User user)
        {
            postService.CreateUser(user);
            return RedirectToAction("AddPost");
        }
    }
}