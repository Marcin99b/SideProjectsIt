using System;

namespace SideProjectsIt.Shared.Abstractions.Exceptions;

public abstract class SideProjectsItException : Exception
{
    protected SideProjectsItException(string message) : base(message)
    {
    }
}