using Quiz1.DTO;
using Quiz1.Model;

namespace Quiz1.Repos.Abstraction
{
    public interface IGenericRepo<TEntity>where TEntity : class
    {
      
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public TEntity Create(TEntity entity);
        public TEntity Update(TEntity entity);
        public void Delete(int id);
        public void Save();
        
    }
}
