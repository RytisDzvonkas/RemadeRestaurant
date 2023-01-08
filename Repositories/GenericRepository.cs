using RemadeRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity, new()
    {
        private List<TEntity> Data { get; set; }
        public GenericRepository()
        {
            Data = new List<TEntity>();
        }
        public GenericRepository(List<TEntity> data)
        {
            Data = data;
        }
        public void AddItem(TEntity entity)
        {
            Data.Add(entity);
        }

        public TEntity GetId(int id)
        {
            return Data.SingleOrDefault(x => x.Id == id);
        }

        public List<TEntity> GetAll()
        {
            return Data.ToList();
        }

        public void Remove(TEntity entity)
        {
            Data.Remove(entity);
        }
    }
}
