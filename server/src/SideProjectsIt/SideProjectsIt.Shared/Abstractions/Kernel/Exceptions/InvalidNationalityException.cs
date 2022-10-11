using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Abstractions.Kernel.Exceptions;

public class InvalidNationalityException : SideProjectsItException
{
    public string Nationality { get; }

    public InvalidNationalityException(string nationality) : base($"Nationality: '{nationality}' is invalid.")
    {
        Nationality = nationality;
    }
}