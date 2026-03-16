using System.Linq.Expressions;

namespace HRManagementSystem.Repositories
{
    public interface IRepository<TEnity> where TEnity : class
    {
        TEnity? GetById(int id);
        IEnumerable<TEnity> GetAll();
        IEnumerable<TEnity> Find(Expression<Func<TEnity, bool>> predicate);
        void Add(TEnity entity);
        void AddRange(IEnumerable<TEnity> entities);
        void Remove(TEnity entity);
        void RemoveRange(IEnumerable<TEnity> entities);
    }
}
