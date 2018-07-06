using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    public class PostRepository : IPostRepository
    {
        private PostDbContext postContext;
        public PostRepository(PostDbContext postContext)
        {
            this.postContext = postContext;
        }

        public void AddPost()
        {
            throw new NotImplementedException();
        }

        public void CreatePost()
        {
            throw new NotImplementedException();
        }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public Post ReadPost()
        {
            throw new NotImplementedException();
        }

        public List<Post> ReadPosts()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
