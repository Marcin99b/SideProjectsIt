using System.Threading;
using System.Threading.Tasks;
using SideProjectsIt.Shared.Abstractions.Commands;
using SideProjectsIt.Shared.Abstractions.Events;
using SideProjectsIt.Shared.Abstractions.Queries;

namespace SideProjectsIt.Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}