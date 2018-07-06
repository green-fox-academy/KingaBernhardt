using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditPage.Models;
using RedditPage.Repositories;

namespace RedditPage.Services
{
    public class PostService : IService
    {
        private PostRepository postRepo;
        public PostService(PostRepository postRepo)
        {
            this.postRepo = postRepo;
        }
        public void CreatPost(Post post)
        {
            postRepo.Create(post);
        }

        public void DecreaseVote(int id)
        {
            postRepo.DecreaseVote(id);
        }

        public void DeletePost(int id)
        {
            postRepo.Delete(id);
        }

        public void IncreaseVote(int id)
        {
            postRepo.IncreaseVote(id);
        }

        public List<Post> ReadPosts()
        {
            return postRepo.Read();
        }

        public List<Post> SearchPost(string title)
        {
            return postRepo.Search(title);
        }

        public void UpdatePost(Post post)
        {
            postRepo.Update(post);
        }
    }
}
