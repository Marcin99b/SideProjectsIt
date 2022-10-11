using System;
using SideProjectsIt.Shared.Abstractions.Time;

namespace SideProjectsIt.Shared.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}