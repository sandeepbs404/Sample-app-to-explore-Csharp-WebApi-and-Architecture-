using System.Collections.Generic;

namespace Persistence
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity Get(int id);
        IEnumerable<Entity GetAll();
    }
}
