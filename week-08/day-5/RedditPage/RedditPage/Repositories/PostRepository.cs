using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    public class PostRepository : IGenericRepository<Post>
    {
        private PostDbContext postContext;
        public PostRepository(PostDbContext postContext)
        {
            this.postContext = postContext;
        }

        public void Create(Post post)
        {
            postContext.Posts.Add(post);
        }

        public void Delete(int id)
        {
            var removablePost = postContext.Posts.ToList().FirstOrDefault(p => p.Id == id);
            postContext.Remove(removablePost);
            postContext.SaveChanges();
        }

        public List<Post> Search(string title)
        {
            var output = postContext.Posts.Where(t => t.Title.ToLower().Contains(title.ToLower())).ToList();
            return output;
        }

        public List<Post> Read()
        {
            return postContext.Posts.ToList();
        }

        public void Update(Post post)
        {
            postContext.Posts.Update(post);
            postContext.SaveChanges();
        }

        public void IncreaseVote(int id)
        {
            var votedElement = postContext.Posts.FirstOrDefault(p => p.Id == id);
            votedElement.Votes++;
            postContext.Update(votedElement);
            postContext.SaveChanges();
        }

        public void DecreaseVote(int id)
        {
            var votedElement = postContext.Posts.FirstOrDefault(p => p.Id == id);
            votedElement.Votes--;
            postContext.Update(votedElement);
            postContext.SaveChanges();
        }
    }
}
