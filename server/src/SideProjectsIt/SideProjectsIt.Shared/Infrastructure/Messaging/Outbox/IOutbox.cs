using System;
using System.Threading.Tasks;
using SideProjectsIt.Shared.Abstractions.Messaging;

namespace SideProjectsIt.Shared.Infrastructure.Messaging.Outbox;

public interface IOutbox
{
    bool Enabled { get; }
    Task SaveAsync(params IMessage[] messages);
    Task PublishUnsentAsync();
    Task CleanupAsync(DateTime? to = null);
}