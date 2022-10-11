using System.Threading.Tasks;

namespace SideProjectsIt.Shared.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}