using System;
using System.Threading.Tasks;
using CrudRepositoryPatternAndUnitOfWork.Core.IConfiguration;
using CrudRepositoryPatternAndUnitOfWork.Core.IRepositories;
using Microsoft.Extensions.Logging;

namespace CrudRepositoryPatternAndUnitOfWork.Core.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public IUserRepository Users { get; private set; }

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}