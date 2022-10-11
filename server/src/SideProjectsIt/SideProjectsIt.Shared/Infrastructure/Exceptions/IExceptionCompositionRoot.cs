using System;
using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Infrastructure.Exceptions;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}