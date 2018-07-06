using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Models
{
    public class Post
    {
        public long Id { get; set; }
        public int Votes { get; set; }
        public string Title { get; set; }
        public string PostUrl { get; set; }
    }
}
