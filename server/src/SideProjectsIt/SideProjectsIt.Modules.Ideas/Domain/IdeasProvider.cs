using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideProjectsIt.Modules.Ideas.Domain
{
    public interface IIdeasProvider
    {
        Idea[] Get();
    }

    public class IdeasProvider : IIdeasProvider
    {
        private readonly Idea[] ideas = new[] 
        {
            new Idea(1, "testA", "test description ABC"),
            new Idea(2, "testB", "test description BBB"),
        };

        public Idea[] Get() => ideas;
    }
}
