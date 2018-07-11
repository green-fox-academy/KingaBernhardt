using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    public class UserRepository :IGenericRepository<User>
    {
        private PostDbContext postContext;

        public UserRepository(PostDbContext postContext)
        {
            postContext = postContext;
        }

        public void Create(User user)
        {
            postContext.Users.Add(user);
            postContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var removableUser = postContext.Users.ToList().FirstOrDefault(p => p.Id == id);
            postContext.Remove(removableUser);
            postContext.SaveChanges();
        }

        public List<User> Read()
        {
            return postContext.Users.ToList();
        }

        public List<User> Search(string title)
        {
            throw new NotImplementedException();
        }

        public void Update(User element)
        {
            throw new NotImplementedException();
        }
    }
}
