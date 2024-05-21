
namespace EmployeeStat
{
    public interface IFileService
    {
        Task<List<Employee>> GetEmployeesAsync();
    }
}