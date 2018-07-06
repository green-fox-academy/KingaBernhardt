using RedditPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditPage.Repositories
{
    interface IGenericRepository<Type>
    {
        void Create(Type element);
        List<Type> Read();
        List<Type> Search(string title);
        void Delete(int id);
        void Update(Type element);
    }
}
