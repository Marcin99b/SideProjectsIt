﻿using System;
using SideProjectsIt.Shared.Abstractions.Contexts;
using SideProjectsIt.Shared.Abstractions.Messaging;

namespace SideProjectsIt.Shared.Infrastructure.Messaging.Contexts;

public class MessageContext : IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }

    public MessageContext(Guid messageId, IContext context)
    {
        MessageId = messageId;
        Context = context;
    }
}