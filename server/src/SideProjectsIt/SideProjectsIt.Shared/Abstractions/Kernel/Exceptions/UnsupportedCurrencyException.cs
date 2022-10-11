using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedCurrencyException : SideProjectsItException
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency) : base($"Currency: '{currency}' is unsupported.")
    {
        Currency = currency;
    }
}