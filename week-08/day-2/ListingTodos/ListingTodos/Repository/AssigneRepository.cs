using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repository
{
    public class AssigneRepository
    {
        private TodoContext todoCon;
        public AssigneRepository(TodoContext todoCon)
        {
            this.todoCon = todoCon;
        }

        public void GetAssigneList()
        {
            todoCon.Assignes.Add();
        }
    }
}
