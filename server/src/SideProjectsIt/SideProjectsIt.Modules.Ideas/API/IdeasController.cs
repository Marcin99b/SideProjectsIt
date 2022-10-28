using Microsoft.AspNetCore.Mvc;
using SideProjectsIt.Modules.Ideas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideProjectsIt.Modules.Ideas.API
{
    //todo rewrite to dtos
    [ApiController]
    [Route("ideas")]
    public class IdeasController : ControllerBase
    {
        private readonly IIdeasProvider provider;

        public IdeasController(IIdeasProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public async Task<ActionResult<Idea[]>> Get()
        {
            var ideas = provider.Get();
            await Task.CompletedTask;
            return Ok(ideas!);
        }

        [HttpGet("{id:int}")]
        public Task<ActionResult<Idea>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<ActionResult> Post()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id:int}")]
        public Task<ActionResult> Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
