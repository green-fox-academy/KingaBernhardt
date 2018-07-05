using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repository
{
    public class AssigneRepository : IGenericRepository<Assigne>
    {
        private TodoContext todoCon;
        public AssigneRepository(TodoContext todoCon)
        {
            this.todoCon = todoCon;
        }

        public void Add(Assigne assigne)
        {
            todoCon.Assignes.Add(assigne);
        }

        public void Edit(Assigne assigne)
        {
            todoCon.Assignes.Update(assigne);
            todoCon.SaveChanges();
        }

        public Assigne GetId(long id)
        {
            return todoCon.Assignes.ToList().FirstOrDefault(x => x.Id == id);
        }

        public List<Assigne> GetList()
        {
            return todoCon.Assignes.ToList();
        }

        public List<Assigne> GetSearched(string name)
        {
            return todoCon.Assignes.Where(t => t.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public void Remove(int id)
        {
            var removableAssigne = todoCon.Assignes.ToList().FirstOrDefault(x => x.Id == id);
            todoCon.Assignes.Remove(removableAssigne);
            todoCon.SaveChanges();
        }
    }
}
