using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Quiz1.Data;
using Quiz1.DTO;
using Quiz1.Repos.Abstraction;

namespace Quiz1.Repos
{
    public class GenericRepo<TEntity> :IGenericRepo<TEntity> where TEntity:class 
    {
        private readonly AppDbContext _context;

        public GenericRepo(AppDbContext context)
        {
             _context=context;
        }
        public TEntity GetById(int id)
        {
            var res=_context.Set<TEntity>().Find(id);
            if(res == null)
            {
                
            }
            return res;  
        }
        public List<TEntity> GetAll()
        {
           var res= _context.Set<TEntity>().ToList();
            return res;
        }
        public TEntity Create(TEntity entity)
        {
           _context.Set<TEntity>().Add(entity);
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
           // var st = _context.Set<TEntity>().Find(id);
            _context.Update(entity);
            return entity;
        }
        public void Delete(int id)
        {
            var d = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(d);
            
        }
        public void Save()
        {
            _context.SaveChanges();
        }

     
    }

  
}
