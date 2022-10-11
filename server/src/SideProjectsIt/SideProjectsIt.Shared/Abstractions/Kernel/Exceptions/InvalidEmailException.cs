using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Abstractions.Kernel.Exceptions;

public class InvalidEmailException : SideProjectsItException
{
    public string Email { get; }

    public InvalidEmailException(string email) : base($"Email: '{email}' is invalid.")
    {
        Email = email;
    }
}