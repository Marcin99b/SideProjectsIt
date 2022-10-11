using System;

namespace SideProjectsIt.Shared.Abstractions.Time;

public interface IClock
{
    DateTime CurrentDate();
}