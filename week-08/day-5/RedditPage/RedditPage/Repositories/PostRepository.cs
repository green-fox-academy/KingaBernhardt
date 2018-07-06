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

        public void CreatePost(Post post)
        {
            postContext.Posts.Add(post);
        }

        public void DeletePost(int id)
        {
            var removablePost = postContext.Posts.ToList().FirstOrDefault(p => p.Id == id);
            postContext.Remove(removablePost);
            postContext.SaveChanges();
        }

        public List<Post> SearchPost(string title)
        {
            var output = postContext.Posts.Where(t => t.Title.ToLower().Contains(title.ToLower())).ToList();
            return output;
        }

        public List<Post> ReadPost()
        {
            return postContext.Posts.ToList();
        }

        public void Update(Post post)
        {
            postContext.Posts.Update(post);
            postContext.SaveChanges();
        }
    }
}
