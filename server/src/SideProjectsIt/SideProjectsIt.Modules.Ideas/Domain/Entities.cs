using SideProjectsIt.Shared.Persistance.Database;

namespace SideProjectsIt.Modules.Ideas.Domain
{
    public record Idea(int Id, string Title, string ShortDescription) : Entity(Id);
    public record IdeaDescription(int Id, int IdeaId, string Description) : Entity(Id);
    public record IdeaTagPair(int Id, int IdeaId, int TagId) : Entity(Id);
    public record Tag(int Id, string Name) : Entity(Id);
}
