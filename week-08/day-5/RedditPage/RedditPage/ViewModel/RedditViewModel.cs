using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.ViewModel
{
    public class RedditViewModel
    {
        public List<Post> Posts { get; set; }
        public User Users { get; set; }
    }
}
