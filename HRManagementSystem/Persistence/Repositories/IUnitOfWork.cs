namespace HRManagementSystem.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        int Complete();
    }
}
