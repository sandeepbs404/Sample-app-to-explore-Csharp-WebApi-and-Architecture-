using System.Collections.Generic;
using System.Data.Entity;

namespace Persistence
{
    public class Repository<Entity> : IRepository<Entity> where Entity: class
    {
        protected DbContext Context { get; }
        protected DbSet<Entity> Entities { get; set; }
        public Repository(DbContext context)
        {
            Context = context;
            Entities = Context.Set<Entity>();
        }

        public Entity Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<Entity> GetAll()
        {
            return Entities;
        }
    }
}
