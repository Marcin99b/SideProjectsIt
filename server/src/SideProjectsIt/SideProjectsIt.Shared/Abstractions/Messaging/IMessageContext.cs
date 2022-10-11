using System;
using SideProjectsIt.Shared.Abstractions.Contexts;

namespace SideProjectsIt.Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}