using HRManagementSystem.Models;
using System.Linq.Expressions;

namespace HRManagementSystem.Persistence.Repositories
{
    public class StateRepository(HRMSDbContext HRMSDbContext) : Repository<State>(HRMSDbContext), IStateRepository
    {
    }
}
