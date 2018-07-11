using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public ICollection<Post> UserPosts { get; set; }
    }
}
