using System.Threading;
using System.Threading.Tasks;
using SideProjectsIt.Shared.Abstractions.Messaging;

namespace SideProjectsIt.Shared.Infrastructure.Messaging.Dispatchers;

public interface IAsyncMessageDispatcher
{
    Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken = default)
        where TMessage : class, IMessage;
}