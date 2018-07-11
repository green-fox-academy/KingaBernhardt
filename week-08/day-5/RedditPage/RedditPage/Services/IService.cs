using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Services
{
    public interface IService
    {
        List<Post> SearchPost(string title);
        List<Post> ReadPosts();
        void CreatPost(Post post);
        void DeletePost(int id);
        void UpdatePost(Post post);
        void IncreaseVote(int id);
        void DecreaseVote(int id);

        void UpdateUser(User user);
        List<User> SearchUser(string userName);
        List<User> ReadUsers();
        void DeleteUser(int id);
        void CreateUser(User user);
    }
}
