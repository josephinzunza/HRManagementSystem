namespace HRManagementSystem.Persistence.Repositories
{
    public sealed class UnitOfWork(HRMSDbContext hrmsDbContext) : IUnitOfWork
    {
        private readonly HRMSDbContext HRMSDbContext = hrmsDbContext;

        public IEmployeeRepository Employees { get; private set; } = new EmployeeRepository(hrmsDbContext);

        public int Complete()
        {
            return HRMSDbContext.SaveChanges();
        }

        public void Dispose()
        {
            HRMSDbContext.Dispose();   
        }
    }
}
