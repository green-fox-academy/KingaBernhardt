﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class LoginController : Controller
    {
        private IGiraffeMaker giraffeMaker;

        public LoginController(IGiraffeMaker giraffeMaker)
        {
            this.giraffeMaker = giraffeMaker;
        }

        [HttpGet(" ")]
        public IActionResult GetLogIn()
        {
            return View("info");
            
        }

        [HttpPost]
        public IActionResult PostResult([FromForm]string petName)
        {
            giraffeMaker.SetName(petName);
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(giraffeMaker);
        }

        
    }
}