using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Abstractions.Kernel.Exceptions;

public class InvalidCurrencyException : SideProjectsItException
{
    public string Currency { get; }

    public InvalidCurrencyException(string currency) : base($"Currency: '{currency}' is invalid.")
    {
        Currency = currency;
    }
}