using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    interface IGenericRepository
    {
        void CreatePost(Type element);
        List<Type> ReadPost();
        List<Type> SearchPost(Type element);
        void DeletePost(Type element);
        void Update(Type element);
    }
}
