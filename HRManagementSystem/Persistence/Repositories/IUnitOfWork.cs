namespace HRManagementSystem.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IStateRepository States { get; }
        int Complete();
    }
}
