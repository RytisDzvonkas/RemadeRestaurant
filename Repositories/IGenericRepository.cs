using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetId(int id);
        List<TEntity> GetAll();

        void AddItem(TEntity entity);

        void Remove(TEntity entity);
    }
}
