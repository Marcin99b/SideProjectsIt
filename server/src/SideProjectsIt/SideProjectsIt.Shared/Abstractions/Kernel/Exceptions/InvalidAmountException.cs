using SideProjectsIt.Shared.Abstractions.Exceptions;

namespace SideProjectsIt.Shared.Abstractions.Kernel.Exceptions;

public class InvalidAmountException : SideProjectsItException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount) : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}