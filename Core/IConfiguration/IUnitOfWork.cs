using System.Threading.Tasks;
using CrudRepositoryPatternAndUnitOfWork.Core.IRepositories;

namespace CrudRepositoryPatternAndUnitOfWork.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}