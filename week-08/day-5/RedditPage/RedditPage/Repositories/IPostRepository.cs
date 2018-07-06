using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    interface IPostRepository
    {
        void CreatePost();
        Post ReadPost();
        List<Post> ReadPosts();
        void AddPost();
        void DeletePost();
        void Update();

    }
}
