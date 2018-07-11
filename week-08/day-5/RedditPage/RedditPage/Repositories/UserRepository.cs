using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private PostDbContext postDbContext;
        public UserRepository(PostDbContext postDbContext)
        {
            postDbContext = postDbContext;
        }

        public void Create(User user)
        {
            postDbContext.Users.Add(user);
            postDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var removableUser = postDbContext.Users.ToList().FirstOrDefault(p => p.Id == id);
            postDbContext.Remove(removableUser);
            postDbContext.SaveChanges();
        }

        public List<User> Read()
        {
            return postDbContext.Users.ToList();
        }

        public List<User> Search(string userName)
        {
            var output = postDbContext.Users.Where(t => t.UserName.ToLower().Contains(userName.ToLower())).ToList();
            return output;
        }

        public void Update(User user)
        {
            postDbContext.Users.Update(user);
            postDbContext.SaveChanges();
        }
    }
}
