using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    interface IPostRepository
    {
        void CreatePost(Post post);
        List<Post> ReadPost();
        List<Post> SearchPost(string title);
        void DeletePost(int id);
        void Update(Post post);
    }
}
