﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<Post> UserPosts { get; set; }
    }
}
