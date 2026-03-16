using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Repositories
{
    public class Repository<TEnity>(DbContext dbContext) : IRepository<TEnity> where TEnity : class
    {
        private readonly DbContext _context = dbContext;
        public TEnity? GetById(int id)
        {
            return _context.Set<TEnity>().Find(id);
        }
        public IEnumerable<TEnity> GetAll()
        {
            return [.. _context.Set<TEnity>()];
        }

        public IEnumerable<TEnity> Find(Expression<Func<TEnity, bool>> predicate)
        {
            return _context.Set<TEnity>().Where(predicate);
        }
        public void Add(TEnity entity)
        {
            _context.Set<TEnity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEnity> entities)
        {
            _context.Set<TEnity>().AddRange(entities);
        }

        public void Remove(TEnity entity)
        {
            _context.Set<TEnity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEnity> entities)
        {
            _context.Set<TEnity>().RemoveRange(entities);
        }
    }
}
