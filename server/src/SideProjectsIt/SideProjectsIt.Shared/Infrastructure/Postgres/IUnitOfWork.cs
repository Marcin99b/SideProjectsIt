using System;
using System.Threading.Tasks;

namespace SideProjectsIt.Shared.Infrastructure.Postgres;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}